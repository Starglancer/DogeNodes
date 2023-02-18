# DogeNodes

![Splash](https://user-images.githubusercontent.com/124823644/217800333-62e54878-27ab-474c-abf4-fa7cf2817073.png)

## Description

A Windows Forms based application to analyse the Dogecoin blockchain network and monitor the status of an individual node

## Screenshots

![Summary](https://user-images.githubusercontent.com/124823644/219656730-52fcc249-4152-4afb-a96e-1c9dc36cad42.png)

![Statistics](https://user-images.githubusercontent.com/124823644/217803935-ae6e0c80-a2a9-4f69-9b18-4dcaa5370bc5.png)

![NodeList](https://user-images.githubusercontent.com/124823644/217803981-e7b9523e-77f0-4b33-9051-5e273533ceac.png)

![Map](https://user-images.githubusercontent.com/124823644/218485680-53e77553-182c-49c7-b0fd-ef7ff99e0930.png)

![NodeStatus](https://user-images.githubusercontent.com/124823644/217804034-1388326c-89ac-45b7-aa31-ac52fd766595.png)

![Settings1](https://user-images.githubusercontent.com/124823644/218485707-321c093f-8d77-40de-8032-52ef329a4bef.png)

![Settings(2)](https://user-images.githubusercontent.com/124823644/219656768-f9cfc6b8-7a63-4298-8164-56ac1cfce8e2.png)

## Features

 - Real time data updated every 10 minutes
 - Summary of total active nodes
 - Breakdown of nodes by country, block height, agent version and network protocol
 - Filterable list of all nodes
 - Global map of filtered node locations
 - Ability to select detailed status of any node 
 - Monitoring of selected node status including pop up alerts and email alerts if any issues arise
 - Highly configurable behaviour including start with windows, minimize to tray and minimise on close
 
## Requirements

 - Network connection to the internet
 - No inbound ports need to be opened
 - Microsoft Windows operating system (I have tested on Windows 10 only)
 - Dot Net Framework 4.7.2. This will be installed at deployment time if not already present
 
## To Do List

- Node status only updates when user stops typing in the IP address or port fields
- add statistics/filter for node port
- add button to select current users IP address on the node status tab
- add a button to select default port on the node status tab
- Create a CHM based help system 
 
## Acknowledgements

Thanks to the following API providers used as the source of data for this application

- [Blockchair](https://blockchair.com/)
- [IP-API](https://ip-api.com/)
- [Github](https://github.com/)

Thanks to [Advanced Installer](https://www.advancedinstaller.com/) for their excellent installer which has been used from release 1.00 onwards
