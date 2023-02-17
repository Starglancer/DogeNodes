Imports Newtonsoft.Json.Linq
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Tulpep.NotificationWindow

Public Class Form1

    'New class based on webclient that allows timeout to be changed
    Public Class WebDownload

        Inherits WebClient

        Public Property Timeout As Integer

        Public Sub New()
            Me.New(60000)
        End Sub

        Public Sub New(ByVal timeout As Integer)
            Me.Timeout = timeout
        End Sub

        Protected Overrides Function GetWebRequest(ByVal address As Uri) As WebRequest
            Dim request = MyBase.GetWebRequest(address)

            If request IsNot Nothing Then
                request.Timeout = Me.Timeout
            End If

            Return request
        End Function

    End Class

    'Declare global variables
    Dim parsejson As JObject 'JSON Object to hold API data
    Dim json As String
    Dim MaxBlockHeight As Integer
    Dim CurrentAgentVersion As String
    Dim LastAPIUpdate As Date
    Dim ForceCloseFlag As Boolean
    Dim StatusColour As String
    Dim UpToDateColour As String
    Dim CurrentColour As String
    Dim LogFileName As String
    Dim MapCacheFileName As String
    Dim JSONFileName As String
    Dim IPLocations(,) As String
    Dim CacheCounter As Integer = 0
    Dim MapRefreshCounter As Integer = 0
    Dim FileWriteThread As System.Threading.Thread
    Dim FormLoadComplete As Boolean = False

    ReadOnly All As String = "- All -"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'Create an instance of the splashscreen
            Dim SplashScreen As Splash = New Splash

            'Show the splashscreen
            SplashScreen.Show()

            'Initialise logging
            Setup_Logging()

            'Load persistent notification settings required for logging
            chkApplicationNotification.Checked = My.Settings.ApplicationNotification
            chkWindowsNotification.Checked = My.Settings.WindowsNotification
            chkAllowLogging.Checked = My.Settings.AllowLogging
            chkAllowEmailNotification.Checked = My.Settings.AllowEmailNotification
            comAppNotifLvl.Text = My.Settings.ApplicationNotificationLevel
            comWinNotifLvl.Text = My.Settings.WindowsNotificationLevel
            comLogLvl.Text = My.Settings.LoggingLevel
            comEmailNotifLvl.Text = My.Settings.EmailNotificationLevel

            Notification_Display("Information", "Application Load has started")

            'Load remaining persistent settings
            CurrentAgentVersion = My.Settings.CurrentAgentVersion
            comStatistics.Text = My.Settings.Statistics
            lblGreenToYellow.Text = My.Settings.GreenToYellow
            lblYellowToRed.Text = My.Settings.YellowToRed
            txtIPAddress.Text = My.Settings.IPAddress
            txtPort.Text = My.Settings.NodePort
            chkHideTrayIcon.Checked = My.Settings.HideTrayIcon
            chkMinimiseToTray.Checked = My.Settings.MinimiseToTray
            chkMinimiseOnClose.Checked = My.Settings.MinimiseOnClose
            comStartup.Text = My.Settings.StartupTab
            txtSMTPHost.Text = My.Settings.SMTPHost
            txtSMTPPort.Text = My.Settings.SMTPPort
            txtSMTPUsername.Text = My.Settings.SMTPUsername
            txtSMTPPassword.Text = My.Settings.SMTPPassword
            chkUseSSL.Checked = My.Settings.UseSSL
            txtEmailAddress.Text = My.Settings.EmailAddress
            chkStartMinimised.Checked = My.Settings.StartMinimised
            chkStartWithWindows.Checked = My.Settings.StartWithWindows
            chkDesktopShortcut.Checked = My.Settings.DesktopShortcut
            chkShowTooltips.Checked = My.Settings.ShowTooltips
            chkHighlightCurrentNode.Checked = My.Settings.HighlightNode

            'Update sliders to persistent values
            trkGreenToYellow.Value = lblGreenToYellow.Text
            trkYellowToRed.Value = lblYellowToRed.Text

            'Display application version information and prompt user if a new version is available
            DogeNodes_Version()
            If btnUpdateNow.Enabled = True Then
                MessageBox.Show("A new version of DogeNodes is available. Please click on the 'Update Now' button in settings to update", "DogeNodes - Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'Set up map cache
            Set_Up_Map_Cache()

            'Initialise JSON Persistence
            Set_Up_JSON_Persistence()

            'Load IP Locations into array
            Read_IP_Locations()

            'Read last json string into global variable
            Read_JSON_String()

            'Get current agent version (Not Blockchair API dependent)
            Get_Current_Agent_Version()

            'Load data from web URL into the JSON Object and populate application fields
            Load_JSON()

            'Configure shortcuts
            Configure_Desktop_Shortcut()
            Configure_Startup_Shortcut()

            'Check if set to start minimised
            If chkStartMinimised.Checked = True Then
                WindowState = FormWindowState.Minimized
            Else
                WindowState = FormWindowState.Normal
            End If

            'Set visibility of tray icon
            Notify_Icon_Display()

            'set up timer
            timReloadData.Interval = 5000
            timReloadData.Enabled = True

            'Initial Check (Will be repeated at each timer tick)
            Check_For_API_Update()

            'Enable or disable the Force Close Button in settings
            Set_Force_Close_Button_Visibility()

            'Set Force close flag to false
            ForceCloseFlag = False

            'Update enabled controls in settings based on checkbox values
            Disable_Logging_Settings()
            Disable_Application_Notification_Settings()
            Disable_Windows_Notification_Settings()
            Disable_Email_Notification_Settings()

            'Open startup tab
            Open_Startup_Tab()

            'Start cache update process
            timUpdateCache.Enabled = True

            'Set up tooltips
            Configure_Tooltips()

            'Flag to indicate if form has finished loading.
            FormLoadComplete = True

            'Close the splashscreen
            SplashScreen.Close()

            Notification_Display("Information", "Application load completed successfully")

        Catch ex As Exception

            Notification_Display("Error", "There was an error in the application load", ex)

        End Try

    End Sub

    Private Sub Load_JSON()

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Try
            Notification_Display("Information", "The latest API download from blockchair has started")
            json = New WebDownload(2000).DownloadString("https://api.blockchair.com/dogecoin/nodes")
            Notification_Display("Information", "The latest API download from blockchair has completed successfully")
        Catch ex As Exception
            If json <> "" Then
                Notification_Display("Error", "Blockchair API is unreachable. Please check network connection", ex)
                'Carry on with rest of subroutine using the last value of json stored in the global variable
            Else
                'No global variable, so put out message and close application
                Notification_Display("Critical", "Internet connection required for application. Please try again later. Application will close")
                End
            End If
        End Try

        Try
            'Create JSON Object from string
            parsejson = JObject.Parse(json)

            'Update the last updated date in status bar
            sslLastUpdate.Text = "Last Updated: " + Get_Token("context.cache.since")

            'Save Last Updated date
            LastAPIUpdate = Convert.ToDateTime(Get_Token("context.cache.since"))

            'Store maximum block height
            Get_Maximum_Block_Height()

            'Populate total node count on summary tab
            lblTotalNodesValue.Text = Get_Token("data.count")

            'populate controls on node status tab
            Populate_NodeStatusTab()

            'populate Statistics
            Display_Statistics()

            'Load country dropdown list
            Load_Country_Dropdown()

            'Load height dropdown list
            Load_Height_Dropdown()

            'Load version dropdown list
            Load_Version_Dropdown()

            'Load network dropdown list
            Load_Network_Dropdown()

            'Reset Filters as new data may not contain selections
            comCountry.Text = All
            comHeight.Text = All
            ComVersion.Text = All
            comNetwork.Text = All

            'populate Node List
            Load_Nodes_Datagrid()

            Notification_Display("Information", "The JSON Load has completed successfully")

        Catch ex As Exception

            Notification_Display("Error", "There was an error in the JSON load", ex)

        End Try

    End Sub

    Private Sub Populate_NodeStatusTab()

        Dim NodeList As String
        Dim ParseNode As JObject
        Dim Status As Boolean
        Dim Lag As Integer
        Dim Protocol As String

        Try
            Protocol = Validate_IPAddress(txtIPAddress.Text)

            'Check if both IP Address and Port are supplied with valid contents
            If txtIPAddress.Text = "" Or txtPort.Text = "" Or Protocol = "Invalid" Or Validate_Port(txtPort.Text) = False Then

                'Clear Details
                lblVersionValue.Text = ""
                lblCountryValue.Text = ""
                lblHeightValue.Text = ""
                lblProtocolValue.Text = ""

                'Clear Status indicators
                pbxStatus.Image = My.Resources.Grey
                StatusColour = "Grey"
                pbxUpToDate.Image = My.Resources.Grey
                UpToDateColour = "Grey"
                pbxCurrent.Image = My.Resources.Grey
                CurrentColour = "Grey"

                Notification_Display("Warning", "IP Address or Port are invalid")

            Else

                Notification_Display("Information", "IP Address and Port are valid")

                'IP Address valid, so call routine to get additional IP Address information
                Populate_IP_Address_Details()

                'Return the data about an individual Node
                NodeList = parsejson.SelectToken("data.nodes").ToString
                ParseNode = JObject.Parse(NodeList)

                'Update Details
                If ParseNode.ContainsKey(txtIPAddress.Text + ":" + txtPort.Text) Then

                    'Save Status for later
                    Status = True

                    'Populate Details
                    lblVersionValue.Text = Get_Token("data.nodes.['" + txtIPAddress.Text + ":" + txtPort.Text + "'].version")
                    lblCountryValue.Text = Get_Token("data.nodes.['" + txtIPAddress.Text + ":" + txtPort.Text + "'].country")
                    lblHeightValue.Text = Get_Token("data.nodes.['" + txtIPAddress.Text + ":" + txtPort.Text + "'].height")
                    lblProtocolValue.Text = Protocol
                Else

                    'Save Status for later
                    Status = False

                    'Clear Details
                    lblVersionValue.Text = ""
                    lblCountryValue.Text = ""
                    lblHeightValue.Text = ""
                    lblProtocolValue.Text = ""
                End If

                'Update Status Indicator
                If Status = True Then
                    pbxStatus.Image = My.Resources.Green
                    StatusColour = "Green"
                    Notification_Display("Information", "Node is online")
                Else
                    pbxStatus.Image = My.Resources.Red
                    StatusColour = "Red"
                    Notification_Display("Warning", "Node is offline")
                End If

                'Update Up-To-Date Indicator
                If Status = True Then
                    Lag = MaxBlockHeight - lblHeightValue.Text
                    If Lag < 0 Then
                        pbxUpToDate.Image = My.Resources.Grey
                        UpToDateColour = "Grey"
                        Notification_Display("Warning", "Node block height is invalid")
                    ElseIf Lag >= 0 And Lag < lblGreenToYellow.Text Then
                        pbxUpToDate.Image = My.Resources.Green
                        UpToDateColour = "Green"
                        Notification_Display("Information", "Node block height is up to date")
                    ElseIf Lag >= lblGreenToYellow.Text And Lag < lblYellowToRed.Text Then
                        pbxUpToDate.Image = My.Resources.Yellow
                        UpToDateColour = "Yellow"
                        Notification_Display("Warning", "Node block height is slightly behind")
                    Else
                        pbxUpToDate.Image = My.Resources.Red
                        UpToDateColour = "Red"
                        Notification_Display("Warning", "Node block height is significantly behind")
                    End If
                Else
                    pbxUpToDate.Image = My.Resources.Grey
                    UpToDateColour = "Grey"
                End If

                'Update Current Indicator
                If Status = True Then
                    Dim AgentVersion As String = lblVersionValue.Text
                    If AgentVersion.Length < 12 Then
                        pbxCurrent.Image = My.Resources.Grey
                        CurrentColour = "Grey"
                        Notification_Display("Warning", "Agent version not recognised")
                    ElseIf AgentVersion.Remove(12) <> "/Shibetoshi:" Then
                        pbxCurrent.Image = My.Resources.Grey
                        CurrentColour = "Grey"
                        Notification_Display("Warning", "Agent version not recognised")
                    ElseIf AgentVersion.Remove(CurrentAgentVersion.Length) = CurrentAgentVersion Then
                        pbxCurrent.Image = My.Resources.Green
                        CurrentColour = "Green"
                        Notification_Display("Information", "Agent version is up to date")
                    Else
                        pbxCurrent.Image = My.Resources.Red
                        CurrentColour = "Red"
                        Notification_Display("Warning", "Agent version is out of date")
                    End If
                Else
                    pbxCurrent.Image = My.Resources.Grey
                    CurrentColour = "Grey"
                End If

            End If

            're-populate the node map if current node is displayed on map
            If chkHighlightCurrentNode.Checked = True Then
                Populate_Node_Map()
            End If

            'Set the tray icon appearance dependent on status
            Set_Tray_Icon_Appearance()

            Notification_Display("Information", "Population of the node status tab has completed successfully")

        Catch ex As Exception

            Notification_Display("Error", "There was an error populating the node status tab", ex)

        End Try

    End Sub

    Private Sub sslError_Click(sender As Object, e As EventArgs) Handles sslError.Click

        'clear error message in the status bar
        Clear_Application_Notification()

    End Sub

    Private Sub Notification_Display(Severity As String, Message As String, Optional ex As Exception = Nothing)

        Try
            'display notification in the appropriate places
            If Severity = "Critical" Then
                Display_MessageBox_Notification(Message)
            Else
                If chkApplicationNotification.Checked = True Then
                    If comAppNotifLvl.Text = "Warning and Error" And Severity <> "Information" Then Display_Application_Notification(Severity, Message)
                    If comAppNotifLvl.Text = "Error Only" And Severity = "Error" Then Display_Application_Notification(Severity, Message)
                End If
                If chkWindowsNotification.Checked = True Then
                    If comWinNotifLvl.Text = "Warning and Error" And Severity <> "Information" Then Display_Windows_Notification(Severity, Message)
                    If comWinNotifLvl.Text = "Error Only" And Severity = "Error" Then Display_Windows_Notification(Severity, Message)
                End If
                If chkAllowLogging.Checked = True Then
                    If comLogLvl.Text = "Everything" Then Log_Notification(Severity, Message)
                    If comLogLvl.Text = "Warning and Error" And Severity <> "Information" Then Log_Notification(Severity, Message)
                    If comLogLvl.Text = "Error Only" And Severity = "Error" Then Log_Notification(Severity, Message)
                    If comLogLvl.Text = "Debug" And Severity = "Error" And Not ex Is Nothing Then Log_Notification(Severity, Message, ex)
                End If
                If chkAllowEmailNotification.Checked = True Then
                    If comEmailNotifLvl.Text = "Warning and Error" And Severity <> "Information" Then Send_Email_Notification(Severity, Message)
                    If comEmailNotifLvl.Text = "Error Only" And Severity = "Error" Then Send_Email_Notification(Severity, Message)
                End If
            End If

        Catch
            Display_MessageBox_Notification("There has been a critical error in the notification display flow")
        End Try

    End Sub

    Private Sub Display_Application_Notification(Severity As String, Message As String)

        Try
            'display notification in the status bar
            sslError.Text = Message
            Select Case Severity
                Case "Warning"
                    sslError.BackColor = Color.Yellow
                    sslError.ForeColor = Color.Black
                Case "Error"
                    sslError.BackColor = Color.Red
                    sslError.ForeColor = Color.White
            End Select

            'Set Timer to 8 seconds to clear notification
            timClearError.Interval = 8000

            'Reset timer in case its already running
            timClearError.Enabled = False
            timClearError.Enabled = True

        Catch
            Display_MessageBox_Notification("There has been a critical error in the application notification display")
        End Try

    End Sub

    Private Sub Clear_Application_Notification()

        'Clear notification in the status bar
        sslError.Text = ""
        sslError.BackColor = Control.DefaultBackColor

    End Sub

    Private Function Get_Token(Token As String) As String

        Dim Value As String

        Try
            'Get a single token from the JSON object
            Value = parsejson.SelectToken(Token).ToString

            Notification_Display("Information", "The value of " + Value + " was returned successfully for token " + Token)
        Catch ex As Exception
            Notification_Display("Error", "There was a problem retrieving a value for token " + Token, ex)
            Value = ""
        End Try

        Return Value

    End Function

    Private Sub txtIPAddress_TextChanged(sender As Object, e As EventArgs) Handles txtIPAddress.TextChanged

        'Only refresh if user making change
        If TabControl1.SelectedTab Is tabNodestatus Then
            Populate_NodeStatusTab()
        End If

    End Sub

    Private Sub txtPort_TextChanged(sender As Object, e As EventArgs) Handles txtPort.TextChanged

        'Only refresh if user making change
        If TabControl1.SelectedTab Is tabNodestatus Then
            Populate_NodeStatusTab()
        End If

    End Sub

    Private Function Validate_IPAddress(Input As String) As String

        Dim Result As String

        Try
            'Check if supplied string is a valid IP Address
            If Regex.IsMatch(Input, "\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b") Then
                Result = "IPv4"
            ElseIf Regex.IsMatch(Input, "(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))") Then
                Result = "IPv6"
            Else
                Result = "Invalid"
            End If

            Notification_Display("Information", "The IP Address " + Input + " was found to be " + Result)

        Catch ex As Exception
            Notification_Display("Error", "There was an error in validating the IP Address " + Input, ex)
            Result = ""
        End Try

        Return Result

    End Function

    Private Function Validate_Port(Input As String) As Boolean

        Dim Valid As Boolean

        Try
            'Check if supplied string is a valid Port
            Valid = Regex.IsMatch(Input, "^([1-9][0-9]{0,3}|[1-5][0-9]{4}|6[0-4][0-9]{3}|65[0-4][0-9]{2}|655[0-2][0-9]|6553[0-5])$")

            Notification_Display("Information", "The port " + Input + " was found to be " + Valid.ToString)

        Catch ex As Exception
            Notification_Display("Error", "There was an error in validating the port " + Input, ex)
            Valid = Nothing
        End Try

        Return Valid

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timReloadData.Tick

        Check_For_API_Update()

    End Sub

    Private Sub Load_Country_Datagrid()

        'Local Variables
        Dim parsecountry As JObject = parsejson.SelectToken("data.countries")
        Dim countries As List(Of JToken) = parsecountry.Children().ToList()
        Dim Country As String()
        Dim Count As Integer = 0
        Dim MaxResult As Integer

        Try
            'Set appropriate column header
            grdStatistics.Columns(0).HeaderText = "Country"

            'Populate data to rows and columns
            For Each JToken In countries
                Country = JToken.ToString.Split(New Char() {":"c})
                Country(0) = Country(0).Trim("""")
                grdStatistics.Rows.Add()
                grdStatistics.Rows(Count).Cells(0).Value = Country(0)
                grdStatistics.Rows(Count).Cells(1).Value = Country(1)
                If Count = 0 Then MaxResult = Country(1)

                'Display Status Bar
                grdStatistics.Rows(Count).Cells(2).Value = BarChartText(MaxResult, Country(1))

                Count += 1
            Next

            'Display Row Count
            lblRowCount.Text = Count.ToString
            lblRows.Text = "Countries"

            Notification_Display("Information", "The country datagrid was loaded successfully with " + Count.ToString + " rows")

        Catch ex As Exception
            Notification_Display("Error", "There was an error in loading the country datagrid", ex)
        End Try

    End Sub

    Private Sub Load_Height_Datagrid()

        'Local Variables
        Dim parseheight As JObject = parsejson.SelectToken("data.heights")
        Dim heights As List(Of JToken) = parseheight.Children().ToList()
        Dim Height As String()
        Dim Count As Integer = 0
        Dim MaxResult As Integer

        Try
            'Set appropriate column header
            grdStatistics.Columns(0).HeaderText = "Height"

            'Populate data to rows and columns
            For Each JToken In heights
                Height = JToken.ToString.Split(New Char() {":"c})
                Height(0) = Height(0).Trim("""")
                grdStatistics.Rows.Add()
                grdStatistics.Rows(Count).Cells(0).Value = Height(0)
                grdStatistics.Rows(Count).Cells(1).Value = Height(1)
                If Count = 0 Then MaxResult = Height(1)

                'Display Status Bar
                grdStatistics.Rows(Count).Cells(2).Value = BarChartText(MaxResult, Height(1))

                Count += 1
            Next

            'Display Row Count
            lblRowCount.Text = Count.ToString
            lblRows.Text = "Heights"

            Notification_Display("Information", "The height datagrid was loaded successfully with " + Count.ToString + " rows")

        Catch ex As Exception
            Notification_Display("Error", "There was an error in loading the height datagrid", ex)
        End Try

    End Sub

    Private Sub Load_Version_Datagrid()

        'Local Variables
        Dim parseversion As JObject = parsejson.SelectToken("data.versions")
        Dim versions As List(Of JToken) = parseversion.Children().ToList()
        Dim VersionString As String
        Dim Version As String()
        Dim Count As Integer = 0
        Dim MaxResult As Integer

        Try
            grdStatistics.Columns(0).HeaderText = "Version"

            'Populate data to rows and columns
            For Each JToken In versions
                VersionString = JToken.ToString.Replace(": ", ":" + ChrW(&H2588))
                Version = VersionString.Split(New Char() {ChrW(&H2588)})
                Version(0) = Version(0).Trim(":")
                Version(0) = Version(0).Trim("""")
                grdStatistics.Rows.Add()
                grdStatistics.Rows(Count).Cells(0).Value = Version(0)
                grdStatistics.Rows(Count).Cells(1).Value = Version(1)
                If Count = 0 Then MaxResult = Version(1)

                'Display Status Bar
                grdStatistics.Rows(Count).Cells(2).Value = BarChartText(MaxResult, Version(1))

                Count += 1
            Next

            'Display Row Count
            lblRowCount.Text = Count.ToString
            lblRows.Text = "Versions"

            Notification_Display("Information", "The version datagrid was loaded successfully with " + Count.ToString + " rows")

        Catch ex As Exception
            Notification_Display("Error", "There was an error in loading the version datagrid", ex)
        End Try

    End Sub
    Private Sub Load_Protocol_Datagrid()

        'Local Variables
        Dim parsenodes As JObject = parsejson.SelectToken("data.nodes")
        Dim nodes As List(Of JToken) = parsenodes.Children().ToList()
        Dim Token As String()
        Dim IPv6 As Integer = 0
        Dim IPv4 As Integer = 0
        Dim MaxResult As Integer

        Try
            grdStatistics.Columns(0).HeaderText = "Protocol"

            'Calculate counts of protocols
            For Each JToken In nodes
                Token = JToken.ToString.Split(New Char() {""""c})
                If Token(1).Contains(".") Then
                    IPv4 += 1
                Else
                    IPv6 += 1
                End If
            Next

            grdStatistics.Rows.Add(2)

            If IPv4 > IPv6 Then
                MaxResult = IPv4
                grdStatistics.Rows(0).Cells(0).Value = "IPv4"
                grdStatistics.Rows(0).Cells(1).Value = IPv4
                grdStatistics.Rows(0).Cells(2).Value = BarChartText(MaxResult, IPv4)
                grdStatistics.Rows(1).Cells(0).Value = "IPv6"
                grdStatistics.Rows(1).Cells(1).Value = IPv6
                grdStatistics.Rows(1).Cells(2).Value = BarChartText(MaxResult, IPv6)
            Else
                MaxResult = IPv6
                grdStatistics.Rows(0).Cells(0).Value = "IPv6"
                grdStatistics.Rows(0).Cells(1).Value = IPv6
                grdStatistics.Rows(0).Cells(2).Value = BarChartText(MaxResult, IPv6)
                grdStatistics.Rows(1).Cells(0).Value = "IPv4"
                grdStatistics.Rows(1).Cells(1).Value = IPv4
                grdStatistics.Rows(1).Cells(2).Value = BarChartText(MaxResult, IPv4)
            End If

            'Display Row Count
            lblRowCount.Text = 2
            lblRows.Text = "Protocols"

            Notification_Display("Information", "The protocol datagrid was loaded successfully with 2 rows")

        Catch ex As Exception
            Notification_Display("Error", "There was an error in loading the protocol datagrid", ex)
        End Try

    End Sub

    Private Sub Display_Statistics()

        Try
            'Clear Datagrid
            grdStatistics.Rows.Clear()

            'Choose correct method to populate datagrid
            If comStatistics.Text = "Country" Then
                Load_Country_Datagrid()
            ElseIf comStatistics.Text = "Height" Then
                Load_Height_Datagrid()
            ElseIf comStatistics.Text = "Version" Then
                Load_Version_Datagrid()
            ElseIf comStatistics.Text = "Protocol" Then
                Load_Protocol_Datagrid()
            Else
                'If selection not recognised then default to Country
                comStatistics.Text = "Country"
                Load_Country_Datagrid()
            End If

            Notification_Display("Information", "The statistics datagrid has been successfully selected as " + comStatistics.Text)
        Catch ex As Exception
            Notification_Display("Error", "There was an error in selecting the statistics datagrid", ex)
        End Try

    End Sub

    Private Sub comStatistics_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comStatistics.SelectionChangeCommitted

        Display_Statistics()

        'Remove Focus from dropdown by setting focus to label (Any non editable control would do)
        lblStatisticsSelect.Focus()

    End Sub

    Private Function BarChartText(Maximum As Integer, Value As Integer) As String

        'Return a string of blocks whose length relates to the percentage of maximum value
        Dim BarChart As String = ""
        Dim Count As Decimal = 27 * Value / Maximum
        Dim CountInt As Integer = Math.Truncate(Count)

        Try
            Count -= CountInt

            While CountInt > 0
                BarChart += ChrW(&H2589)
                CountInt -= 1
            End While

            If CountInt = 0 And Count < 0.25 Then BarChart += ChrW(&H258F)
            If Count > 0.25 And Count <= 0.5 Then BarChart += ChrW(&H258F)
            If Count > 0.5 And Count <= 0.75 Then BarChart += ChrW(&H258E)
            If Count > 0.75 And Count < 1 Then BarChart += ChrW(&H258D)

        Catch ex As Exception
            Notification_Display("Error", "There was an error generating the barchart text", ex)
        End Try

        Return BarChart

    End Function

    Private Sub Load_Nodes_Datagrid()

        'Local Variables
        Dim parsenodes As JObject = parsejson.SelectToken("data.nodes")
        Dim nodes As List(Of JToken) = parsenodes.Children().ToList()
        Dim Token As String()
        Dim Node As String()
        Dim Height As String = ""
        Dim Count As Integer = 0
        Dim Include As Boolean
        Dim IPAddress As String
        Dim Port As String
        Dim n As Integer

        Try
            'Clear Node List
            grdNodeList.Rows.Clear()

            'Populate data to rows and columns
            For Each JToken In nodes

                Token = JToken.ToString.Split(New Char() {""""c})
                Include = True

                'Filter By country, height and version
                If comCountry.Text <> All And Token(9) <> comCountry.Text Then Include = False
                If comHeight.Text <> All Then Height = Regex.Replace(Token(12), "[^\d]", "")
                If comHeight.Text <> All And Height <> comHeight.Text Then Include = False
                If ComVersion.Text <> All And Token(5) <> ComVersion.Text Then Include = False

                'Continue if meets country, height and version filters
                If Include = True Then
                    Node = Token(1).Split(New Char() {":"c})
                    IPAddress = Node(0)
                    For n = 1 To Node.Length - 2
                        IPAddress += ":" + Node(n)
                    Next
                    Port = Node(Node.Length - 1)
                    IPAddress = IPAddress.Trim("""")
                    Port = Port.Trim("""")

                    'Filter by network protocol
                    If comNetwork.Text = All Or (comNetwork.Text = "IPv4" And IPAddress.Contains(".")) Or (comNetwork.Text = "IPv6" And IPAddress.Contains(":")) Then
                        grdNodeList.Rows.Add()
                        grdNodeList.Rows(Count).Cells(0).Value = IPAddress
                        grdNodeList.Rows(Count).Cells(1).Value = Port
                        Count += 1
                    End If
                End If
            Next

            'Display number of nodes found
            lblNodeRowsCount.Text = Count.ToString

            'Redraw the nodes map
            Populate_Node_Map()

            Notification_Display("Information", "The nodes datagrid was loaded successfully with " + Count.ToString + " rows")

        Catch ex As Exception
            Notification_Display("Error", "There was an error in loading the nodes datagrid", ex)
        End Try

    End Sub

    Private Sub Load_Country_Dropdown()

        'Local Variables
        Dim parsecountry As JObject = parsejson.SelectToken("data.countries")
        Dim countries As List(Of JToken) = parsecountry.Children().ToList()
        Dim Country As String()

        Try
            'Clear existing list
            comCountry.Items.Clear()

            'Add an All option at start of list
            comCountry.Items.Add(All)

            'Populate data to dropdown list
            For Each JToken In countries
                Country = JToken.ToString.Split(New Char() {":"c})
                Country(0) = Country(0).Trim("""")
                comCountry.Items.Add(Country(0))
            Next

            Notification_Display("Information", "The country dropdown has been populated successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error populating the country dropdown", ex)
        End Try

    End Sub

    Private Sub Load_Height_Dropdown()

        'Local Variables
        Dim parseheight As JObject = parsejson.SelectToken("data.heights")
        Dim heights As List(Of JToken) = parseheight.Children().ToList()
        Dim Height As String()

        Try
            'Clear existing list
            comHeight.Items.Clear()

            'Add an All option at start of list
            comHeight.Items.Add(All)

            'Populate data to dropdown list
            For Each JToken In heights
                Height = JToken.ToString.Split(New Char() {":"c})
                Height(0) = Height(0).Trim("""")
                comHeight.Items.Add(Height(0))
            Next

            Notification_Display("Information", "The height dropdown has been populated successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error populating the height dropdown", ex)
        End Try

    End Sub

    Private Sub Load_Version_Dropdown()

        'Local Variables
        Dim parseversion As JObject = parsejson.SelectToken("data.versions")
        Dim versions As List(Of JToken) = parseversion.Children().ToList()
        Dim VersionString As String
        Dim Version As String()

        Try
            'Add an All option at start of list
            ComVersion.Items.Add(All)

            'Populate data to dropdown list
            For Each JToken In versions
                VersionString = JToken.ToString.Replace(": ", ":" + ChrW(&H2588))
                Version = VersionString.Split(New Char() {ChrW(&H2588)})
                Version(0) = Version(0).Trim(":")
                Version(0) = Version(0).Trim("""")
                ComVersion.Items.Add(Version(0))
            Next

            Notification_Display("Information", "The version dropdown has been populated successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error populating the version dropdown", ex)
        End Try

    End Sub

    Private Sub Load_Network_Dropdown()

        Try
            'Clear existing list
            comNetwork.Items.Clear()

            'Add an All option at start of list
            comNetwork.Items.Add(All)

            'Populate remaining values
            comNetwork.Items.Add("IPv4")
            comNetwork.Items.Add("IPv6")

            Notification_Display("Information", "The network dropdown has been populated successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error populating the network dropdown", ex)
        End Try

    End Sub

    Private Sub comCountry_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comCountry.SelectionChangeCommitted

        Load_Nodes_Datagrid()

    End Sub

    Private Sub comHeight_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comHeight.SelectionChangeCommitted

        Load_Nodes_Datagrid()

    End Sub

    Private Sub ComVersion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComVersion.SelectionChangeCommitted

        Load_Nodes_Datagrid()

    End Sub

    Private Sub comNetwork_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles comNetwork.SelectionChangeCommitted

        Load_Nodes_Datagrid()

    End Sub

    Private Sub grdNodeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdNodeList.CellContentClick

        Try
            'Set IP Address and Port Values in Node Details tab
            txtIPAddress.Text = grdNodeList.Rows(e.RowIndex).Cells(0).Value
            txtPort.Text = grdNodeList.Rows(e.RowIndex).Cells(1).Value

            'Refresh the node details
            Populate_NodeStatusTab()

            'Switch to Node Status tab
            TabControl1.SelectedTab = tabNodestatus

            'Move focus away from IPAddress textbox to make tab look nicer (its irrelevant where focus is set to)
            gbxStatus.Focus()

            Notification_Display("Information", "The node " + txtIPAddress.Text + ":" + txtPort.Text + " was successfully selected from the node list")
        Catch ex As Exception
            Notification_Display("Error", "There was an error selecting the node from the node list", ex)
        End Try

    End Sub

    Private Sub lblTotalNodesValue_Click(sender As Object, e As EventArgs) Handles lblTotalNodesValue.Click

        Try
            'Reset all filters to show all nodes
            comCountry.Text = All
            comHeight.Text = All
            ComVersion.Text = All
            comNetwork.Text = All

            'Refresh node list
            Load_Nodes_Datagrid()

            'Switch to Node List tab
            TabControl1.SelectedTab = tabNodeList

            Notification_Display("Information", "The node list for all nodes has been displayed successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error displaying the node list for all nodes", ex)
        End Try

    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click

        Try
            'Reset all filters to show all nodes
            comCountry.Text = All
            comHeight.Text = All
            ComVersion.Text = All
            comNetwork.Text = All

            Load_Nodes_Datagrid()

            Notification_Display("Information", "All the node list filters have been cleared successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error clearing all the node list filters", ex)
        End Try

    End Sub

    Private Sub grdStatistics_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStatistics.CellContentClick

        Try
            'Set Search Parameters dependent on which Statistics are being shown
            If comStatistics.Text = "Country" Then
                comCountry.Text = grdStatistics.Rows(e.RowIndex).Cells(0).Value
                comHeight.Text = All
                ComVersion.Text = All
                comNetwork.Text = All
            ElseIf comStatistics.Text = "Height" Then
                comHeight.Text = grdStatistics.Rows(e.RowIndex).Cells(0).Value
                comCountry.Text = All
                ComVersion.Text = All
                comNetwork.Text = All
            ElseIf comStatistics.Text = "Version" Then
                ComVersion.Text = grdStatistics.Rows(e.RowIndex).Cells(0).Value
                comCountry.Text = All
                comHeight.Text = All
                comNetwork.Text = All
            ElseIf comStatistics.Text = "Protocol" Then
                comNetwork.Text = grdStatistics.Rows(e.RowIndex).Cells(0).Value
                comCountry.Text = All
                comHeight.Text = All
                ComVersion.Text = All
            Else
                comCountry.Text = All
                comHeight.Text = All
                ComVersion.Text = All
                comNetwork.Text = All
            End If

            'Refresh grid contents
            Load_Nodes_Datagrid()

            'Switch to Node List tab
            TabControl1.SelectedTab = tabNodeList

            Notification_Display("Information", "Node list has been made active with the " + comStatistics.Text + " filter set to " + grdStatistics.Rows(e.RowIndex).Cells(0).Value)
        Catch ex As Exception
            Notification_Display("Error", "There was an error displaying the node list filtered on " + comStatistics.Text, ex)
        End Try

    End Sub

    Private Sub Check_For_API_Update()

        Try
            Dim Difference As Long
            Dim Percentage As Integer

            'Check progress towards new update
            Difference = DateDiff(DateInterval.Second, LastAPIUpdate, Date.Now)

            'Reload data from API into JSON Object if more than 10 minutes since last update
            If Difference > 600 Then
                Load_JSON()
                'Get new difference
                Difference = DateDiff(DateInterval.Second, LastAPIUpdate, Date.Now)
            End If

            'Display progress in progress bar
            Percentage = Difference / 6
            If Percentage < 0 Then Percentage = 0
            If Percentage > 100 Then Percentage = 100
            sslAPIProgressBar.Value = Percentage

            'Do not log a success message as there would be one message per 5 seconds in the log!!
        Catch ex As Exception
            Notification_Display("Error", "There was an error during the regular check for an API update", ex)
        End Try

    End Sub

    Private Sub Get_Current_Agent_Version()

        'Load the data from the github API into a JSON object

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim jsonRelease As String
        Dim client As New WebDownload(2000)

        Try
            client.Headers.Add("user-agent", "request")

            Try
                Notification_Display("Information", "The API download from github has started")
                jsonRelease = client.DownloadString("https://api.github.com/repos/dogecoin/dogecoin/releases/latest")
                Notification_Display("Information", "The API download from github has completed successfully")
            Catch ex As Exception
                Notification_Display("Error", "Github API is unreachable. Please check network connection", ex)
                'Exit the sub leaving the last retrieved agent version in the global variable
                Exit Sub
            End Try

            Dim parseRelease As JObject = JObject.Parse(jsonRelease)

            Dim Version As String = parseRelease.SelectToken("tag_name").ToString
            Version = Version.TrimStart("v")
            Version = "/Shibetoshi:" + Version

            CurrentAgentVersion = Version

            Notification_Display("Information", "The current agent version has been successfully identified as " + Version)
        Catch ex As Exception
            Notification_Display("Error", "There was an error identifying the current agent version. It will be left as " + CurrentAgentVersion, ex)
        End Try

    End Sub

    Private Sub Get_Maximum_Block_Height()

        Try
            'Local Variables
            Dim parseheight As JObject = parsejson.SelectToken("data.heights")
            Dim heights As List(Of JToken) = parseheight.Children().ToList()
            Dim Height As String()
            Dim LatestBlockHeight As Integer

            'Get Latest block height
            LatestBlockHeight = Get_Token("context.state")
            LatestBlockHeight += 20

            'initiate max block height to zero
            MaxBlockHeight = 0

            'Cycle through all heights to find the highest
            For Each JToken In heights
                Height = JToken.ToString.Split(New Char() {":"c})
                Height(0) = Height(0).Trim("""")
                If Height(0) > MaxBlockHeight And Height(0) <= LatestBlockHeight Then MaxBlockHeight = Height(0)
            Next

            Notification_Display("Information", "The maximum block height has been successfully identified as " + MaxBlockHeight.ToString)
        Catch ex As Exception
            Notification_Display("Error", "There was an error identifying the maximum block height", ex)
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            'Minimise instead of close
            If chkMinimiseOnClose.Checked = True And ForceCloseFlag = False And e.CloseReason = CloseReason.UserClosing Then
                WindowState = FormWindowState.Minimized
                e.Cancel = True
                Notification_Display("Information", "The application is being minimised")
            Else
                Notification_Display("Information", "The application is being closed")
            End If

            'Set Force close flag to false
            ForceCloseFlag = False

        Catch ex As Exception
            Notification_Display("Error", "There was an error closing/minimising the application", ex)
        End Try

    End Sub

    Private Sub btnRestoreDefaults_Click(sender As Object, e As EventArgs) Handles btnRestoreDefaults.Click

        Try
            'Get Confirmation
            If Request_Confirmation("This will lose all your personalised settings") = True Then
                lblGreenToYellow.Text = My.Settings.GreenToYellowDefault
                lblYellowToRed.Text = My.Settings.YellowToRedDefault
                chkHideTrayIcon.Checked = My.Settings.HideTrayIconDefault
                chkMinimiseToTray.Checked = My.Settings.MinimiseToTrayDefault
                chkMinimiseOnClose.Checked = My.Settings.MinimiseOnCloseDefault
                comStartup.Text = My.Settings.StartupTabDefault
                chkApplicationNotification.Checked = My.Settings.ApplicationNotificationDefault
                chkWindowsNotification.Checked = My.Settings.WindowsNotificationDefault
                chkAllowLogging.Checked = My.Settings.AllowLoggingDefault
                chkAllowEmailNotification.Checked = My.Settings.AllowEmailNotificationDefault
                comAppNotifLvl.Text = My.Settings.ApplicationNotificationLevelDefault
                comWinNotifLvl.Text = My.Settings.WindowsNotificationLevelDefault
                comLogLvl.Text = My.Settings.LoggingLevelDefault
                comEmailNotifLvl.Text = My.Settings.EmailNotificationLevelDefault
                chkStartMinimised.Checked = My.Settings.StartMinimisedDefault
                chkStartWithWindows.Checked = My.Settings.StartWithWindowsDefault
                chkDesktopShortcut.Checked = My.Settings.DesktopShortcutDefault
                chkShowTooltips.Checked = My.Settings.ShowTooltipsDefault
                chkHighlightCurrentNode.Checked = My.Settings.HighlightNodeDefault

                'Update sliders
                trkGreenToYellow.Value = lblGreenToYellow.Text
                trkYellowToRed.Value = lblYellowToRed.Text

                Notification_Display("Information", "The default settings have been restored successfully")
            End If


        Catch ex As Exception
            Notification_Display("Error", "There was an error restoring the default settings", ex)
        End Try

    End Sub

    Private Sub chkHideTrayIcon_CheckedChanged(sender As Object, e As EventArgs) Handles chkHideTrayIcon.CheckedChanged

        Notify_Icon_Display()

    End Sub

    Private Sub Notify_Icon_Display()

        Try
            'Set visibility of tray icon
            If chkHideTrayIcon.Checked = True Then
                NotifyIcon1.Visible = False
                Notification_Display("Information", "The tray icon has been hidden")
            Else
                NotifyIcon1.Visible = True
                Notification_Display("Information", "The tray icon has been made visible")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the tray icon visibility", ex)
        End Try

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Try
            'Handle the minimize event
            If WindowState = FormWindowState.Minimized Then
                If chkMinimiseToTray.Checked = True Then
                    NotifyIcon1.Visible = True
                    ShowInTaskbar = False
                    Notification_Display("Information", "The application has been minimised to the tray")
                Else
                    Notification_Display("Information", "The application has been minimised to the taskbar")
                End If
            End If

            'Handle the restore event to reset selected display of tray icon
            If WindowState = FormWindowState.Normal Then
                Me.Visible = False
                Open_Startup_Tab()
                Notify_Icon_Display()
                ShowInTaskbar = True
                Me.Visible = True
                Me.CenterToScreen()
                Notification_Display("Information", "The application window has been displayed")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error minimising or restoring the application", ex)
        End Try

    End Sub

    Private Sub NotifyIcon1_Click(sender As Object, e As EventArgs) Handles NotifyIcon1.Click

        Try
            'Restore window if minimised or Minimise Window if normal
            If WindowState = FormWindowState.Minimized Then
                WindowState = FormWindowState.Normal
            ElseIf WindowState = FormWindowState.Normal Then
                WindowState = FormWindowState.Minimized
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error resizing the application", ex)
        End Try

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try
            If FormLoadComplete = True Then

                'Only save all the persistent settings if the form load completed successfully

                Save_Settings()

                'Save json global variable to text file in case internet not available on restart
                Write_JSON_String()

                'Save IP location array to text file using background thread to avoid holding up form close
                FileWriteThread = New System.Threading.Thread(AddressOf Write_IP_Locations)
                FileWriteThread.Start()

                Notification_Display("Information", "The persistent settings have been saved successfully on form close")
            Else
                Notification_Display("Information", "The persistent settings were not saved on form close as application load had not completed")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error saving the persistent settings on form close", ex)
        End Try

    End Sub

    Private Sub btnForceClose_Click(sender As Object, e As EventArgs) Handles btnForceClose.Click

        'Close application even if minimise on close is selected
        ForceCloseFlag = True
        Me.Close()

    End Sub

    Private Sub Set_Force_Close_Button_Visibility()

        Try
            If chkMinimiseOnClose.Checked = True Then
                btnForceClose.Enabled = True
            Else
                btnForceClose.Enabled = False
            End If

            Notification_Display("Information", "The force close button visibility has been successfully set")
        Catch ex As Exception
            Notification_Display("Error", "There was an error setting the force close button visibility", ex)
        End Try

    End Sub

    Private Sub chkMinimiseOnClose_CheckedChanged(sender As Object, e As EventArgs) Handles chkMinimiseOnClose.CheckedChanged

        Set_Force_Close_Button_Visibility()

    End Sub

    Private Sub Set_Tray_Icon_Appearance()

        'Change notify icon dependent on selected node status in the application

        Try
            If StatusColour = "Grey" Then
                'Use grey icon as Node not valid
                NotifyIcon1.Icon = My.Resources.Grey1
                NotifyIcon1.Text = "DogeNodes - Node Invalid"
            ElseIf StatusColour = "Green" And UpToDateColour = "Green" And CurrentColour = "Green" Then
                'Use green icon as all node parameters are OK
                NotifyIcon1.Icon = My.Resources.Green1
                NotifyIcon1.Text = "DogeNodes - Node Healthy"
            Else
                'Use red icon as at least one node parameter is showing an issue
                NotifyIcon1.Icon = My.Resources.Red1
                NotifyIcon1.Text = "DogeNodes - Node Issues"
            End If

            Notification_Display("Information", "The tray icon appearance has been set to " + NotifyIcon1.Text)
        Catch ex As Exception
            Notification_Display("Error", "There was an error setting the tray icon appearance", ex)
        End Try

    End Sub

    Private Sub Open_Startup_Tab()

        Try
            Select Case comStartup.Text
                Case "Summary"
                    TabControl1.SelectedTab = tabSummary
                Case "Statistics"
                    TabControl1.SelectedTab = tabStatistics
                Case "Node List"
                    TabControl1.SelectedTab = tabNodeList
                Case "Node Map"
                    TabControl1.SelectedTab = tabNodeMap
                Case "Node Status"
                    TabControl1.SelectedTab = tabNodestatus
                    gbxStatus.Focus()
                Case "Settings"
                    TabControl1.SelectedTab = tabSettings
                Case Else
                    TabControl1.SelectedTab = tabSummary
            End Select

            Notification_Display("Information", "The startup tab has been set to " + TabControl1.SelectedTab.ToString)
        Catch ex As Exception
            Notification_Display("Error", "There was an error opening the startup tab", ex)
        End Try

    End Sub

    Private Sub Save_Settings()

        Try
            'Save persistent settings
            My.Settings.IPAddress = txtIPAddress.Text
            My.Settings.NodePort = txtPort.Text
            My.Settings.Statistics = comStatistics.Text
            My.Settings.GreenToYellow = lblGreenToYellow.Text
            My.Settings.YellowToRed = lblYellowToRed.Text
            My.Settings.HideTrayIcon = chkHideTrayIcon.Checked
            My.Settings.MinimiseToTray = chkMinimiseToTray.Checked
            My.Settings.MinimiseOnClose = chkMinimiseOnClose.Checked
            My.Settings.StartupTab = comStartup.Text
            My.Settings.ApplicationNotification = chkApplicationNotification.Checked
            My.Settings.WindowsNotification = chkWindowsNotification.Checked
            My.Settings.AllowLogging = chkAllowLogging.Checked
            My.Settings.AllowEmailNotification = chkAllowEmailNotification.Checked
            My.Settings.ApplicationNotificationLevel = comAppNotifLvl.Text
            My.Settings.WindowsNotificationLevel = comWinNotifLvl.Text
            My.Settings.LoggingLevel = comLogLvl.Text
            My.Settings.EmailNotificationLevel = comEmailNotifLvl.Text
            My.Settings.SMTPHost = txtSMTPHost.Text
            My.Settings.SMTPPort = txtSMTPPort.Text
            My.Settings.SMTPUsername = txtSMTPUsername.Text
            My.Settings.SMTPPassword = txtSMTPPassword.Text
            My.Settings.UseSSL = chkUseSSL.Checked
            My.Settings.EmailAddress = txtEmailAddress.Text
            My.Settings.CurrentAgentVersion = CurrentAgentVersion
            My.Settings.StartMinimised = chkStartMinimised.Checked
            My.Settings.StartWithWindows = chkStartWithWindows.Checked
            My.Settings.DesktopShortcut = chkDesktopShortcut.Checked
            My.Settings.ShowTooltips = chkShowTooltips.Checked
            My.Settings.HighlightNode = chkHighlightCurrentNode.Checked

            My.Settings.Save()

            Notification_Display("Information", "The persistent application level settings have been saved successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error saving the persistent application level settings", ex)
        End Try

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click

        Save_Settings()

    End Sub

    Private Function Display_Windows_Notification(Severity As String, Message As String) As Boolean

        Try
            Dim Notification As New PopupNotifier()

            'Unconditional Settings
            Notification.ContentText = Message
            Notification.ImageSize = New Size(80, 80)
            Notification.TitleColor = Color.Black
            Notification.ContentColor = Color.Black
            Notification.Delay = 8000
            Notification.TitleFont = New Font(Notification.TitleFont.Name, 10, FontStyle.Underline Or FontStyle.Bold)
            Notification.BodyColor = Color.LightGray
            Notification.GradientPower = 100

            'Conditional Settings
            If Severity = "Warning" Then
                'Warning popup
                Notification.TitleText = "DOGENODES WARNING"
                Notification.Image = My.Resources.Yellow
            ElseIf Severity = "Error" Then
                'Error popup
                Notification.TitleText = "DOGENODES ERROR"
                Notification.Image = My.Resources.Red
            Else
                'Anything else
                Notification.TitleText = "DOGENODES"
                Notification.Image = My.Resources.Grey
            End If

            'Display Popup
            Notification.Popup()

        Catch
            Display_MessageBox_Notification("There has been a critical error in the Windows notification display")
        End Try

        Return True

    End Function

    Private Function Log_Notification(Severity As String, Message As String, Optional ex As Exception = Nothing) As Boolean

        Try

            Dim LogEntry As String

            'Check if ex is supplied. If it is, it must be debug log

            If ex Is Nothing Then
                'Normal log entry

                'Pad out severity field for neat formatting of the log entry
                If Severity = "Warning" Then Severity = "Warning    "
                If Severity = "Error" Then Severity = "Error      "

                'Construct Log Entry
                LogEntry = Date.Now.ToString("dd/MM/yyyy HH:mm:ss.fff") + " | " + Severity + " | " + Message + Environment.NewLine

            Else
                'Debug log entry

                'Construct Log Entry
                LogEntry = "----------------------------------------------"
                LogEntry += Environment.NewLine
                LogEntry += Date.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")
                LogEntry += Environment.NewLine
                LogEntry += "----------------------------------------------"
                LogEntry += Environment.NewLine
                LogEntry += "Human Message: " + Message
                LogEntry += Environment.NewLine
                LogEntry += "Exception Message: " + ex.Message
                LogEntry += Environment.NewLine
                LogEntry += "StackTrace: " + ex.StackTrace
                LogEntry += Environment.NewLine
                LogEntry += "Source: " + ex.Source
                LogEntry += Environment.NewLine
                LogEntry += "TargetSite: " + ex.TargetSite.ToString
                LogEntry += Environment.NewLine

            End If

            'Write entry to log
            If System.IO.File.Exists(LogFileName) Then
                System.IO.File.SetAttributes(LogFileName, IO.FileAttributes.Normal)
            End If

            System.IO.File.AppendAllText(LogFileName, LogEntry)
            System.IO.File.SetAttributes(LogFileName, IO.FileAttributes.ReadOnly)

        Catch
            Display_MessageBox_Notification("There has been a critical error in the Log notification process")
        End Try

        Return True

    End Function

    Private Function Send_Email_Notification(Severity As String, Message As String) As Boolean

        Try
            'create the mail message
            Dim mail As New MailMessage()

            'set the addresses
            mail.From = New MailAddress("notifications@dogenodes")
            mail.[To].Add(txtEmailAddress.Text)

            'set the content
            Dim Subject As String = "DogeNodes " + Severity
            mail.Subject = Subject
            mail.IsBodyHtml = False
            mail.Body = Message

            'set the server
            Dim smtp As New SmtpClient()
            smtp.Host = txtSMTPHost.Text
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential(txtSMTPUsername.Text, txtSMTPPassword.Text)
            smtp.Port = txtSMTPPort.Text
            smtp.EnableSsl = chkUseSSL.Checked

            'send the message
            smtp.Send(mail)

        Catch
            Display_MessageBox_Notification("There has been an error sending an email. Please check email settings")
        End Try

        Return True

    End Function

    Private Sub timClearError_Tick(sender As Object, e As EventArgs) Handles timClearError.Tick

        'Clear application error message and turn timer off
        Clear_Application_Notification()
        timClearError.Enabled = False

    End Sub

    Private Sub chkAllowLogging_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllowLogging.CheckedChanged

        Disable_Logging_Settings()

    End Sub

    Private Sub Disable_Logging_Settings()

        Try
            'Enable or disable the remaining logging controls
            If chkAllowLogging.Checked = True Then
                btnDisplayLog.Enabled = True
                btnClearLog.Enabled = True
                comLogLvl.Enabled = True
                btnCopyLog.Enabled = True
                Notification_Display("Information", "The logging controls have been enabled")
            Else
                btnDisplayLog.Enabled = False
                btnClearLog.Enabled = False
                comLogLvl.Enabled = False
                btnCopyLog.Enabled = False
                Notification_Display("Information", "The logging controls have been disabled")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the logging controls availability", ex)
        End Try

    End Sub

    Private Sub chkApplicationNotification_CheckedChanged(sender As Object, e As EventArgs) Handles chkApplicationNotification.CheckedChanged

        Disable_Application_Notification_Settings()

    End Sub

    Private Sub Disable_Application_Notification_Settings()

        Try
            'Enable or disable the remaining application notification controls
            If chkApplicationNotification.Checked = True Then
                comAppNotifLvl.Enabled = True
                Notification_Display("Information", "The application notification controls have been enabled")
            Else
                comAppNotifLvl.Enabled = False
                Notification_Display("Information", "The application notification controls have been disabled")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the application notification controls availability", ex)
        End Try

    End Sub

    Private Sub chkWindowsNotification_CheckedChanged(sender As Object, e As EventArgs) Handles chkWindowsNotification.CheckedChanged

        Disable_Windows_Notification_Settings()

    End Sub

    Private Sub Disable_Windows_Notification_Settings()

        Try
            'Enable or disable the remaining windows notification controls
            If chkWindowsNotification.Checked = True Then
                comWinNotifLvl.Enabled = True
                Notification_Display("Information", "The windows notification controls have been enabled")
            Else
                comWinNotifLvl.Enabled = False
                Notification_Display("Information", "The windows notification controls have been disabled")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the windows notification controls availability", ex)
        End Try

    End Sub

    Private Sub chkAllowEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllowEmailNotification.CheckedChanged

        Disable_Email_Notification_Settings()

    End Sub

    Private Sub Disable_Email_Notification_Settings()

        Try
            'Enable or disable the remaining email notification controls
            If chkAllowEmailNotification.Checked = True Then
                comEmailNotifLvl.Enabled = True
                txtSMTPHost.Enabled = True
                txtSMTPPort.Enabled = True
                txtSMTPUsername.Enabled = True
                txtSMTPPassword.Enabled = True
                chkUseSSL.Enabled = True
                txtEmailAddress.Enabled = True
                pbxShow.Enabled = True
                btnTestEmail.Enabled = True
                Notification_Display("Information", "The email notification controls have been enabled")
            Else
                comEmailNotifLvl.Enabled = False
                txtSMTPHost.Enabled = False
                txtSMTPPort.Enabled = False
                txtSMTPUsername.Enabled = False
                txtSMTPPassword.Enabled = False
                chkUseSSL.Enabled = False
                txtEmailAddress.Enabled = False
                pbxShow.Enabled = False
                btnTestEmail.Enabled = False
                Notification_Display("Information", "The email notification controls have been disabled")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the email notification controls availability", ex)
        End Try

    End Sub

    Private Sub btnDisplayLog_Click(sender As Object, e As EventArgs) Handles btnDisplayLog.Click

        Try
            'Open notepad, and if log file exists, open it
            If System.IO.File.Exists(LogFileName) = True Then
                System.Diagnostics.Process.Start("notepad.exe", LogFileName)
            Else
                System.Diagnostics.Process.Start("notepad.exe")
            End If

            Notification_Display("Information", "The log file has been opened successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error opening the log file", ex)
        End Try

    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click

        Try
            'Get confirmation
            If Request_Confirmation("This will permanently delete the logs") = True Then

                'If log file exists, then delete it
                If System.IO.File.Exists(LogFileName) = True Then
                    System.IO.File.SetAttributes(LogFileName, IO.FileAttributes.Normal)
                    System.IO.File.Delete(LogFileName)
                End If
            End If

            Notification_Display("Information", "The log file has been cleared")
        Catch ex As Exception
            Notification_Display("Error", "There was an error clearing the log file", ex)
        End Try

    End Sub

    Private Sub Populate_IP_Address_Details()

        Dim IP As String
        Dim parseIP As JObject 'JSON Object to hold API data

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        'Load the data from the API into a JSON object
        Try
            Notification_Display("Information", "The API download from ip-api has started")
            IP = New WebDownload(2000).DownloadString("http://ip-api.com/json/" + txtIPAddress.Text)
            Notification_Display("Information", "The API download from ip-api has completed successfully")
        Catch ex As Exception
            Notification_Display("Error", "IP API is unreachable. Please check network connection", ex)
            IP = ""
        End Try

        Try
            If IP <> "" Then
                parseIP = JObject.Parse(IP)

                'Populate the fields on the node status tab
                lblCountryNameValue.Text = parseIP.SelectToken("country").ToString
                lblRegionValue.Text = parseIP.SelectToken("region").ToString
                lblCityValue.Text = parseIP.SelectToken("city").ToString
                lblZipCodeValue.Text = parseIP.SelectToken("zip").ToString
                lblISPValue.Text = parseIP.SelectToken("isp").ToString
            Else
                'Clear the fields on the node status tab
                lblCountryNameValue.Text = ""
                lblRegionValue.Text = ""
                lblCityValue.Text = ""
                lblZipCodeValue.Text = ""
                lblISPValue.Text = ""
            End If

            Notification_Display("Information", "The IP address details have been displayed successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error displaying the IP address details", ex)
        End Try

    End Sub

    Private Sub Setup_Logging()

        Try
            Dim LogFileDirectory As String = "C:\Users\" + Environment.UserName + "\AppData\Local\DogeNodes"

            'Create logging path
            If System.IO.Directory.Exists(LogFileDirectory) = False Then
                System.IO.Directory.CreateDirectory(LogFileDirectory)
            End If

            LogFileName = LogFileDirectory + "\dogenodes.log"
        Catch
            Display_MessageBox_Notification("There has been a critical error in the logging configuration process")
        End Try

    End Sub

    Private Sub Populate_Node_Map()

        Try
            Dim IPAddress As String
            Dim Location As String() = Nothing
            Dim Longitude As String
            Dim Latitude As String
            Dim X As Integer
            Dim Y As Integer

            'set up graphics objects
            Dim Map As Image = My.Resources.Map
            Dim MapGraphics As Graphics = Graphics.FromImage(Map)

            'Write a point onto the map for each node in the nodelist
            Dim RowCount As Integer = grdNodeList.RowCount
            If RowCount > 0 Then
                For Row As Integer = 0 To RowCount - 1
                    IPAddress = grdNodeList.Rows(Row).Cells(0).Value
                    Location = Lookup_IP_Location(IPAddress)
                    Longitude = Location(0)
                    Latitude = Location(1)
                    If Longitude <> "" And Latitude <> "" Then
                        X = Map_X_Coords_from_Longitude(Longitude)
                        Y = Map_Y_Coords_from_Latitude(Latitude)
                        MapGraphics.DrawImage(My.Resources.MapNode, X, Y, 32, 32)
                    End If
                Next
            End If

            'Highlight the currently selected node on the map. Icon shows whether its on or offline
            If chkHighlightCurrentNode.Checked = True Then
                IPAddress = txtIPAddress.Text
                If IPAddress <> "" And Validate_IPAddress(IPAddress) <> "Invalid" Then
                    Location = Lookup_IP_Location(IPAddress)
                    Longitude = Location(0)
                    Latitude = Location(1)
                    If Longitude <> "" And Latitude <> "" Then
                        X = Map_X_Coords_from_Longitude(Longitude)
                        Y = Map_Y_Coords_from_Latitude(Latitude)
                        MapGraphics.DrawImage(pbxStatus.Image, X, Y, 32, 32)
                    End If
                End If
            End If

            'Apply the updated map to the picturebox
            pbxMap.Image = Map

            Notification_Display("Information", "The node map has been created successfully")
        Catch ex As Exception
            Notification_Display("Error", "There was an error creating the node map", ex)
        End Try

    End Sub

    Private Function Map_X_Coords_from_Longitude(Longitude As String) As Integer

        Dim X As Integer

        Try
            Dim ImageWidth As Decimal = 1600
            Dim Scale As Decimal = ImageWidth / 360
            Dim Offset As Decimal = 165

            X = Convert.ToInt32((Convert.ToDecimal(Longitude) + Offset) * Scale)

            If X < 0 Then X = 0
            If X > ImageWidth - 1 Then X = ImageWidth - 1

            'No success notification as there are approx 1000 nodes
        Catch ex As Exception
            Notification_Display("Error", "There was an error calculating the X coordinate", ex)
        End Try

        Return X

    End Function

    Private Function Map_Y_Coords_from_Latitude(Latitude As String) As Integer

        Dim Y As Integer

        Try
            Dim ImageHeight As Decimal = 800
            Dim Scale As Decimal = ImageHeight / 180
            Dim Offset As Decimal = 94

            Y = Convert.ToInt32((Convert.ToDecimal(Latitude) + Offset) * Scale)

            Y = ImageHeight - Y

            If Y < 0 Then Y = 0
            If Y > ImageHeight - 1 Then Y = ImageHeight - 1

            'No success notification as there are approx 1000 nodes
        Catch ex As Exception
            Notification_Display("Error", "There was an error calculating the Y coordinate", ex)
        End Try

        Return Y

    End Function

    Private Sub btnCopyLog_Click(sender As Object, e As EventArgs) Handles btnCopyLog.Click

        Try
            'Get path to users desktop
            Dim DesktopPath As String = "C:\Users\" + Environment.UserName + "\Desktop\DogeNodes.log"

            'Copy log to the users desktop
            If System.IO.File.Exists(LogFileName) Then
                If System.IO.File.Exists(DesktopPath) = True Then
                    System.IO.File.Delete(DesktopPath)
                End If
                System.IO.File.Copy(LogFileName, DesktopPath)
                System.IO.File.SetAttributes(DesktopPath, IO.FileAttributes.Normal)
                Notification_Display("Information", "Log file has been copied to desktop")
            Else
                Notification_Display("Warning", "Log file is currently empty so will not be copied")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error copying the log file to the desktop", ex)
        End Try

    End Sub

    Private Sub Set_Up_Map_Cache()

        Try
            'Set map cache path and filename
            MapCacheFileName = "C:\Users\" + Environment.UserName + "\AppData\Local\DogeNodes\IP_Location.txt"

            'If cache file doesnt already exist, create it and write headers
            If System.IO.File.Exists(MapCacheFileName) = False Then
                System.IO.File.AppendAllText(MapCacheFileName, "IP Address,Longitude,Latitude" + Environment.NewLine)
            End If

            Notification_Display("Information", "The node map cache has been configured")
        Catch ex As Exception
            Notification_Display("Error", "There was an error configuring the node map cache", ex)
        End Try

    End Sub

    Private Sub Read_IP_Locations()

        Dim IPLocationLines As String()
        Dim IPLocationFields As String()

        Try
            'Read IP locations from text file to array
            IPLocationLines = System.IO.File.ReadAllLines(MapCacheFileName)
            ReDim IPLocations(2, IPLocationLines.Length - 1)
            For i As Integer = 0 To IPLocationLines.Length - 1
                IPLocationFields = IPLocationLines(i).Split(",")
                IPLocations(0, i) = IPLocationFields(0)
                IPLocations(1, i) = IPLocationFields(1)
                IPLocations(2, i) = IPLocationFields(2)
            Next

            Notification_Display("Information", "Map cache successfully read from file")
        Catch ex As Exception
            Notification_Display("Error", "There was an error reading the map cache from file", ex)
        End Try

    End Sub

    Private Sub Write_IP_Locations()

        Dim Row As String

        Try
            'Delete existing Text file
            If System.IO.File.Exists(MapCacheFileName) Then
                System.IO.File.Delete(MapCacheFileName)
            End If

            'Write new file from array
            For i As Integer = 0 To IPLocations.GetLength(1) - 1
                Row = IPLocations(0, i) + "," + IPLocations(1, i) + "," + IPLocations(2, i) + Environment.NewLine
                System.IO.File.AppendAllText(MapCacheFileName, Row)
            Next

        Catch
            'skip normal notification methods as this is run in a separate thread
            MessageBox.Show("There was a problem writing the IP locations to a text file", "DogeNodes - Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Lookup_IP_Location(IPAddress As String) As String()

        Dim Longitude As String = "Not Found"
        Dim Latitude As String = "Not Found"
        Dim Location(1) As String

        Try
            'Check if IPAddress is in Array
            For i As Integer = 0 To IPLocations.GetLength(1) - 1
                If IPLocations(0, i) = IPAddress Then
                    Longitude = IPLocations(1, i)
                    Latitude = IPLocations(2, i)
                    Exit For
                End If
            Next

            'If address not in array, then add it to the array with blank longitude and latitude values
            If Longitude = "Not Found" Or Latitude = "Not Found" Then
                Longitude = ""
                Latitude = ""
                Dim Length As Integer = IPLocations.GetLength(1)
                ReDim Preserve IPLocations(2, Length)
                IPLocations(0, Length) = IPAddress
                IPLocations(1, Length) = Longitude
                IPLocations(2, Length) = Latitude
            End If

            Location(0) = Longitude
            Location(1) = Latitude

            'No success notification as there would be too many
        Catch ex As Exception
            Notification_Display("Error", "There was an error retrieving the IP location for node " + IPAddress, ex)
        End Try

        Return Location

    End Function

    Private Sub Update_Cache()

        'Update the map cache when triggered by the timer every 3 seconds

        Dim parseIP As JObject 'JSON Object to hold API data
        Dim IPAddress As String = ""
        Dim Longitude As String
        Dim Latitude As String
        Dim CacheIndex As Integer
        Dim Percentage As Integer

        Try

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

            'Display total nodes in cache in the settings page
            lblCacheNodesValue.Text = (IPLocations.GetLength(1) - 1).ToString

            'Get first address in the array that has a blank location
            For i As Integer = 0 To IPLocations.GetLength(1) - 1
                CacheIndex = i
                If IPLocations(1, i) = "" Or IPLocations(2, i) = "" Then
                    IPAddress = IPLocations(0, i)
                    Exit For
                End If
            Next

            'Display percentage of nodes populated in the settings page
            If IPLocations.GetLength(1) = 1 Then
                'Only the header row
                Percentage = 0
            Else
                Percentage = 100 * (CacheIndex - 1) / (IPLocations.GetLength(1) - 1)
                lblPercentageNodesValue.Text = Percentage.ToString
            End If

            'Display progress underneath the map if it is a long way behind (e.g. after cache clear or first installation)
            If Percentage < 98 Then
                lblMapUpdate.Text = "The map is currently updating - " + Percentage.ToString + "% complete - approx " + (Convert.ToInt32((100 - Percentage) / 2)).ToString + " minutes to go"
                'Refresh the map every 30 seconds
                MapRefreshCounter += 1
                If MapRefreshCounter = 10 Then
                    MapRefreshCounter = 0
                    Populate_Node_Map()
                End If
            Else
                lblMapUpdate.Text = ""
            End If

            If IPAddress <> "" Then

                Dim IP As String

                'Load the data from the API for the IPAddress found
                Try
                    'No information logging here as the call may be made 20 times a minute!!
                    IP = New WebDownload(2000).DownloadString("http://ip-api.com/json/" + IPAddress + "?fields=lat,lon")
                Catch ex As Exception
                    Notification_Display("Error", "IP API is unreachable. Please check network connection", ex)
                    'extend interval to 1 minute to avoid unneccessary api calls
                    timUpdateCache.Enabled = False
                    timUpdateCache.Interval = 60000
                    timUpdateCache.Enabled = True
                    Exit Sub
                End Try

                'Restore default interval of 3 secs if no issues contacting API
                timUpdateCache.Enabled = False
                timUpdateCache.Interval = 3000
                timUpdateCache.Enabled = True

                parseIP = JObject.Parse(IP)
                Longitude = parseIP.SelectToken("lon")
                Latitude = parseIP.SelectToken("lat")

                'Save the data back into the cache
                IPLocations(1, CacheIndex) = Longitude
                IPLocations(2, CacheIndex) = Latitude

            Else

                'No need to add location data to an address, so remove first line from array instead to force gradual refresh
                'We want to remove one line per minute so need counter to limit rate
                CacheCounter += 1
                If CacheCounter = 20 Then
                    CacheCounter = 0
                    Remove_First_Row_From_Cache()
                End If

            End If

            'No success notification as there would be one every three seconds
        Catch ex As Exception
            Notification_Display("Error", "There was an error updating the cache", ex)
        End Try

    End Sub

    Private Sub timUpdateCache_Tick(sender As Object, e As EventArgs) Handles timUpdateCache.Tick

        Update_Cache()

    End Sub

    Private Sub Remove_First_Row_From_Cache()

        Try
            Dim Length As Integer = IPLocations.GetLength(1)

            If Length > 2 Then
                'Remove the second row (First is header) from cache by copying all rows up one place, and then rem dim to one line less
                For i As Integer = 1 To Length - 2
                    IPLocations(0, i) = IPLocations(0, i + 1)
                    IPLocations(1, i) = IPLocations(1, i + 1)
                    IPLocations(2, i) = IPLocations(2, i + 1)
                Next
                ReDim Preserve IPLocations(2, Length - 2)
                Notification_Display("Information", "First row removed from cache")
            Else
                Notification_Display("Information", "No rows to remove from cache from cache")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error removing the first row from the cache", ex)
        End Try

    End Sub

    Private Sub pbxShow_Click(sender As Object, e As EventArgs) Handles pbxShow.Click

        Try
            'Show or hide the SMTP password
            If txtSMTPPassword.PasswordChar = "*" Then
                txtSMTPPassword.PasswordChar = ""
                pbxShow.Image = My.Resources.eye_blind_icon
                Notification_Display("Information", "SMTP Password shown")
            Else
                txtSMTPPassword.PasswordChar = "*"
                pbxShow.Image = My.Resources.eye_icon
                Notification_Display("Information", "SMTP password hidden")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error updating the SMTP password visibility", ex)
        End Try

    End Sub

    Private Function Display_MessageBox_Notification(Message As String) As Boolean

        'Display a message box for critical notifications. This cannot be filtered by the user and will display even before form load completes
        'Cannot use a try catch on this as its the most basic error message
        MessageBox.Show(Message, "DogeNodes - Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Return True

    End Function

    Private Function Request_Confirmation(Message As String) As Boolean

        Dim Response As Boolean = False

        Try
            Dim Answer As DialogResult = MessageBox.Show(Message + " - Are you sure?", "DogeNodes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If Answer = DialogResult.Yes Then
                Response = True
                Notification_Display("Information", "Request confirmed as Yes for message (" + Message + " - Are you sure?)")
            Else
                Response = False
                Notification_Display("Information", "Request confirmed as No for message (" + Message + " - Are you sure?)")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error in processing the request confirmation for message (" + Message + " - Are you sure?)", ex)
        End Try

        Return Response

    End Function

    Private Sub Read_JSON_String()

        Try
            'Read json from text file to global variable
            If System.IO.File.Exists(JSONFileName) Then
                json = System.IO.File.ReadAllText(JSONFileName)
                Notification_Display("Information", "JSON string successfully read from file")
            Else
                json = ""
                Notification_Display("Information", "JSON string was not read from file as file does not exist")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error reading the JSON string from file", ex)
        End Try

    End Sub

    Private Sub Write_JSON_String()

        Try
            'Delete existing Text file
            If System.IO.File.Exists(JSONFileName) Then
                System.IO.File.Delete(JSONFileName)
            End If

            'Write new file from json Global variable
            System.IO.File.AppendAllText(JSONFileName, json)

            Notification_Display("Information", "JSON string successfully written to file")
        Catch ex As Exception
            Notification_Display("Error", "There was an error writing the JSON string to file", ex)
        End Try

    End Sub

    Private Sub Set_Up_JSON_Persistence()

        Try
            'Set JSON file path and filename
            JSONFileName = "C:\Users\" + Environment.UserName + "\AppData\Local\DogeNodes\JSON.txt"

            Notification_Display("Information", "JSON string persistence successfully configured")
        Catch ex As Exception
            Notification_Display("Error", "There was an error configuring the JSON string persistence", ex)
        End Try

    End Sub

    Private Sub btnClearMapCache_Click(sender As Object, e As EventArgs) Handles btnClearMapCache.Click

        Try
            'Clear the map cache
            If Request_Confirmation("If you clear the cache, it will take approximately 1 hour to rebuild itself") = True Then

                'Clear the cache keeping just the header row
                ReDim Preserve IPLocations(2, 0)

                'Repopulate map which will remove all points, but also add the IP addresses back into the cache
                Populate_Node_Map()

                Notification_Display("Information", "The map cache has been successfully cleared")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error clearing the map cache", ex)
        End Try

    End Sub

    Private Sub Create_ShortCut(ShortCutPath As String)

        Try
            Dim oShell As Object
            Dim oLink As Object

            'Create a shortcut to the current application in the designated path
            oShell = CreateObject("WScript.Shell")
            oLink = oShell.CreateShortcut(ShortCutPath + "\DogeNodes.lnk")
            oLink.TargetPath = Application.ExecutablePath
            oLink.WindowStyle = 1
            oLink.Save()

            Notification_Display("Information", "Shortcut has been created in (" + ShortCutPath + ")")
        Catch ex As Exception
            Notification_Display("Error", "There was an error creating the shortcut", ex)
        End Try

    End Sub

    Private Sub Delete_Shortcut(ShortCutPath As String)

        Try
            'Delete the shortcut to the current application in the designated path
            If System.IO.File.Exists(ShortCutPath + "\DogeNodes.lnk") Then
                System.IO.File.Delete(ShortCutPath + "\DogeNodes.lnk")
                Notification_Display("Information", "Shortcut has been deleted from (" + ShortCutPath + ")")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error deleting the shortcut", ex)
        End Try

    End Sub

    Private Sub Configure_Desktop_Shortcut()

        Try
            'Get path to users desktop
            Dim DesktopPath As String = "C:\Users\" + Environment.UserName + "\Desktop"

            'Add or remove the desktop shortcut
            If chkDesktopShortcut.Checked = True Then
                Create_ShortCut(DesktopPath)
            Else
                Delete_Shortcut(DesktopPath)
            End If

            Notification_Display("Information", "Desktop shortcut has been successfully configured")
        Catch ex As Exception
            Notification_Display("Error", "There was an error configuring the desktop shortcut", ex)
        End Try

    End Sub

    Private Sub Configure_Startup_Shortcut()

        Try
            'Get path to windows startup folder
            Dim StartupPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)

            'Add or remove the desktop shortcut
            If chkStartWithWindows.Checked = True Then
                Create_ShortCut(StartupPath)
            Else
                Delete_Shortcut(StartupPath)
            End If

            Notification_Display("Information", "Startup shortcut has been successfully configured")
        Catch ex As Exception
            Notification_Display("Error", "There was an error configuring the startup shortcut", ex)
        End Try

    End Sub

    Private Sub chkDesktopShortcut_CheckedChanged(sender As Object, e As EventArgs) Handles chkDesktopShortcut.CheckedChanged

        Configure_Desktop_Shortcut()

    End Sub

    Private Sub chkStartWithWindows_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartWithWindows.CheckedChanged

        Configure_Startup_Shortcut()

    End Sub

    Private Sub comLogLvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comLogLvl.SelectedIndexChanged

        Try
            'Request confirmation if level of "Everything" is selected for logging
            If comLogLvl.Text = "Everything" And FormLoadComplete = True Then
                If Request_Confirmation("This will cause rapid log growth and may slow down the application") = False Then
                    comLogLvl.Text = "Warning and Error"
                End If
                Notification_Display("Information", "Confirmation recieved to select 'everything' for logging")
            End If

        Catch ex As Exception
            Notification_Display("Error", "There was an error requesting confirmation to select 'everything' for logging", ex)
        End Try

    End Sub

    Private Sub trkGreenToYellow_Scroll(sender As Object, e As EventArgs) Handles trkGreenToYellow.Scroll

        Try
            'Ensure Green to Yellow less than Yellow to Red
            If trkGreenToYellow.Value >= trkYellowToRed.Value Then
                trkGreenToYellow.Value = trkYellowToRed.Value - 1
            End If

            lblGreenToYellow.Text = trkGreenToYellow.Value

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the green to yellow threshold", ex)
        End Try

    End Sub

    Private Sub trkYellowToRed_Scroll(sender As Object, e As EventArgs) Handles trkYellowToRed.Scroll

        Try
            'Ensure Yellow to Red greater than Green to Yellow
            If trkYellowToRed.Value <= trkGreenToYellow.Value Then
                trkYellowToRed.Value = trkGreenToYellow.Value + 1
            End If

            lblYellowToRed.Text = trkYellowToRed.Value

        Catch ex As Exception
            Notification_Display("Error", "There was an error changing the yellow to red threshold", ex)
        End Try

    End Sub

    Private Sub Configure_Tooltips()

        Try
            'Set up the tooltips
            If chkShowTooltips.Checked = True Then
                ToolTip1.Active = True
                StatusStrip1.ShowItemToolTips = True
            Else
                ToolTip1.Active = False
                StatusStrip1.ShowItemToolTips = False
            End If

            Notification_Display("Information", "Tooltips have been successfully configured")
        Catch ex As Exception
            Notification_Display("Error", "There was an error configuring the tooltips", ex)
        End Try

    End Sub

    Private Sub chkShowTooltips_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowTooltips.CheckedChanged

        Configure_Tooltips()

    End Sub

    Private Sub btnTestEmail_Click(sender As Object, e As EventArgs) Handles btnTestEmail.Click

        'Send a test email
        Send_Email_Notification("Test Email", "You have correctly configured your email settings")

    End Sub

    Private Sub chkHighlightCurrentNode_CheckedChanged(sender As Object, e As EventArgs) Handles chkHighlightCurrentNode.CheckedChanged

        're-populate the node map to hide or show the currently selected node. Only do this if user action
        If FormLoadComplete = True Then
            Populate_Node_Map()
        End If

    End Sub

    Private Sub DogeNodes_Version()

        'Check for updates to dogenodes

        Dim jsonVersion As String
        Dim client As New WebDownload(2000)

        Try
            'Set default values in case github update cannot be obtained
            lblInstalledVersionValue.Text = My.Settings.DogeNodesVersion
            lblLatestVersionValue.Text = My.Settings.DogeNodesVersion
            lblUpdateStatus.Text = "Your current version of DogeNodes is up to date"
            btnUpdateNow.Enabled = False

            'Retrieve latest version from github

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            client.Headers.Add("user-agent", "request")

            Try
                Notification_Display("Information", "The API download of latest DogeNodes version from github has started")
                jsonVersion = client.DownloadString("https://api.github.com/repos/starglancer/dogenodes/releases/latest")
                Notification_Display("Information", "The API download of latest DogeNodes version from github has completed successfully")
            Catch ex As Exception
                Notification_Display("Error", "Github API is unreachable. Please check network connection", ex)
                'Skip the rest of the subroutine if github API unreachable
                Exit Sub
            End Try

            Dim parseVersion As JObject = JObject.Parse(jsonVersion)
            Dim Version As String = parseVersion.SelectToken("tag_name").ToString

            lblLatestVersionValue.Text = Version

            If lblLatestVersionValue.Text <> lblInstalledVersionValue.Text Then
                lblUpdateStatus.Text = "There is an updated version of DogeNodes available"
                btnUpdateNow.Enabled = True
            End If

            Notification_Display("Information", "The latest DogeNodes version has been successfully identified as " + Version)
        Catch ex As Exception
            Notification_Display("Error", "There was an error identifying the latest DogeNodes version. It will be assumed to be " + My.Settings.DogeNodesVersion, ex)
        End Try

    End Sub

    Private Sub btnCheckForUpdate_Click(sender As Object, e As EventArgs) Handles btnCheckForUpdate.Click

        DogeNodes_Version()

    End Sub

    Private Sub btnUpdateNow_Click(sender As Object, e As EventArgs) Handles btnUpdateNow.Click

        'Go to download link for the latest version
        Process.Start(My.Settings.DownLoadURL)

    End Sub

    Private Sub btnDefaultPort_Click(sender As Object, e As EventArgs) Handles btnDefaultPort.Click

        'Set Port to default Dogecoin Core port
        txtPort.Text = My.Settings.DefaultPort

    End Sub

    Private Sub btnMyIPAddress_Click(sender As Object, e As EventArgs) Handles btnMyIPAddress.Click

        'Lookup my current IP address and display it in the box

        Dim IP As String
        Dim parseIP As JObject 'JSON Object to hold API data

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        'Load the data from the API into a JSON object
        Try
            Notification_Display("Information", "The API download from ip-api for my IP address has started")
            IP = New WebDownload(2000).DownloadString("http://ip-api.com/json/")
            Notification_Display("Information", "The API download from ip-api for my IP address has completed successfully")
        Catch ex As Exception
            Notification_Display("Error", "IP API is unreachable. Please check network connection", ex)
            IP = ""
        End Try

        Try
            If IP <> "" Then
                parseIP = JObject.Parse(IP)
                txtIPAddress.Text = parseIP.SelectToken("query").ToString
                Notification_Display("Information", "My current IP address has been displayed successfully as " + txtIPAddress.Text)
            End If
        Catch ex As Exception
            Notification_Display("Error", "There was an error displaying my current IP address", ex)
        End Try

    End Sub

End Class
