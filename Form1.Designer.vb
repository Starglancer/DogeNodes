﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabSummary = New System.Windows.Forms.TabPage()
        Me.btnRunDogecoinNode = New System.Windows.Forms.Button()
        Me.lblNodes = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalNodesValue = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.pbxDogecoin = New System.Windows.Forms.PictureBox()
        Me.tabStatistics = New System.Windows.Forms.TabPage()
        Me.lblRowCount = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.grdStatistics = New System.Windows.Forms.DataGridView()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarChart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comStatistics = New System.Windows.Forms.ComboBox()
        Me.lblStatisticsSelect = New System.Windows.Forms.Label()
        Me.tabNodeList = New System.Windows.Forms.TabPage()
        Me.lblNodeRows = New System.Windows.Forms.Label()
        Me.lblNodeRowsCount = New System.Windows.Forms.Label()
        Me.gbxFilters = New System.Windows.Forms.GroupBox()
        Me.lblAgentPort = New System.Windows.Forms.Label()
        Me.comPort = New System.Windows.Forms.ComboBox()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.comNetwork = New System.Windows.Forms.ComboBox()
        Me.btnClearFilters = New System.Windows.Forms.Button()
        Me.lblVersionFilter = New System.Windows.Forms.Label()
        Me.lblHeightFilter = New System.Windows.Forms.Label()
        Me.lblCountryFilter = New System.Windows.Forms.Label()
        Me.ComVersion = New System.Windows.Forms.ComboBox()
        Me.comHeight = New System.Windows.Forms.ComboBox()
        Me.comCountry = New System.Windows.Forms.ComboBox()
        Me.grdNodeList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabNodeMap = New System.Windows.Forms.TabPage()
        Me.lblMapUpdate = New System.Windows.Forms.Label()
        Me.pbxMap = New System.Windows.Forms.PictureBox()
        Me.tabNodestatus = New System.Windows.Forms.TabPage()
        Me.btnMyIPAddress = New System.Windows.Forms.Button()
        Me.btnDefaultPort = New System.Windows.Forms.Button()
        Me.gbxDetails = New System.Windows.Forms.GroupBox()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblISP = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblCountryName = New System.Windows.Forms.Label()
        Me.lblISPValue = New System.Windows.Forms.Label()
        Me.lblZipCodeValue = New System.Windows.Forms.Label()
        Me.lblRegionValue = New System.Windows.Forms.Label()
        Me.lblCityValue = New System.Windows.Forms.Label()
        Me.lblCountryNameValue = New System.Windows.Forms.Label()
        Me.lblProtocolValue = New System.Windows.Forms.Label()
        Me.lblHeightValue = New System.Windows.Forms.Label()
        Me.lblCountryValue = New System.Windows.Forms.Label()
        Me.lblVersionValue = New System.Windows.Forms.Label()
        Me.lblProtocol = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.gbxStatus = New System.Windows.Forms.GroupBox()
        Me.pbxCurrent = New System.Windows.Forms.PictureBox()
        Me.pbxUpToDate = New System.Windows.Forms.PictureBox()
        Me.pbxStatus = New System.Windows.Forms.PictureBox()
        Me.lblVersionStatus = New System.Windows.Forms.Label()
        Me.lblHeightStatus = New System.Windows.Forms.Label()
        Me.lblOnlineStatus = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIPAddress = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.tabSettings = New System.Windows.Forms.TabPage()
        Me.gbxUpdate = New System.Windows.Forms.GroupBox()
        Me.btnUpdateNow = New System.Windows.Forms.Button()
        Me.btnCheckForUpdate = New System.Windows.Forms.Button()
        Me.lblUpdateStatus = New System.Windows.Forms.Label()
        Me.lblLatestVersionValue = New System.Windows.Forms.Label()
        Me.lblInstalledVersionValue = New System.Windows.Forms.Label()
        Me.lblLatestVersion = New System.Windows.Forms.Label()
        Me.lblInstalledVersion = New System.Windows.Forms.Label()
        Me.gbxMapCache = New System.Windows.Forms.GroupBox()
        Me.chkHighlightCurrentNode = New System.Windows.Forms.CheckBox()
        Me.btnClearMapCache = New System.Windows.Forms.Button()
        Me.lblPercentageNodes = New System.Windows.Forms.Label()
        Me.lblCacheNodes = New System.Windows.Forms.Label()
        Me.lblPercentageNodesValue = New System.Windows.Forms.Label()
        Me.lblCacheNodesValue = New System.Windows.Forms.Label()
        Me.gbxLogging = New System.Windows.Forms.GroupBox()
        Me.btnCopyLog = New System.Windows.Forms.Button()
        Me.btnClearLog = New System.Windows.Forms.Button()
        Me.btnDisplayLog = New System.Windows.Forms.Button()
        Me.chkAllowLogging = New System.Windows.Forms.CheckBox()
        Me.comLogLvl = New System.Windows.Forms.ComboBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.gbxNotification = New System.Windows.Forms.GroupBox()
        Me.btnTestEmail = New System.Windows.Forms.Button()
        Me.pbxShow = New System.Windows.Forms.PictureBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblSMTPPassword = New System.Windows.Forms.Label()
        Me.lblSMTPUserName = New System.Windows.Forms.Label()
        Me.lblSMTPPort = New System.Windows.Forms.Label()
        Me.lblSMTPHost = New System.Windows.Forms.Label()
        Me.chkUseSSL = New System.Windows.Forms.CheckBox()
        Me.txtSMTPPassword = New System.Windows.Forms.TextBox()
        Me.txtSMTPUsername = New System.Windows.Forms.TextBox()
        Me.txtSMTPPort = New System.Windows.Forms.TextBox()
        Me.txtSMTPHost = New System.Windows.Forms.TextBox()
        Me.comEmailNotifLvl = New System.Windows.Forms.ComboBox()
        Me.comWinNotifLvl = New System.Windows.Forms.ComboBox()
        Me.comAppNotifLvl = New System.Windows.Forms.ComboBox()
        Me.chkAllowEmailNotification = New System.Windows.Forms.CheckBox()
        Me.chkApplicationNotification = New System.Windows.Forms.CheckBox()
        Me.chkWindowsNotification = New System.Windows.Forms.CheckBox()
        Me.gbxWindow = New System.Windows.Forms.GroupBox()
        Me.chkShowTooltips = New System.Windows.Forms.CheckBox()
        Me.chkDesktopShortcut = New System.Windows.Forms.CheckBox()
        Me.chkStartWithWindows = New System.Windows.Forms.CheckBox()
        Me.chkStartMinimised = New System.Windows.Forms.CheckBox()
        Me.comStartup = New System.Windows.Forms.ComboBox()
        Me.lblStartupTab = New System.Windows.Forms.Label()
        Me.btnForceClose = New System.Windows.Forms.Button()
        Me.chkMinimiseOnClose = New System.Windows.Forms.CheckBox()
        Me.chkMinimiseToTray = New System.Windows.Forms.CheckBox()
        Me.chkHideTrayIcon = New System.Windows.Forms.CheckBox()
        Me.btnRestoreDefaults = New System.Windows.Forms.Button()
        Me.gbxThresholdSettings = New System.Windows.Forms.GroupBox()
        Me.lblYellowToRed = New System.Windows.Forms.Label()
        Me.lblGreenToYellow = New System.Windows.Forms.Label()
        Me.trkYellowToRed = New System.Windows.Forms.TrackBar()
        Me.trkGreenToYellow = New System.Windows.Forms.TrackBar()
        Me.lblYellowRed = New System.Windows.Forms.Label()
        Me.lblGreenYellow = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslAPIProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.sslLastUpdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslError = New System.Windows.Forms.ToolStripStatusLabel()
        Me.timReloadData = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timClearError = New System.Windows.Forms.Timer(Me.components)
        Me.timUpdateCache = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timTextbox = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabSummary.SuspendLayout()
        CType(Me.pbxDogecoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabStatistics.SuspendLayout()
        CType(Me.grdStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNodeList.SuspendLayout()
        Me.gbxFilters.SuspendLayout()
        CType(Me.grdNodeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNodeMap.SuspendLayout()
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabNodestatus.SuspendLayout()
        Me.gbxDetails.SuspendLayout()
        Me.gbxStatus.SuspendLayout()
        CType(Me.pbxCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxUpToDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSettings.SuspendLayout()
        Me.gbxUpdate.SuspendLayout()
        Me.gbxMapCache.SuspendLayout()
        Me.gbxLogging.SuspendLayout()
        Me.gbxNotification.SuspendLayout()
        CType(Me.pbxShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxWindow.SuspendLayout()
        Me.gbxThresholdSettings.SuspendLayout()
        CType(Me.trkYellowToRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkGreenToYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabSummary)
        Me.TabControl1.Controls.Add(Me.tabStatistics)
        Me.TabControl1.Controls.Add(Me.tabNodeList)
        Me.TabControl1.Controls.Add(Me.tabNodeMap)
        Me.TabControl1.Controls.Add(Me.tabNodestatus)
        Me.TabControl1.Controls.Add(Me.tabSettings)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.ShowToolTips = True
        Me.TabControl1.Size = New System.Drawing.Size(803, 430)
        Me.TabControl1.TabIndex = 0
        '
        'tabSummary
        '
        Me.tabSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabSummary.Controls.Add(Me.btnRunDogecoinNode)
        Me.tabSummary.Controls.Add(Me.lblNodes)
        Me.tabSummary.Controls.Add(Me.lblTotal)
        Me.tabSummary.Controls.Add(Me.lblTotalNodesValue)
        Me.tabSummary.Controls.Add(Me.lblCredit)
        Me.tabSummary.Controls.Add(Me.lblMainTitle)
        Me.tabSummary.Controls.Add(Me.pbxDogecoin)
        Me.tabSummary.Location = New System.Drawing.Point(4, 22)
        Me.tabSummary.Name = "tabSummary"
        Me.tabSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSummary.Size = New System.Drawing.Size(795, 404)
        Me.tabSummary.TabIndex = 1
        Me.tabSummary.Text = "Summary"
        '
        'btnRunDogecoinNode
        '
        Me.btnRunDogecoinNode.Location = New System.Drawing.Point(57, 324)
        Me.btnRunDogecoinNode.Name = "btnRunDogecoinNode"
        Me.btnRunDogecoinNode.Size = New System.Drawing.Size(120, 23)
        Me.btnRunDogecoinNode.TabIndex = 6
        Me.btnRunDogecoinNode.Text = "Run Your Own Node"
        Me.ToolTip1.SetToolTip(Me.btnRunDogecoinNode, "Run your own dogecoin core node - go to download site")
        Me.btnRunDogecoinNode.UseVisualStyleBackColor = True
        '
        'lblNodes
        '
        Me.lblNodes.BackColor = System.Drawing.Color.Transparent
        Me.lblNodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNodes.Location = New System.Drawing.Point(623, 271)
        Me.lblNodes.Name = "lblNodes"
        Me.lblNodes.Size = New System.Drawing.Size(99, 30)
        Me.lblNodes.TabIndex = 5
        Me.lblNodes.Text = "Nodes"
        Me.lblNodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(308, 271)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(87, 30)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalNodesValue
        '
        Me.lblTotalNodesValue.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNodesValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNodesValue.Image = Global.BlockchainNodes.My.Resources.Resources.Yellow
        Me.lblTotalNodesValue.Location = New System.Drawing.Point(386, 167)
        Me.lblTotalNodesValue.Name = "lblTotalNodesValue"
        Me.lblTotalNodesValue.Size = New System.Drawing.Size(245, 228)
        Me.lblTotalNodesValue.TabIndex = 3
        Me.lblTotalNodesValue.Text = "0000"
        Me.lblTotalNodesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblTotalNodesValue, "Click to display a list of all nodes")
        '
        'lblCredit
        '
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(411, 117)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(191, 38)
        Me.lblCredit.TabIndex = 2
        Me.lblCredit.Text = "By Starglancer"
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMainTitle
        '
        Me.lblMainTitle.Font = New System.Drawing.Font("Palatino Linotype", 60.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTitle.Location = New System.Drawing.Point(288, 3)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Size = New System.Drawing.Size(451, 114)
        Me.lblMainTitle.TabIndex = 1
        Me.lblMainTitle.Text = "DogeNodes"
        Me.lblMainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxDogecoin
        '
        Me.pbxDogecoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDogecoin.Image = Global.BlockchainNodes.My.Resources.Resources.Dogecoin2
        Me.pbxDogecoin.Location = New System.Drawing.Point(3, 3)
        Me.pbxDogecoin.Name = "pbxDogecoin"
        Me.pbxDogecoin.Size = New System.Drawing.Size(279, 259)
        Me.pbxDogecoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxDogecoin.TabIndex = 0
        Me.pbxDogecoin.TabStop = False
        '
        'tabStatistics
        '
        Me.tabStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabStatistics.Controls.Add(Me.lblRowCount)
        Me.tabStatistics.Controls.Add(Me.lblRows)
        Me.tabStatistics.Controls.Add(Me.grdStatistics)
        Me.tabStatistics.Controls.Add(Me.comStatistics)
        Me.tabStatistics.Controls.Add(Me.lblStatisticsSelect)
        Me.tabStatistics.Location = New System.Drawing.Point(4, 22)
        Me.tabStatistics.Name = "tabStatistics"
        Me.tabStatistics.Size = New System.Drawing.Size(795, 404)
        Me.tabStatistics.TabIndex = 2
        Me.tabStatistics.Text = "Statistics"
        '
        'lblRowCount
        '
        Me.lblRowCount.AutoSize = True
        Me.lblRowCount.Location = New System.Drawing.Point(355, 374)
        Me.lblRowCount.Name = "lblRowCount"
        Me.lblRowCount.Size = New System.Drawing.Size(13, 13)
        Me.lblRowCount.TabIndex = 4
        Me.lblRowCount.Text = "0"
        Me.lblRowCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.Location = New System.Drawing.Point(390, 374)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(34, 13)
        Me.lblRows.TabIndex = 3
        Me.lblRows.Text = "Rows"
        '
        'grdStatistics
        '
        Me.grdStatistics.AllowUserToAddRows = False
        Me.grdStatistics.AllowUserToDeleteRows = False
        Me.grdStatistics.AllowUserToResizeColumns = False
        Me.grdStatistics.AllowUserToResizeRows = False
        Me.grdStatistics.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdStatistics.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStatistics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Value, Me.Count, Me.BarChart})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStatistics.DefaultCellStyle = DataGridViewCellStyle13
        Me.grdStatistics.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdStatistics.GridColor = System.Drawing.Color.White
        Me.grdStatistics.Location = New System.Drawing.Point(72, 64)
        Me.grdStatistics.Name = "grdStatistics"
        Me.grdStatistics.ReadOnly = True
        Me.grdStatistics.RowHeadersVisible = False
        Me.grdStatistics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdStatistics.Size = New System.Drawing.Size(643, 283)
        Me.grdStatistics.TabIndex = 2
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.ReadOnly = True
        Me.Value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Value.Width = 240
        '
        'Count
        '
        Me.Count.HeaderText = "Count"
        Me.Count.Name = "Count"
        Me.Count.ReadOnly = True
        Me.Count.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BarChart
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Khaki
        Me.BarChart.DefaultCellStyle = DataGridViewCellStyle12
        Me.BarChart.HeaderText = "Bar Chart"
        Me.BarChart.Name = "BarChart"
        Me.BarChart.ReadOnly = True
        Me.BarChart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.BarChart.Width = 300
        '
        'comStatistics
        '
        Me.comStatistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comStatistics.FormattingEnabled = True
        Me.comStatistics.Items.AddRange(New Object() {"Country", "Height", "Version", "Protocol", "Port"})
        Me.comStatistics.Location = New System.Drawing.Point(374, 22)
        Me.comStatistics.Name = "comStatistics"
        Me.comStatistics.Size = New System.Drawing.Size(121, 21)
        Me.comStatistics.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.comStatistics, "Select the breakdown of nodes by different properties")
        '
        'lblStatisticsSelect
        '
        Me.lblStatisticsSelect.AutoSize = True
        Me.lblStatisticsSelect.Location = New System.Drawing.Point(236, 25)
        Me.lblStatisticsSelect.Name = "lblStatisticsSelect"
        Me.lblStatisticsSelect.Size = New System.Drawing.Size(132, 13)
        Me.lblStatisticsSelect.TabIndex = 0
        Me.lblStatisticsSelect.Text = "Display Count of Nodes by"
        '
        'tabNodeList
        '
        Me.tabNodeList.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabNodeList.Controls.Add(Me.lblNodeRows)
        Me.tabNodeList.Controls.Add(Me.lblNodeRowsCount)
        Me.tabNodeList.Controls.Add(Me.gbxFilters)
        Me.tabNodeList.Controls.Add(Me.grdNodeList)
        Me.tabNodeList.Location = New System.Drawing.Point(4, 22)
        Me.tabNodeList.Name = "tabNodeList"
        Me.tabNodeList.Size = New System.Drawing.Size(795, 404)
        Me.tabNodeList.TabIndex = 3
        Me.tabNodeList.Text = "Node List"
        '
        'lblNodeRows
        '
        Me.lblNodeRows.AutoSize = True
        Me.lblNodeRows.Location = New System.Drawing.Point(185, 370)
        Me.lblNodeRows.Name = "lblNodeRows"
        Me.lblNodeRows.Size = New System.Drawing.Size(38, 13)
        Me.lblNodeRows.TabIndex = 6
        Me.lblNodeRows.Text = "Nodes"
        '
        'lblNodeRowsCount
        '
        Me.lblNodeRowsCount.AutoSize = True
        Me.lblNodeRowsCount.Location = New System.Drawing.Point(155, 370)
        Me.lblNodeRowsCount.Name = "lblNodeRowsCount"
        Me.lblNodeRowsCount.Size = New System.Drawing.Size(13, 13)
        Me.lblNodeRowsCount.TabIndex = 5
        Me.lblNodeRowsCount.Text = "0"
        Me.lblNodeRowsCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbxFilters
        '
        Me.gbxFilters.Controls.Add(Me.lblAgentPort)
        Me.gbxFilters.Controls.Add(Me.comPort)
        Me.gbxFilters.Controls.Add(Me.lblNetwork)
        Me.gbxFilters.Controls.Add(Me.comNetwork)
        Me.gbxFilters.Controls.Add(Me.btnClearFilters)
        Me.gbxFilters.Controls.Add(Me.lblVersionFilter)
        Me.gbxFilters.Controls.Add(Me.lblHeightFilter)
        Me.gbxFilters.Controls.Add(Me.lblCountryFilter)
        Me.gbxFilters.Controls.Add(Me.ComVersion)
        Me.gbxFilters.Controls.Add(Me.comHeight)
        Me.gbxFilters.Controls.Add(Me.comCountry)
        Me.gbxFilters.Location = New System.Drawing.Point(30, 21)
        Me.gbxFilters.Name = "gbxFilters"
        Me.gbxFilters.Size = New System.Drawing.Size(331, 327)
        Me.gbxFilters.TabIndex = 4
        Me.gbxFilters.TabStop = False
        Me.gbxFilters.Text = "Filters"
        '
        'lblAgentPort
        '
        Me.lblAgentPort.AutoSize = True
        Me.lblAgentPort.Location = New System.Drawing.Point(71, 221)
        Me.lblAgentPort.Name = "lblAgentPort"
        Me.lblAgentPort.Size = New System.Drawing.Size(26, 13)
        Me.lblAgentPort.TabIndex = 10
        Me.lblAgentPort.Text = "Port"
        '
        'comPort
        '
        Me.comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort.FormattingEnabled = True
        Me.comPort.Location = New System.Drawing.Point(110, 218)
        Me.comPort.Name = "comPort"
        Me.comPort.Size = New System.Drawing.Size(77, 21)
        Me.comPort.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.comPort, "Select the port filter to use")
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.Location = New System.Drawing.Point(12, 173)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(89, 13)
        Me.lblNetwork.TabIndex = 8
        Me.lblNetwork.Text = "Network Protocol"
        '
        'comNetwork
        '
        Me.comNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comNetwork.FormattingEnabled = True
        Me.comNetwork.Location = New System.Drawing.Point(110, 170)
        Me.comNetwork.Name = "comNetwork"
        Me.comNetwork.Size = New System.Drawing.Size(77, 21)
        Me.comNetwork.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.comNetwork, "Select the network protocol filter to use")
        '
        'btnClearFilters
        '
        Me.btnClearFilters.Location = New System.Drawing.Point(128, 274)
        Me.btnClearFilters.Name = "btnClearFilters"
        Me.btnClearFilters.Size = New System.Drawing.Size(75, 23)
        Me.btnClearFilters.TabIndex = 6
        Me.btnClearFilters.Text = "Clear Filters"
        Me.ToolTip1.SetToolTip(Me.btnClearFilters, "Clear all the filters")
        Me.btnClearFilters.UseVisualStyleBackColor = True
        '
        'lblVersionFilter
        '
        Me.lblVersionFilter.AutoSize = True
        Me.lblVersionFilter.Location = New System.Drawing.Point(24, 127)
        Me.lblVersionFilter.Name = "lblVersionFilter"
        Me.lblVersionFilter.Size = New System.Drawing.Size(73, 13)
        Me.lblVersionFilter.TabIndex = 5
        Me.lblVersionFilter.Text = "Agent Version"
        '
        'lblHeightFilter
        '
        Me.lblHeightFilter.AutoSize = True
        Me.lblHeightFilter.Location = New System.Drawing.Point(59, 80)
        Me.lblHeightFilter.Name = "lblHeightFilter"
        Me.lblHeightFilter.Size = New System.Drawing.Size(38, 13)
        Me.lblHeightFilter.TabIndex = 4
        Me.lblHeightFilter.Text = "Height"
        '
        'lblCountryFilter
        '
        Me.lblCountryFilter.AutoSize = True
        Me.lblCountryFilter.Location = New System.Drawing.Point(54, 35)
        Me.lblCountryFilter.Name = "lblCountryFilter"
        Me.lblCountryFilter.Size = New System.Drawing.Size(43, 13)
        Me.lblCountryFilter.TabIndex = 3
        Me.lblCountryFilter.Text = "Country"
        '
        'ComVersion
        '
        Me.ComVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComVersion.FormattingEnabled = True
        Me.ComVersion.Location = New System.Drawing.Point(110, 124)
        Me.ComVersion.Name = "ComVersion"
        Me.ComVersion.Size = New System.Drawing.Size(197, 21)
        Me.ComVersion.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ComVersion, "Select the dogecoin node agent version filter to use")
        '
        'comHeight
        '
        Me.comHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comHeight.FormattingEnabled = True
        Me.comHeight.Location = New System.Drawing.Point(110, 77)
        Me.comHeight.Name = "comHeight"
        Me.comHeight.Size = New System.Drawing.Size(77, 21)
        Me.comHeight.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.comHeight, "Select the blockheight filter to use")
        '
        'comCountry
        '
        Me.comCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comCountry.FormattingEnabled = True
        Me.comCountry.Location = New System.Drawing.Point(110, 32)
        Me.comCountry.Name = "comCountry"
        Me.comCountry.Size = New System.Drawing.Size(77, 21)
        Me.comCountry.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.comCountry, "Select the country filter to use")
        '
        'grdNodeList
        '
        Me.grdNodeList.AllowUserToAddRows = False
        Me.grdNodeList.AllowUserToDeleteRows = False
        Me.grdNodeList.AllowUserToResizeColumns = False
        Me.grdNodeList.AllowUserToResizeRows = False
        Me.grdNodeList.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdNodeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.grdNodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdNodeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdNodeList.DefaultCellStyle = DataGridViewCellStyle15
        Me.grdNodeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdNodeList.GridColor = System.Drawing.Color.White
        Me.grdNodeList.Location = New System.Drawing.Point(399, 21)
        Me.grdNodeList.Name = "grdNodeList"
        Me.grdNodeList.ReadOnly = True
        Me.grdNodeList.RowHeadersVisible = False
        Me.grdNodeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdNodeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grdNodeList.Size = New System.Drawing.Size(360, 362)
        Me.grdNodeList.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "IPAddress"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Port"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'tabNodeMap
        '
        Me.tabNodeMap.Controls.Add(Me.lblMapUpdate)
        Me.tabNodeMap.Controls.Add(Me.pbxMap)
        Me.tabNodeMap.Location = New System.Drawing.Point(4, 22)
        Me.tabNodeMap.Name = "tabNodeMap"
        Me.tabNodeMap.Size = New System.Drawing.Size(795, 404)
        Me.tabNodeMap.TabIndex = 5
        Me.tabNodeMap.Text = "Node Map"
        Me.tabNodeMap.UseVisualStyleBackColor = True
        '
        'lblMapUpdate
        '
        Me.lblMapUpdate.Location = New System.Drawing.Point(88, 384)
        Me.lblMapUpdate.Name = "lblMapUpdate"
        Me.lblMapUpdate.Size = New System.Drawing.Size(608, 19)
        Me.lblMapUpdate.TabIndex = 1
        Me.lblMapUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxMap
        '
        Me.pbxMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxMap.Image = Global.BlockchainNodes.My.Resources.Resources.Map
        Me.pbxMap.Location = New System.Drawing.Point(35, 22)
        Me.pbxMap.Name = "pbxMap"
        Me.pbxMap.Size = New System.Drawing.Size(720, 360)
        Me.pbxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxMap.TabIndex = 0
        Me.pbxMap.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxMap, "Global map of all active Dogecoin nodes. This is filtered by the settings on the " &
        "Node List tab")
        '
        'tabNodestatus
        '
        Me.tabNodestatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabNodestatus.Controls.Add(Me.btnMyIPAddress)
        Me.tabNodestatus.Controls.Add(Me.btnDefaultPort)
        Me.tabNodestatus.Controls.Add(Me.gbxDetails)
        Me.tabNodestatus.Controls.Add(Me.gbxStatus)
        Me.tabNodestatus.Controls.Add(Me.lblPort)
        Me.tabNodestatus.Controls.Add(Me.lblIPAddress)
        Me.tabNodestatus.Controls.Add(Me.txtPort)
        Me.tabNodestatus.Controls.Add(Me.txtIPAddress)
        Me.tabNodestatus.Location = New System.Drawing.Point(4, 22)
        Me.tabNodestatus.Name = "tabNodestatus"
        Me.tabNodestatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNodestatus.Size = New System.Drawing.Size(795, 404)
        Me.tabNodestatus.TabIndex = 0
        Me.tabNodestatus.Text = "Node Status"
        Me.tabNodestatus.ToolTipText = "Display the information for a single node"
        '
        'btnMyIPAddress
        '
        Me.btnMyIPAddress.Image = Global.BlockchainNodes.My.Resources.Resources.IPAddress
        Me.btnMyIPAddress.Location = New System.Drawing.Point(407, 15)
        Me.btnMyIPAddress.Name = "btnMyIPAddress"
        Me.btnMyIPAddress.Size = New System.Drawing.Size(23, 20)
        Me.btnMyIPAddress.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btnMyIPAddress, "Set IP address to my current IP address")
        Me.btnMyIPAddress.UseVisualStyleBackColor = True
        '
        'btnDefaultPort
        '
        Me.btnDefaultPort.Image = Global.BlockchainNodes.My.Resources.Resources.Port
        Me.btnDefaultPort.Location = New System.Drawing.Point(724, 15)
        Me.btnDefaultPort.Name = "btnDefaultPort"
        Me.btnDefaultPort.Size = New System.Drawing.Size(23, 20)
        Me.btnDefaultPort.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnDefaultPort, "Set port to the default dogecoin core port")
        Me.btnDefaultPort.UseVisualStyleBackColor = True
        '
        'gbxDetails
        '
        Me.gbxDetails.Controls.Add(Me.lblZipCode)
        Me.gbxDetails.Controls.Add(Me.lblRegion)
        Me.gbxDetails.Controls.Add(Me.lblISP)
        Me.gbxDetails.Controls.Add(Me.lblCity)
        Me.gbxDetails.Controls.Add(Me.lblCountryName)
        Me.gbxDetails.Controls.Add(Me.lblISPValue)
        Me.gbxDetails.Controls.Add(Me.lblZipCodeValue)
        Me.gbxDetails.Controls.Add(Me.lblRegionValue)
        Me.gbxDetails.Controls.Add(Me.lblCityValue)
        Me.gbxDetails.Controls.Add(Me.lblCountryNameValue)
        Me.gbxDetails.Controls.Add(Me.lblProtocolValue)
        Me.gbxDetails.Controls.Add(Me.lblHeightValue)
        Me.gbxDetails.Controls.Add(Me.lblCountryValue)
        Me.gbxDetails.Controls.Add(Me.lblVersionValue)
        Me.gbxDetails.Controls.Add(Me.lblProtocol)
        Me.gbxDetails.Controls.Add(Me.lblCountry)
        Me.gbxDetails.Controls.Add(Me.lblVersion)
        Me.gbxDetails.Controls.Add(Me.lblHeight)
        Me.gbxDetails.Location = New System.Drawing.Point(41, 210)
        Me.gbxDetails.Name = "gbxDetails"
        Me.gbxDetails.Size = New System.Drawing.Size(717, 182)
        Me.gbxDetails.TabIndex = 9
        Me.gbxDetails.TabStop = False
        Me.gbxDetails.Text = "Details"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(407, 117)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(50, 13)
        Me.lblZipCode.TabIndex = 27
        Me.lblZipCode.Text = "Zip Code"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(416, 84)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(41, 13)
        Me.lblRegion.TabIndex = 26
        Me.lblRegion.Text = "Region"
        '
        'lblISP
        '
        Me.lblISP.AutoSize = True
        Me.lblISP.Location = New System.Drawing.Point(107, 149)
        Me.lblISP.Name = "lblISP"
        Me.lblISP.Size = New System.Drawing.Size(24, 13)
        Me.lblISP.TabIndex = 25
        Me.lblISP.Text = "ISP"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(107, 116)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 24
        Me.lblCity.Text = "City"
        '
        'lblCountryName
        '
        Me.lblCountryName.AutoSize = True
        Me.lblCountryName.Location = New System.Drawing.Point(88, 84)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(43, 13)
        Me.lblCountryName.TabIndex = 23
        Me.lblCountryName.Text = "Country"
        '
        'lblISPValue
        '
        Me.lblISPValue.BackColor = System.Drawing.Color.White
        Me.lblISPValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblISPValue.Location = New System.Drawing.Point(140, 145)
        Me.lblISPValue.Name = "lblISPValue"
        Me.lblISPValue.Size = New System.Drawing.Size(178, 20)
        Me.lblISPValue.TabIndex = 22
        Me.lblISPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblISPValue, "Internet Service Provider for the node")
        '
        'lblZipCodeValue
        '
        Me.lblZipCodeValue.BackColor = System.Drawing.Color.White
        Me.lblZipCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZipCodeValue.Location = New System.Drawing.Point(471, 112)
        Me.lblZipCodeValue.Name = "lblZipCodeValue"
        Me.lblZipCodeValue.Size = New System.Drawing.Size(178, 20)
        Me.lblZipCodeValue.TabIndex = 21
        Me.lblZipCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblZipCodeValue, "Zip Code where the node is located")
        '
        'lblRegionValue
        '
        Me.lblRegionValue.BackColor = System.Drawing.Color.White
        Me.lblRegionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegionValue.Location = New System.Drawing.Point(471, 80)
        Me.lblRegionValue.Name = "lblRegionValue"
        Me.lblRegionValue.Size = New System.Drawing.Size(178, 20)
        Me.lblRegionValue.TabIndex = 20
        Me.lblRegionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblRegionValue, "Region where the node is located")
        '
        'lblCityValue
        '
        Me.lblCityValue.BackColor = System.Drawing.Color.White
        Me.lblCityValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCityValue.Location = New System.Drawing.Point(140, 113)
        Me.lblCityValue.Name = "lblCityValue"
        Me.lblCityValue.Size = New System.Drawing.Size(178, 20)
        Me.lblCityValue.TabIndex = 19
        Me.lblCityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCityValue, "City where the node is located")
        '
        'lblCountryNameValue
        '
        Me.lblCountryNameValue.BackColor = System.Drawing.Color.White
        Me.lblCountryNameValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountryNameValue.Location = New System.Drawing.Point(140, 81)
        Me.lblCountryNameValue.Name = "lblCountryNameValue"
        Me.lblCountryNameValue.Size = New System.Drawing.Size(178, 20)
        Me.lblCountryNameValue.TabIndex = 18
        Me.lblCountryNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCountryNameValue, "Country where the node is located")
        '
        'lblProtocolValue
        '
        Me.lblProtocolValue.BackColor = System.Drawing.Color.White
        Me.lblProtocolValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProtocolValue.Location = New System.Drawing.Point(471, 46)
        Me.lblProtocolValue.Name = "lblProtocolValue"
        Me.lblProtocolValue.Size = New System.Drawing.Size(178, 20)
        Me.lblProtocolValue.TabIndex = 17
        Me.lblProtocolValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblProtocolValue, "Network protocol used by the node")
        '
        'lblHeightValue
        '
        Me.lblHeightValue.BackColor = System.Drawing.Color.White
        Me.lblHeightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeightValue.Location = New System.Drawing.Point(471, 16)
        Me.lblHeightValue.Name = "lblHeightValue"
        Me.lblHeightValue.Size = New System.Drawing.Size(178, 20)
        Me.lblHeightValue.TabIndex = 16
        Me.lblHeightValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblHeightValue, "Blockheight on the node")
        '
        'lblCountryValue
        '
        Me.lblCountryValue.BackColor = System.Drawing.Color.White
        Me.lblCountryValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountryValue.Location = New System.Drawing.Point(140, 49)
        Me.lblCountryValue.Name = "lblCountryValue"
        Me.lblCountryValue.Size = New System.Drawing.Size(178, 20)
        Me.lblCountryValue.TabIndex = 15
        Me.lblCountryValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCountryValue, "Country code for the nodes location")
        '
        'lblVersionValue
        '
        Me.lblVersionValue.BackColor = System.Drawing.Color.White
        Me.lblVersionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVersionValue.Location = New System.Drawing.Point(140, 17)
        Me.lblVersionValue.Name = "lblVersionValue"
        Me.lblVersionValue.Size = New System.Drawing.Size(178, 20)
        Me.lblVersionValue.TabIndex = 14
        Me.lblVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblVersionValue, "Node agent version")
        '
        'lblProtocol
        '
        Me.lblProtocol.AutoSize = True
        Me.lblProtocol.Location = New System.Drawing.Point(368, 50)
        Me.lblProtocol.Name = "lblProtocol"
        Me.lblProtocol.Size = New System.Drawing.Size(89, 13)
        Me.lblProtocol.TabIndex = 13
        Me.lblProtocol.Text = "Network Protocol"
        Me.lblProtocol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCountry
        '
        Me.lblCountry.AutoSize = True
        Me.lblCountry.Location = New System.Drawing.Point(60, 51)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(71, 13)
        Me.lblCountry.TabIndex = 11
        Me.lblCountry.Text = "Country Code"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(58, 18)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(73, 13)
        Me.lblVersion.TabIndex = 9
        Me.lblVersion.Text = "Agent Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(419, 17)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 7
        Me.lblHeight.Text = "Height"
        Me.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbxStatus
        '
        Me.gbxStatus.Controls.Add(Me.pbxCurrent)
        Me.gbxStatus.Controls.Add(Me.pbxUpToDate)
        Me.gbxStatus.Controls.Add(Me.pbxStatus)
        Me.gbxStatus.Controls.Add(Me.lblVersionStatus)
        Me.gbxStatus.Controls.Add(Me.lblHeightStatus)
        Me.gbxStatus.Controls.Add(Me.lblOnlineStatus)
        Me.gbxStatus.Location = New System.Drawing.Point(41, 41)
        Me.gbxStatus.Name = "gbxStatus"
        Me.gbxStatus.Size = New System.Drawing.Size(717, 163)
        Me.gbxStatus.TabIndex = 8
        Me.gbxStatus.TabStop = False
        Me.gbxStatus.Text = "Status"
        '
        'pbxCurrent
        '
        Me.pbxCurrent.Image = Global.BlockchainNodes.My.Resources.Resources.Grey
        Me.pbxCurrent.Location = New System.Drawing.Point(531, 29)
        Me.pbxCurrent.Name = "pbxCurrent"
        Me.pbxCurrent.Size = New System.Drawing.Size(126, 120)
        Me.pbxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCurrent.TabIndex = 8
        Me.pbxCurrent.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxCurrent, "If the agent version is current based on Github details, this will be green. If n" &
        "ot it will be red. Non-standard agents will be grey.")
        '
        'pbxUpToDate
        '
        Me.pbxUpToDate.Image = Global.BlockchainNodes.My.Resources.Resources.Grey
        Me.pbxUpToDate.Location = New System.Drawing.Point(300, 29)
        Me.pbxUpToDate.Name = "pbxUpToDate"
        Me.pbxUpToDate.Size = New System.Drawing.Size(126, 120)
        Me.pbxUpToDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxUpToDate.TabIndex = 7
        Me.pbxUpToDate.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxUpToDate, "For an active node, this will be green, yellow or red dependent on how up to date" &
        " the blockheight is on the node. The thresholds can be adjusted on the settings " &
        "tab")
        '
        'pbxStatus
        '
        Me.pbxStatus.Image = Global.BlockchainNodes.My.Resources.Resources.Grey
        Me.pbxStatus.Location = New System.Drawing.Point(62, 29)
        Me.pbxStatus.Name = "pbxStatus"
        Me.pbxStatus.Size = New System.Drawing.Size(126, 120)
        Me.pbxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxStatus.TabIndex = 6
        Me.pbxStatus.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxStatus, "If there is an active node at the specified IP address and port, this will be gre" &
        "en, if not it will be red")
        '
        'lblVersionStatus
        '
        Me.lblVersionStatus.AutoSize = True
        Me.lblVersionStatus.Location = New System.Drawing.Point(538, 13)
        Me.lblVersionStatus.Name = "lblVersionStatus"
        Me.lblVersionStatus.Size = New System.Drawing.Size(110, 13)
        Me.lblVersionStatus.TabIndex = 5
        Me.lblVersionStatus.Text = "Agent Version Current"
        '
        'lblHeightStatus
        '
        Me.lblHeightStatus.AutoSize = True
        Me.lblHeightStatus.Location = New System.Drawing.Point(297, 13)
        Me.lblHeightStatus.Name = "lblHeightStatus"
        Me.lblHeightStatus.Size = New System.Drawing.Size(127, 13)
        Me.lblHeightStatus.TabIndex = 4
        Me.lblHeightStatus.Text = "Block Height Up To Date"
        '
        'lblOnlineStatus
        '
        Me.lblOnlineStatus.AutoSize = True
        Me.lblOnlineStatus.Location = New System.Drawing.Point(89, 13)
        Me.lblOnlineStatus.Name = "lblOnlineStatus"
        Me.lblOnlineStatus.Size = New System.Drawing.Size(68, 13)
        Me.lblOnlineStatus.TabIndex = 3
        Me.lblOnlineStatus.Text = "Agent Online"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(530, 18)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 4
        Me.lblPort.Text = "Port"
        '
        'lblIPAddress
        '
        Me.lblIPAddress.AutoSize = True
        Me.lblIPAddress.Location = New System.Drawing.Point(85, 18)
        Me.lblIPAddress.Name = "lblIPAddress"
        Me.lblIPAddress.Size = New System.Drawing.Size(58, 13)
        Me.lblIPAddress.TabIndex = 3
        Me.lblIPAddress.Text = "IP Address"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(572, 15)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(146, 20)
        Me.txtPort.TabIndex = 2
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPort, "Port address of the node")
        '
        'txtIPAddress
        '
        Me.txtIPAddress.Location = New System.Drawing.Point(152, 15)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(249, 20)
        Me.txtIPAddress.TabIndex = 1
        Me.txtIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtIPAddress, "IP Address of the node in IPv4 or IPv6 format")
        '
        'tabSettings
        '
        Me.tabSettings.AutoScroll = True
        Me.tabSettings.AutoScrollMargin = New System.Drawing.Size(0, 20)
        Me.tabSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.tabSettings.Controls.Add(Me.gbxUpdate)
        Me.tabSettings.Controls.Add(Me.gbxMapCache)
        Me.tabSettings.Controls.Add(Me.gbxLogging)
        Me.tabSettings.Controls.Add(Me.btnSaveSettings)
        Me.tabSettings.Controls.Add(Me.gbxNotification)
        Me.tabSettings.Controls.Add(Me.gbxWindow)
        Me.tabSettings.Controls.Add(Me.btnRestoreDefaults)
        Me.tabSettings.Controls.Add(Me.gbxThresholdSettings)
        Me.tabSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSettings.Size = New System.Drawing.Size(795, 404)
        Me.tabSettings.TabIndex = 4
        Me.tabSettings.Text = "Settings"
        '
        'gbxUpdate
        '
        Me.gbxUpdate.Controls.Add(Me.btnUpdateNow)
        Me.gbxUpdate.Controls.Add(Me.btnCheckForUpdate)
        Me.gbxUpdate.Controls.Add(Me.lblUpdateStatus)
        Me.gbxUpdate.Controls.Add(Me.lblLatestVersionValue)
        Me.gbxUpdate.Controls.Add(Me.lblInstalledVersionValue)
        Me.gbxUpdate.Controls.Add(Me.lblLatestVersion)
        Me.gbxUpdate.Controls.Add(Me.lblInstalledVersion)
        Me.gbxUpdate.Location = New System.Drawing.Point(28, 738)
        Me.gbxUpdate.Name = "gbxUpdate"
        Me.gbxUpdate.Size = New System.Drawing.Size(715, 100)
        Me.gbxUpdate.TabIndex = 7
        Me.gbxUpdate.TabStop = False
        Me.gbxUpdate.Text = "Update DogeNodes"
        '
        'btnUpdateNow
        '
        Me.btnUpdateNow.AutoSize = True
        Me.btnUpdateNow.Location = New System.Drawing.Point(525, 57)
        Me.btnUpdateNow.Name = "btnUpdateNow"
        Me.btnUpdateNow.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdateNow.TabIndex = 6
        Me.btnUpdateNow.Text = "Update Now"
        Me.ToolTip1.SetToolTip(Me.btnUpdateNow, "Update now to the latest version of DogeNodes")
        Me.btnUpdateNow.UseVisualStyleBackColor = True
        '
        'btnCheckForUpdate
        '
        Me.btnCheckForUpdate.AutoSize = True
        Me.btnCheckForUpdate.Location = New System.Drawing.Point(349, 57)
        Me.btnCheckForUpdate.Name = "btnCheckForUpdate"
        Me.btnCheckForUpdate.Size = New System.Drawing.Size(101, 23)
        Me.btnCheckForUpdate.TabIndex = 5
        Me.btnCheckForUpdate.Text = "Check for Update"
        Me.ToolTip1.SetToolTip(Me.btnCheckForUpdate, "Check for latest available version of DogeNodes")
        Me.btnCheckForUpdate.UseVisualStyleBackColor = True
        '
        'lblUpdateStatus
        '
        Me.lblUpdateStatus.Location = New System.Drawing.Point(326, 31)
        Me.lblUpdateStatus.Name = "lblUpdateStatus"
        Me.lblUpdateStatus.Size = New System.Drawing.Size(314, 13)
        Me.lblUpdateStatus.TabIndex = 4
        Me.lblUpdateStatus.Text = "Update Status"
        Me.lblUpdateStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLatestVersionValue
        '
        Me.lblLatestVersionValue.AutoSize = True
        Me.lblLatestVersionValue.Location = New System.Drawing.Point(164, 62)
        Me.lblLatestVersionValue.Name = "lblLatestVersionValue"
        Me.lblLatestVersionValue.Size = New System.Drawing.Size(74, 13)
        Me.lblLatestVersionValue.TabIndex = 3
        Me.lblLatestVersionValue.Text = "Latest Version"
        Me.ToolTip1.SetToolTip(Me.lblLatestVersionValue, "Latest available version of DogeNodes")
        '
        'lblInstalledVersionValue
        '
        Me.lblInstalledVersionValue.AutoSize = True
        Me.lblInstalledVersionValue.Location = New System.Drawing.Point(164, 31)
        Me.lblInstalledVersionValue.Name = "lblInstalledVersionValue"
        Me.lblInstalledVersionValue.Size = New System.Drawing.Size(84, 13)
        Me.lblInstalledVersionValue.TabIndex = 2
        Me.lblInstalledVersionValue.Text = "Installed Version"
        Me.ToolTip1.SetToolTip(Me.lblInstalledVersionValue, "Currently installed version of DogeNodes")
        '
        'lblLatestVersion
        '
        Me.lblLatestVersion.AutoSize = True
        Me.lblLatestVersion.Location = New System.Drawing.Point(81, 62)
        Me.lblLatestVersion.Name = "lblLatestVersion"
        Me.lblLatestVersion.Size = New System.Drawing.Size(77, 13)
        Me.lblLatestVersion.TabIndex = 1
        Me.lblLatestVersion.Text = "Latest Version:"
        Me.lblLatestVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblInstalledVersion
        '
        Me.lblInstalledVersion.AutoSize = True
        Me.lblInstalledVersion.Location = New System.Drawing.Point(71, 31)
        Me.lblInstalledVersion.Name = "lblInstalledVersion"
        Me.lblInstalledVersion.Size = New System.Drawing.Size(87, 13)
        Me.lblInstalledVersion.TabIndex = 0
        Me.lblInstalledVersion.Text = "Installed Version:"
        Me.lblInstalledVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbxMapCache
        '
        Me.gbxMapCache.Controls.Add(Me.chkHighlightCurrentNode)
        Me.gbxMapCache.Controls.Add(Me.btnClearMapCache)
        Me.gbxMapCache.Controls.Add(Me.lblPercentageNodes)
        Me.gbxMapCache.Controls.Add(Me.lblCacheNodes)
        Me.gbxMapCache.Controls.Add(Me.lblPercentageNodesValue)
        Me.gbxMapCache.Controls.Add(Me.lblCacheNodesValue)
        Me.gbxMapCache.Location = New System.Drawing.Point(28, 530)
        Me.gbxMapCache.Name = "gbxMapCache"
        Me.gbxMapCache.Size = New System.Drawing.Size(715, 98)
        Me.gbxMapCache.TabIndex = 6
        Me.gbxMapCache.TabStop = False
        Me.gbxMapCache.Text = "Map"
        '
        'chkHighlightCurrentNode
        '
        Me.chkHighlightCurrentNode.AutoSize = True
        Me.chkHighlightCurrentNode.Location = New System.Drawing.Point(57, 29)
        Me.chkHighlightCurrentNode.Name = "chkHighlightCurrentNode"
        Me.chkHighlightCurrentNode.Size = New System.Drawing.Size(254, 17)
        Me.chkHighlightCurrentNode.TabIndex = 20
        Me.chkHighlightCurrentNode.Text = "Highlight the currently selected node on the map"
        Me.ToolTip1.SetToolTip(Me.chkHighlightCurrentNode, "Choose whether or not to highlight on the map, the node currently selected for no" &
        "de status")
        Me.chkHighlightCurrentNode.UseVisualStyleBackColor = True
        '
        'btnClearMapCache
        '
        Me.btnClearMapCache.Location = New System.Drawing.Point(565, 60)
        Me.btnClearMapCache.Name = "btnClearMapCache"
        Me.btnClearMapCache.Size = New System.Drawing.Size(75, 23)
        Me.btnClearMapCache.TabIndex = 19
        Me.btnClearMapCache.Text = "Clear Cache"
        Me.ToolTip1.SetToolTip(Me.btnClearMapCache, "Clear the current map cache. This will force a refresh that could take up to 1 ho" &
        "ur")
        Me.btnClearMapCache.UseVisualStyleBackColor = True
        '
        'lblPercentageNodes
        '
        Me.lblPercentageNodes.AutoSize = True
        Me.lblPercentageNodes.Location = New System.Drawing.Point(272, 65)
        Me.lblPercentageNodes.Name = "lblPercentageNodes"
        Me.lblPercentageNodes.Size = New System.Drawing.Size(140, 13)
        Me.lblPercentageNodes.TabIndex = 18
        Me.lblPercentageNodes.Text = "Percentage Nodes Updated"
        '
        'lblCacheNodes
        '
        Me.lblCacheNodes.AutoSize = True
        Me.lblCacheNodes.Location = New System.Drawing.Point(55, 65)
        Me.lblCacheNodes.Name = "lblCacheNodes"
        Me.lblCacheNodes.Size = New System.Drawing.Size(83, 13)
        Me.lblCacheNodes.TabIndex = 17
        Me.lblCacheNodes.Text = "Nodes in Cache"
        '
        'lblPercentageNodesValue
        '
        Me.lblPercentageNodesValue.BackColor = System.Drawing.Color.White
        Me.lblPercentageNodesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentageNodesValue.Location = New System.Drawing.Point(418, 61)
        Me.lblPercentageNodesValue.Name = "lblPercentageNodesValue"
        Me.lblPercentageNodesValue.Size = New System.Drawing.Size(83, 20)
        Me.lblPercentageNodesValue.TabIndex = 16
        Me.lblPercentageNodesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblPercentageNodesValue, "The percentage of nodes in the cache with a location against them. This will drop" &
        " to zero when the cache is first refreshed, then gradually return to 100 percent" &
        "")
        '
        'lblCacheNodesValue
        '
        Me.lblCacheNodesValue.BackColor = System.Drawing.Color.White
        Me.lblCacheNodesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCacheNodesValue.Location = New System.Drawing.Point(143, 61)
        Me.lblCacheNodesValue.Name = "lblCacheNodesValue"
        Me.lblCacheNodesValue.Size = New System.Drawing.Size(82, 20)
        Me.lblCacheNodesValue.TabIndex = 15
        Me.lblCacheNodesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lblCacheNodesValue, "The total number of node locations held in the cache. This may fluctuate up and d" &
        "own as the cache refreshes")
        '
        'gbxLogging
        '
        Me.gbxLogging.Controls.Add(Me.btnCopyLog)
        Me.gbxLogging.Controls.Add(Me.btnClearLog)
        Me.gbxLogging.Controls.Add(Me.btnDisplayLog)
        Me.gbxLogging.Controls.Add(Me.chkAllowLogging)
        Me.gbxLogging.Controls.Add(Me.comLogLvl)
        Me.gbxLogging.Location = New System.Drawing.Point(28, 407)
        Me.gbxLogging.Name = "gbxLogging"
        Me.gbxLogging.Size = New System.Drawing.Size(715, 104)
        Me.gbxLogging.TabIndex = 5
        Me.gbxLogging.TabStop = False
        Me.gbxLogging.Text = "Logging"
        '
        'btnCopyLog
        '
        Me.btnCopyLog.Location = New System.Drawing.Point(396, 65)
        Me.btnCopyLog.Name = "btnCopyLog"
        Me.btnCopyLog.Size = New System.Drawing.Size(124, 23)
        Me.btnCopyLog.TabIndex = 11
        Me.btnCopyLog.Text = "Copy Log To Desktop"
        Me.ToolTip1.SetToolTip(Me.btnCopyLog, "Copy the current Log to the desktop in a write enabled form")
        Me.btnCopyLog.UseVisualStyleBackColor = True
        '
        'btnClearLog
        '
        Me.btnClearLog.Location = New System.Drawing.Point(275, 66)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLog.TabIndex = 10
        Me.btnClearLog.Text = "Clear Log"
        Me.ToolTip1.SetToolTip(Me.btnClearLog, "Clear the current log")
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'btnDisplayLog
        '
        Me.btnDisplayLog.Location = New System.Drawing.Point(156, 66)
        Me.btnDisplayLog.Name = "btnDisplayLog"
        Me.btnDisplayLog.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayLog.TabIndex = 9
        Me.btnDisplayLog.Text = "Display Log"
        Me.ToolTip1.SetToolTip(Me.btnDisplayLog, "Display the current log contents read-only")
        Me.btnDisplayLog.UseVisualStyleBackColor = True
        '
        'chkAllowLogging
        '
        Me.chkAllowLogging.AutoSize = True
        Me.chkAllowLogging.Location = New System.Drawing.Point(58, 34)
        Me.chkAllowLogging.Name = "chkAllowLogging"
        Me.chkAllowLogging.Size = New System.Drawing.Size(100, 17)
        Me.chkAllowLogging.TabIndex = 2
        Me.chkAllowLogging.Text = "Enable Logging"
        Me.ToolTip1.SetToolTip(Me.chkAllowLogging, "Enable logging to a text file")
        Me.chkAllowLogging.UseVisualStyleBackColor = True
        '
        'comLogLvl
        '
        Me.comLogLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comLogLvl.FormattingEnabled = True
        Me.comLogLvl.Items.AddRange(New Object() {"Everything", "Warning and Error", "Error Only", "Debug"})
        Me.comLogLvl.Location = New System.Drawing.Point(260, 30)
        Me.comLogLvl.Name = "comLogLvl"
        Me.comLogLvl.Size = New System.Drawing.Size(121, 21)
        Me.comLogLvl.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.comLogLvl, "Select which notifications should be logged")
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.AutoSize = True
        Me.btnSaveSettings.Location = New System.Drawing.Point(231, 16)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(103, 23)
        Me.btnSaveSettings.TabIndex = 4
        Me.btnSaveSettings.Text = "Save Settings"
        Me.ToolTip1.SetToolTip(Me.btnSaveSettings, "Save the settings so that they will automatically be applied next time the applic" &
        "ation starts")
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'gbxNotification
        '
        Me.gbxNotification.Controls.Add(Me.btnTestEmail)
        Me.gbxNotification.Controls.Add(Me.pbxShow)
        Me.gbxNotification.Controls.Add(Me.lblEmailAddress)
        Me.gbxNotification.Controls.Add(Me.txtEmailAddress)
        Me.gbxNotification.Controls.Add(Me.lblSMTPPassword)
        Me.gbxNotification.Controls.Add(Me.lblSMTPUserName)
        Me.gbxNotification.Controls.Add(Me.lblSMTPPort)
        Me.gbxNotification.Controls.Add(Me.lblSMTPHost)
        Me.gbxNotification.Controls.Add(Me.chkUseSSL)
        Me.gbxNotification.Controls.Add(Me.txtSMTPPassword)
        Me.gbxNotification.Controls.Add(Me.txtSMTPUsername)
        Me.gbxNotification.Controls.Add(Me.txtSMTPPort)
        Me.gbxNotification.Controls.Add(Me.txtSMTPHost)
        Me.gbxNotification.Controls.Add(Me.comEmailNotifLvl)
        Me.gbxNotification.Controls.Add(Me.comWinNotifLvl)
        Me.gbxNotification.Controls.Add(Me.comAppNotifLvl)
        Me.gbxNotification.Controls.Add(Me.chkAllowEmailNotification)
        Me.gbxNotification.Controls.Add(Me.chkApplicationNotification)
        Me.gbxNotification.Controls.Add(Me.chkWindowsNotification)
        Me.gbxNotification.Location = New System.Drawing.Point(28, 184)
        Me.gbxNotification.Name = "gbxNotification"
        Me.gbxNotification.Size = New System.Drawing.Size(715, 206)
        Me.gbxNotification.TabIndex = 3
        Me.gbxNotification.TabStop = False
        Me.gbxNotification.Text = "Notification"
        '
        'btnTestEmail
        '
        Me.btnTestEmail.AutoSize = True
        Me.btnTestEmail.Location = New System.Drawing.Point(475, 163)
        Me.btnTestEmail.Name = "btnTestEmail"
        Me.btnTestEmail.Size = New System.Drawing.Size(94, 23)
        Me.btnTestEmail.TabIndex = 20
        Me.btnTestEmail.Text = "Send Test Email"
        Me.ToolTip1.SetToolTip(Me.btnTestEmail, "Send a test email with these settings")
        Me.btnTestEmail.UseVisualStyleBackColor = True
        '
        'pbxShow
        '
        Me.pbxShow.Image = Global.BlockchainNodes.My.Resources.Resources.eye_icon
        Me.pbxShow.Location = New System.Drawing.Point(638, 144)
        Me.pbxShow.Name = "pbxShow"
        Me.pbxShow.Size = New System.Drawing.Size(20, 12)
        Me.pbxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxShow.TabIndex = 19
        Me.pbxShow.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbxShow, "Hide or show password")
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(103, 169)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(73, 13)
        Me.lblEmailAddress.TabIndex = 18
        Me.lblEmailAddress.Text = "Email Address"
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(182, 166)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(179, 20)
        Me.txtEmailAddress.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtEmailAddress, "Address where notification emails should be sent")
        '
        'lblSMTPPassword
        '
        Me.lblSMTPPassword.AutoSize = True
        Me.lblSMTPPassword.Location = New System.Drawing.Point(416, 143)
        Me.lblSMTPPassword.Name = "lblSMTPPassword"
        Me.lblSMTPPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblSMTPPassword.TabIndex = 16
        Me.lblSMTPPassword.Text = "Password"
        '
        'lblSMTPUserName
        '
        Me.lblSMTPUserName.AutoSize = True
        Me.lblSMTPUserName.Location = New System.Drawing.Point(409, 117)
        Me.lblSMTPUserName.Name = "lblSMTPUserName"
        Me.lblSMTPUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblSMTPUserName.TabIndex = 15
        Me.lblSMTPUserName.Text = "User Name"
        '
        'lblSMTPPort
        '
        Me.lblSMTPPort.AutoSize = True
        Me.lblSMTPPort.Location = New System.Drawing.Point(117, 143)
        Me.lblSMTPPort.Name = "lblSMTPPort"
        Me.lblSMTPPort.Size = New System.Drawing.Size(59, 13)
        Me.lblSMTPPort.TabIndex = 14
        Me.lblSMTPPort.Text = "SMTP Port"
        '
        'lblSMTPHost
        '
        Me.lblSMTPHost.AutoSize = True
        Me.lblSMTPHost.Location = New System.Drawing.Point(114, 117)
        Me.lblSMTPHost.Name = "lblSMTPHost"
        Me.lblSMTPHost.Size = New System.Drawing.Size(62, 13)
        Me.lblSMTPHost.TabIndex = 13
        Me.lblSMTPHost.Text = "SMTP Host"
        '
        'chkUseSSL
        '
        Me.chkUseSSL.AutoSize = True
        Me.chkUseSSL.Location = New System.Drawing.Point(293, 142)
        Me.chkUseSSL.Name = "chkUseSSL"
        Me.chkUseSSL.Size = New System.Drawing.Size(68, 17)
        Me.chkUseSSL.TabIndex = 12
        Me.chkUseSSL.Text = "Use SSL"
        Me.ToolTip1.SetToolTip(Me.chkUseSSL, "Select whether SSL is required for sending emails")
        Me.chkUseSSL.UseVisualStyleBackColor = True
        '
        'txtSMTPPassword
        '
        Me.txtSMTPPassword.Location = New System.Drawing.Point(475, 140)
        Me.txtSMTPPassword.Name = "txtSMTPPassword"
        Me.txtSMTPPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSMTPPassword.Size = New System.Drawing.Size(165, 20)
        Me.txtSMTPPassword.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtSMTPPassword, "Password required for SMTP host")
        '
        'txtSMTPUsername
        '
        Me.txtSMTPUsername.Location = New System.Drawing.Point(475, 114)
        Me.txtSMTPUsername.Name = "txtSMTPUsername"
        Me.txtSMTPUsername.Size = New System.Drawing.Size(183, 20)
        Me.txtSMTPUsername.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtSMTPUsername, "Username required for SMTP Host")
        '
        'txtSMTPPort
        '
        Me.txtSMTPPort.Location = New System.Drawing.Point(182, 140)
        Me.txtSMTPPort.Name = "txtSMTPPort"
        Me.txtSMTPPort.Size = New System.Drawing.Size(47, 20)
        Me.txtSMTPPort.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.txtSMTPPort, "SMTP port for sending emails")
        '
        'txtSMTPHost
        '
        Me.txtSMTPHost.Location = New System.Drawing.Point(182, 114)
        Me.txtSMTPHost.Name = "txtSMTPHost"
        Me.txtSMTPHost.Size = New System.Drawing.Size(179, 20)
        Me.txtSMTPHost.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtSMTPHost, "SMTP host used to send emails")
        '
        'comEmailNotifLvl
        '
        Me.comEmailNotifLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comEmailNotifLvl.FormattingEnabled = True
        Me.comEmailNotifLvl.Items.AddRange(New Object() {"Warning and Error", "Error Only"})
        Me.comEmailNotifLvl.Location = New System.Drawing.Point(260, 76)
        Me.comEmailNotifLvl.Name = "comEmailNotifLvl"
        Me.comEmailNotifLvl.Size = New System.Drawing.Size(121, 21)
        Me.comEmailNotifLvl.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.comEmailNotifLvl, "Select which notification emails will be sent")
        '
        'comWinNotifLvl
        '
        Me.comWinNotifLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comWinNotifLvl.FormattingEnabled = True
        Me.comWinNotifLvl.Items.AddRange(New Object() {"Warning and Error", "Error Only"})
        Me.comWinNotifLvl.Location = New System.Drawing.Point(260, 53)
        Me.comWinNotifLvl.Name = "comWinNotifLvl"
        Me.comWinNotifLvl.Size = New System.Drawing.Size(121, 21)
        Me.comWinNotifLvl.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.comWinNotifLvl, "Select which popup notifications will be displayed")
        '
        'comAppNotifLvl
        '
        Me.comAppNotifLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comAppNotifLvl.FormattingEnabled = True
        Me.comAppNotifLvl.Items.AddRange(New Object() {"Warning and Error", "Error Only"})
        Me.comAppNotifLvl.Location = New System.Drawing.Point(260, 30)
        Me.comAppNotifLvl.Name = "comAppNotifLvl"
        Me.comAppNotifLvl.Size = New System.Drawing.Size(121, 21)
        Me.comAppNotifLvl.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.comAppNotifLvl, "Select which application notifications will be displayed")
        '
        'chkAllowEmailNotification
        '
        Me.chkAllowEmailNotification.AutoSize = True
        Me.chkAllowEmailNotification.Location = New System.Drawing.Point(56, 78)
        Me.chkAllowEmailNotification.Name = "chkAllowEmailNotification"
        Me.chkAllowEmailNotification.Size = New System.Drawing.Size(143, 17)
        Me.chkAllowEmailNotification.TabIndex = 3
        Me.chkAllowEmailNotification.Text = "Enable Email Notification"
        Me.ToolTip1.SetToolTip(Me.chkAllowEmailNotification, "Allow notifications to be sent via email")
        Me.chkAllowEmailNotification.UseVisualStyleBackColor = True
        '
        'chkApplicationNotification
        '
        Me.chkApplicationNotification.AutoSize = True
        Me.chkApplicationNotification.Location = New System.Drawing.Point(56, 32)
        Me.chkApplicationNotification.Name = "chkApplicationNotification"
        Me.chkApplicationNotification.Size = New System.Drawing.Size(170, 17)
        Me.chkApplicationNotification.TabIndex = 1
        Me.chkApplicationNotification.Text = "Enable Application Notification"
        Me.ToolTip1.SetToolTip(Me.chkApplicationNotification, "Allow notifications to be displayed at the bottom of the application window")
        Me.chkApplicationNotification.UseVisualStyleBackColor = True
        '
        'chkWindowsNotification
        '
        Me.chkWindowsNotification.AutoSize = True
        Me.chkWindowsNotification.Location = New System.Drawing.Point(56, 55)
        Me.chkWindowsNotification.Name = "chkWindowsNotification"
        Me.chkWindowsNotification.Size = New System.Drawing.Size(162, 17)
        Me.chkWindowsNotification.TabIndex = 0
        Me.chkWindowsNotification.Text = "Enable Windows Notification"
        Me.ToolTip1.SetToolTip(Me.chkWindowsNotification, "Allow notifications to be displayed in a popup at the bottom right of the desktop" &
        "")
        Me.chkWindowsNotification.UseVisualStyleBackColor = True
        '
        'gbxWindow
        '
        Me.gbxWindow.Controls.Add(Me.chkShowTooltips)
        Me.gbxWindow.Controls.Add(Me.chkDesktopShortcut)
        Me.gbxWindow.Controls.Add(Me.chkStartWithWindows)
        Me.gbxWindow.Controls.Add(Me.chkStartMinimised)
        Me.gbxWindow.Controls.Add(Me.comStartup)
        Me.gbxWindow.Controls.Add(Me.lblStartupTab)
        Me.gbxWindow.Controls.Add(Me.btnForceClose)
        Me.gbxWindow.Controls.Add(Me.chkMinimiseOnClose)
        Me.gbxWindow.Controls.Add(Me.chkMinimiseToTray)
        Me.gbxWindow.Controls.Add(Me.chkHideTrayIcon)
        Me.gbxWindow.Location = New System.Drawing.Point(28, 45)
        Me.gbxWindow.Name = "gbxWindow"
        Me.gbxWindow.Size = New System.Drawing.Size(715, 124)
        Me.gbxWindow.TabIndex = 2
        Me.gbxWindow.TabStop = False
        Me.gbxWindow.Text = "Window"
        '
        'chkShowTooltips
        '
        Me.chkShowTooltips.AutoSize = True
        Me.chkShowTooltips.Location = New System.Drawing.Point(354, 19)
        Me.chkShowTooltips.Name = "chkShowTooltips"
        Me.chkShowTooltips.Size = New System.Drawing.Size(93, 17)
        Me.chkShowTooltips.TabIndex = 9
        Me.chkShowTooltips.Text = "Show Tooltips"
        Me.ToolTip1.SetToolTip(Me.chkShowTooltips, "Show or hide all tooltips")
        Me.chkShowTooltips.UseVisualStyleBackColor = True
        '
        'chkDesktopShortcut
        '
        Me.chkDesktopShortcut.AutoSize = True
        Me.chkDesktopShortcut.Location = New System.Drawing.Point(56, 42)
        Me.chkDesktopShortcut.Name = "chkDesktopShortcut"
        Me.chkDesktopShortcut.Size = New System.Drawing.Size(139, 17)
        Me.chkDesktopShortcut.TabIndex = 8
        Me.chkDesktopShortcut.Text = "Add shortcut to desktop"
        Me.ToolTip1.SetToolTip(Me.chkDesktopShortcut, "Add a shortcut for DogeNodes to the desktop")
        Me.chkDesktopShortcut.UseVisualStyleBackColor = True
        '
        'chkStartWithWindows
        '
        Me.chkStartWithWindows.AutoSize = True
        Me.chkStartWithWindows.Location = New System.Drawing.Point(56, 19)
        Me.chkStartWithWindows.Name = "chkStartWithWindows"
        Me.chkStartWithWindows.Size = New System.Drawing.Size(117, 17)
        Me.chkStartWithWindows.TabIndex = 7
        Me.chkStartWithWindows.Text = "Start with Windows"
        Me.ToolTip1.SetToolTip(Me.chkStartWithWindows, "Start the application automatically on Windows login")
        Me.chkStartWithWindows.UseVisualStyleBackColor = True
        '
        'chkStartMinimised
        '
        Me.chkStartMinimised.AutoSize = True
        Me.chkStartMinimised.Location = New System.Drawing.Point(56, 65)
        Me.chkStartMinimised.Name = "chkStartMinimised"
        Me.chkStartMinimised.Size = New System.Drawing.Size(150, 17)
        Me.chkStartMinimised.TabIndex = 6
        Me.chkStartMinimised.Text = "Start application minimised"
        Me.ToolTip1.SetToolTip(Me.chkStartMinimised, "Start the application minimised to the tray or task bar")
        Me.chkStartMinimised.UseVisualStyleBackColor = True
        '
        'comStartup
        '
        Me.comStartup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comStartup.FormattingEnabled = True
        Me.comStartup.Items.AddRange(New Object() {"Summary", "Statistics", "Node List", "Node Map", "Node Status", "Settings"})
        Me.comStartup.Location = New System.Drawing.Point(120, 86)
        Me.comStartup.Name = "comStartup"
        Me.comStartup.Size = New System.Drawing.Size(121, 21)
        Me.comStartup.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.comStartup, "Choose the tab that is displayed when the application starts or is restored from " &
        "the tray or taskbar")
        '
        'lblStartupTab
        '
        Me.lblStartupTab.AutoSize = True
        Me.lblStartupTab.Location = New System.Drawing.Point(54, 89)
        Me.lblStartupTab.Name = "lblStartupTab"
        Me.lblStartupTab.Size = New System.Drawing.Size(60, 13)
        Me.lblStartupTab.TabIndex = 4
        Me.lblStartupTab.Text = "StartupTab"
        '
        'btnForceClose
        '
        Me.btnForceClose.AutoSize = True
        Me.btnForceClose.Location = New System.Drawing.Point(470, 84)
        Me.btnForceClose.Name = "btnForceClose"
        Me.btnForceClose.Size = New System.Drawing.Size(98, 23)
        Me.btnForceClose.TabIndex = 3
        Me.btnForceClose.Text = "Close Application"
        Me.ToolTip1.SetToolTip(Me.btnForceClose, "Use this button to close the application if you have chosen to minimise it on clo" &
        "se")
        Me.btnForceClose.UseVisualStyleBackColor = True
        '
        'chkMinimiseOnClose
        '
        Me.chkMinimiseOnClose.AutoSize = True
        Me.chkMinimiseOnClose.Location = New System.Drawing.Point(354, 88)
        Me.chkMinimiseOnClose.Name = "chkMinimiseOnClose"
        Me.chkMinimiseOnClose.Size = New System.Drawing.Size(110, 17)
        Me.chkMinimiseOnClose.TabIndex = 2
        Me.chkMinimiseOnClose.Text = "Minimise on Close"
        Me.ToolTip1.SetToolTip(Me.chkMinimiseOnClose, "Minimise the application when the close button is clicked. If this option is sele" &
        "cted the application can only be closed from the 'Close Application' button")
        Me.chkMinimiseOnClose.UseVisualStyleBackColor = True
        '
        'chkMinimiseToTray
        '
        Me.chkMinimiseToTray.AutoSize = True
        Me.chkMinimiseToTray.Location = New System.Drawing.Point(354, 65)
        Me.chkMinimiseToTray.Name = "chkMinimiseToTray"
        Me.chkMinimiseToTray.Size = New System.Drawing.Size(233, 17)
        Me.chkMinimiseToTray.TabIndex = 1
        Me.chkMinimiseToTray.Text = "Minimise to the Tray Instead of the Task bar"
        Me.ToolTip1.SetToolTip(Me.chkMinimiseToTray, "Choose whether the application is minimised to the system tray or the taskbar. Th" &
        "e application can be restored from either location")
        Me.chkMinimiseToTray.UseVisualStyleBackColor = True
        '
        'chkHideTrayIcon
        '
        Me.chkHideTrayIcon.AutoSize = True
        Me.chkHideTrayIcon.Location = New System.Drawing.Point(354, 42)
        Me.chkHideTrayIcon.Name = "chkHideTrayIcon"
        Me.chkHideTrayIcon.Size = New System.Drawing.Size(96, 17)
        Me.chkHideTrayIcon.TabIndex = 0
        Me.chkHideTrayIcon.Text = "Hide Tray Icon"
        Me.ToolTip1.SetToolTip(Me.chkHideTrayIcon, "Show or hide the icon that appears in the system tray")
        Me.chkHideTrayIcon.UseVisualStyleBackColor = True
        '
        'btnRestoreDefaults
        '
        Me.btnRestoreDefaults.AutoSize = True
        Me.btnRestoreDefaults.Location = New System.Drawing.Point(382, 16)
        Me.btnRestoreDefaults.Name = "btnRestoreDefaults"
        Me.btnRestoreDefaults.Size = New System.Drawing.Size(96, 23)
        Me.btnRestoreDefaults.TabIndex = 1
        Me.btnRestoreDefaults.Text = "Restore Defaults"
        Me.ToolTip1.SetToolTip(Me.btnRestoreDefaults, "Restore all the default settings")
        Me.btnRestoreDefaults.UseVisualStyleBackColor = True
        '
        'gbxThresholdSettings
        '
        Me.gbxThresholdSettings.Controls.Add(Me.lblYellowToRed)
        Me.gbxThresholdSettings.Controls.Add(Me.lblGreenToYellow)
        Me.gbxThresholdSettings.Controls.Add(Me.trkYellowToRed)
        Me.gbxThresholdSettings.Controls.Add(Me.trkGreenToYellow)
        Me.gbxThresholdSettings.Controls.Add(Me.lblYellowRed)
        Me.gbxThresholdSettings.Controls.Add(Me.lblGreenYellow)
        Me.gbxThresholdSettings.Location = New System.Drawing.Point(28, 644)
        Me.gbxThresholdSettings.Name = "gbxThresholdSettings"
        Me.gbxThresholdSettings.Size = New System.Drawing.Size(715, 76)
        Me.gbxThresholdSettings.TabIndex = 0
        Me.gbxThresholdSettings.TabStop = False
        Me.gbxThresholdSettings.Text = "Block Height Threshold"
        '
        'lblYellowToRed
        '
        Me.lblYellowToRed.Location = New System.Drawing.Point(585, 32)
        Me.lblYellowToRed.Name = "lblYellowToRed"
        Me.lblYellowToRed.Size = New System.Drawing.Size(30, 23)
        Me.lblYellowToRed.TabIndex = 7
        '
        'lblGreenToYellow
        '
        Me.lblGreenToYellow.Location = New System.Drawing.Point(282, 32)
        Me.lblGreenToYellow.Name = "lblGreenToYellow"
        Me.lblGreenToYellow.Size = New System.Drawing.Size(33, 23)
        Me.lblGreenToYellow.TabIndex = 6
        '
        'trkYellowToRed
        '
        Me.trkYellowToRed.Location = New System.Drawing.Point(475, 25)
        Me.trkYellowToRed.Maximum = 40
        Me.trkYellowToRed.Minimum = 1
        Me.trkYellowToRed.Name = "trkYellowToRed"
        Me.trkYellowToRed.Size = New System.Drawing.Size(104, 45)
        Me.trkYellowToRed.TabIndex = 5
        Me.trkYellowToRed.TickFrequency = 2
        Me.ToolTip1.SetToolTip(Me.trkYellowToRed, "Adjust the threshold at which the block height status changes from yellow to red")
        Me.trkYellowToRed.Value = 16
        '
        'trkGreenToYellow
        '
        Me.trkGreenToYellow.Location = New System.Drawing.Point(172, 25)
        Me.trkGreenToYellow.Maximum = 20
        Me.trkGreenToYellow.Minimum = 1
        Me.trkGreenToYellow.Name = "trkGreenToYellow"
        Me.trkGreenToYellow.Size = New System.Drawing.Size(104, 45)
        Me.trkGreenToYellow.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.trkGreenToYellow, "Adjust the threshold at which the block height status changes from green to yello" &
        "w")
        Me.trkGreenToYellow.Value = 6
        '
        'lblYellowRed
        '
        Me.lblYellowRed.AutoSize = True
        Me.lblYellowRed.Location = New System.Drawing.Point(396, 32)
        Me.lblYellowRed.Name = "lblYellowRed"
        Me.lblYellowRed.Size = New System.Drawing.Size(73, 13)
        Me.lblYellowRed.TabIndex = 3
        Me.lblYellowRed.Text = "Yellow to Red"
        '
        'lblGreenYellow
        '
        Me.lblGreenYellow.AutoSize = True
        Me.lblGreenYellow.Location = New System.Drawing.Point(87, 32)
        Me.lblGreenYellow.Name = "lblGreenYellow"
        Me.lblGreenYellow.Size = New System.Drawing.Size(82, 13)
        Me.lblGreenYellow.TabIndex = 2
        Me.lblGreenYellow.Text = "Green to Yellow"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslAPIProgressBar, Me.sslLastUpdate, Me.sslError})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslAPIProgressBar
        '
        Me.sslAPIProgressBar.ForeColor = System.Drawing.Color.Gold
        Me.sslAPIProgressBar.Name = "sslAPIProgressBar"
        Me.sslAPIProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.sslAPIProgressBar.Step = 1
        Me.sslAPIProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.sslAPIProgressBar.ToolTipText = "Progress towards next blockchain data update"
        '
        'sslLastUpdate
        '
        Me.sslLastUpdate.AutoSize = False
        Me.sslLastUpdate.Name = "sslLastUpdate"
        Me.sslLastUpdate.Size = New System.Drawing.Size(200, 17)
        Me.sslLastUpdate.Text = "Last Update : Never"
        Me.sslLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sslLastUpdate.ToolTipText = "Time that blockchain data was last updated"
        '
        'sslError
        '
        Me.sslError.AutoSize = False
        Me.sslError.BackColor = System.Drawing.SystemColors.Control
        Me.sslError.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.sslError.ForeColor = System.Drawing.Color.White
        Me.sslError.Name = "sslError"
        Me.sslError.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sslError.Size = New System.Drawing.Size(495, 17)
        Me.sslError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sslError.ToolTipText = "Application notification area"
        '
        'timReloadData
        '
        Me.timReloadData.Enabled = True
        Me.timReloadData.Interval = 60000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "DogeNodes"
        '
        'timClearError
        '
        '
        'timUpdateCache
        '
        Me.timUpdateCache.Interval = 3000
        '
        'timTextbox
        '
        Me.timTextbox.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DogeNodes"
        Me.TabControl1.ResumeLayout(False)
        Me.tabSummary.ResumeLayout(False)
        CType(Me.pbxDogecoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabStatistics.ResumeLayout(False)
        Me.tabStatistics.PerformLayout()
        CType(Me.grdStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNodeList.ResumeLayout(False)
        Me.tabNodeList.PerformLayout()
        Me.gbxFilters.ResumeLayout(False)
        Me.gbxFilters.PerformLayout()
        CType(Me.grdNodeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNodeMap.ResumeLayout(False)
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabNodestatus.ResumeLayout(False)
        Me.tabNodestatus.PerformLayout()
        Me.gbxDetails.ResumeLayout(False)
        Me.gbxDetails.PerformLayout()
        Me.gbxStatus.ResumeLayout(False)
        Me.gbxStatus.PerformLayout()
        CType(Me.pbxCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxUpToDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSettings.ResumeLayout(False)
        Me.tabSettings.PerformLayout()
        Me.gbxUpdate.ResumeLayout(False)
        Me.gbxUpdate.PerformLayout()
        Me.gbxMapCache.ResumeLayout(False)
        Me.gbxMapCache.PerformLayout()
        Me.gbxLogging.ResumeLayout(False)
        Me.gbxLogging.PerformLayout()
        Me.gbxNotification.ResumeLayout(False)
        Me.gbxNotification.PerformLayout()
        CType(Me.pbxShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxWindow.ResumeLayout(False)
        Me.gbxWindow.PerformLayout()
        Me.gbxThresholdSettings.ResumeLayout(False)
        Me.gbxThresholdSettings.PerformLayout()
        CType(Me.trkYellowToRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkGreenToYellow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabNodestatus As TabPage
    Friend WithEvents tabSummary As TabPage
    Friend WithEvents lblPort As Label
    Friend WithEvents lblIPAddress As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtIPAddress As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslLastUpdate As ToolStripStatusLabel
    Friend WithEvents sslError As ToolStripStatusLabel
    Friend WithEvents gbxDetails As GroupBox
    Friend WithEvents gbxStatus As GroupBox
    Friend WithEvents lblProtocol As Label
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblProtocolValue As Label
    Friend WithEvents lblHeightValue As Label
    Friend WithEvents lblCountryValue As Label
    Friend WithEvents lblVersionValue As Label
    Friend WithEvents timReloadData As Timer
    Friend WithEvents pbxDogecoin As PictureBox
    Friend WithEvents lblTotalNodesValue As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents tabStatistics As TabPage
    Friend WithEvents grdStatistics As DataGridView
    Friend WithEvents comStatistics As ComboBox
    Friend WithEvents lblStatisticsSelect As Label
    Friend WithEvents tabNodeList As TabPage
    Friend WithEvents Value As DataGridViewTextBoxColumn
    Friend WithEvents Count As DataGridViewTextBoxColumn
    Friend WithEvents BarChart As DataGridViewTextBoxColumn
    Friend WithEvents grdNodeList As DataGridView
    Friend WithEvents lblRowCount As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents lblNodeRows As Label
    Friend WithEvents lblNodeRowsCount As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents sslAPIProgressBar As ToolStripProgressBar
    Friend WithEvents gbxFilters As GroupBox
    Friend WithEvents lblNetwork As Label
    Friend WithEvents comNetwork As ComboBox
    Friend WithEvents btnClearFilters As Button
    Friend WithEvents lblVersionFilter As Label
    Friend WithEvents lblHeightFilter As Label
    Friend WithEvents lblCountryFilter As Label
    Friend WithEvents ComVersion As ComboBox
    Friend WithEvents comHeight As ComboBox
    Friend WithEvents comCountry As ComboBox
    Friend WithEvents tabSettings As TabPage
    Friend WithEvents lblVersionStatus As Label
    Friend WithEvents lblHeightStatus As Label
    Friend WithEvents lblOnlineStatus As Label
    Friend WithEvents gbxThresholdSettings As GroupBox
    Friend WithEvents lblYellowRed As Label
    Friend WithEvents lblGreenYellow As Label
    Friend WithEvents btnRestoreDefaults As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents gbxWindow As GroupBox
    Friend WithEvents chkHideTrayIcon As CheckBox
    Friend WithEvents chkMinimiseToTray As CheckBox
    Friend WithEvents chkMinimiseOnClose As CheckBox
    Friend WithEvents btnForceClose As Button
    Friend WithEvents comStartup As ComboBox
    Friend WithEvents lblStartupTab As Label
    Friend WithEvents pbxStatus As PictureBox
    Friend WithEvents pbxUpToDate As PictureBox
    Friend WithEvents pbxCurrent As PictureBox
    Friend WithEvents lblNodes As Label
    Friend WithEvents gbxNotification As GroupBox
    Friend WithEvents chkWindowsNotification As CheckBox
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents chkAllowEmailNotification As CheckBox
    Friend WithEvents chkAllowLogging As CheckBox
    Friend WithEvents chkApplicationNotification As CheckBox
    Friend WithEvents comEmailNotifLvl As ComboBox
    Friend WithEvents comLogLvl As ComboBox
    Friend WithEvents comWinNotifLvl As ComboBox
    Friend WithEvents comAppNotifLvl As ComboBox
    Friend WithEvents timClearError As Timer
    Friend WithEvents gbxLogging As GroupBox
    Friend WithEvents btnClearLog As Button
    Friend WithEvents btnDisplayLog As Button
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblRegion As Label
    Friend WithEvents lblISP As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblCountryName As Label
    Friend WithEvents lblISPValue As Label
    Friend WithEvents lblZipCodeValue As Label
    Friend WithEvents lblRegionValue As Label
    Friend WithEvents lblCityValue As Label
    Friend WithEvents lblCountryNameValue As Label
    Friend WithEvents tabNodeMap As TabPage
    Friend WithEvents pbxMap As PictureBox
    Friend WithEvents btnCopyLog As Button
    Friend WithEvents timUpdateCache As Timer
    Friend WithEvents lblSMTPPassword As Label
    Friend WithEvents lblSMTPUserName As Label
    Friend WithEvents lblSMTPPort As Label
    Friend WithEvents lblSMTPHost As Label
    Friend WithEvents chkUseSSL As CheckBox
    Friend WithEvents txtSMTPPassword As TextBox
    Friend WithEvents txtSMTPUsername As TextBox
    Friend WithEvents txtSMTPPort As TextBox
    Friend WithEvents txtSMTPHost As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents txtEmailAddress As TextBox
    Friend WithEvents pbxShow As PictureBox
    Friend WithEvents gbxMapCache As GroupBox
    Friend WithEvents btnClearMapCache As Button
    Friend WithEvents lblPercentageNodes As Label
    Friend WithEvents lblCacheNodes As Label
    Friend WithEvents lblPercentageNodesValue As Label
    Friend WithEvents lblCacheNodesValue As Label
    Friend WithEvents chkStartMinimised As CheckBox
    Friend WithEvents chkDesktopShortcut As CheckBox
    Friend WithEvents chkStartWithWindows As CheckBox
    Friend WithEvents trkYellowToRed As TrackBar
    Friend WithEvents trkGreenToYellow As TrackBar
    Friend WithEvents lblYellowToRed As Label
    Friend WithEvents lblGreenToYellow As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents chkShowTooltips As CheckBox
    Friend WithEvents btnTestEmail As Button
    Friend WithEvents lblMapUpdate As Label
    Friend WithEvents chkHighlightCurrentNode As CheckBox
    Friend WithEvents gbxUpdate As GroupBox
    Friend WithEvents btnUpdateNow As Button
    Friend WithEvents btnCheckForUpdate As Button
    Friend WithEvents lblUpdateStatus As Label
    Friend WithEvents lblLatestVersionValue As Label
    Friend WithEvents lblInstalledVersionValue As Label
    Friend WithEvents lblLatestVersion As Label
    Friend WithEvents lblInstalledVersion As Label
    Friend WithEvents btnDefaultPort As Button
    Friend WithEvents btnMyIPAddress As Button
    Friend WithEvents timTextbox As Timer
    Friend WithEvents lblAgentPort As Label
    Friend WithEvents comPort As ComboBox
    Friend WithEvents btnRunDogecoinNode As Button
End Class
