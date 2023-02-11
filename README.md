# DogeNodes

![Splash](https://user-images.githubusercontent.com/124823644/217800333-62e54878-27ab-474c-abf4-fa7cf2817073.png)

## Description

A Windows Forms based application to analyse the Dogecoin blockchain network and monitor the status of an individual node

## Screenshots

![Summary](https://user-images.githubusercontent.com/124823644/217803867-00c8ce45-270b-45d8-97d3-bc44e2ef20ed.png)

![Statistics](https://user-images.githubusercontent.com/124823644/217803935-ae6e0c80-a2a9-4f69-9b18-4dcaa5370bc5.png)

![NodeList](https://user-images.githubusercontent.com/124823644/217803981-e7b9523e-77f0-4b33-9051-5e273533ceac.png)

![NodeMap](https://user-images.githubusercontent.com/124823644/217804002-fe2e975d-7b75-4d68-b800-3a7e7596ad96.png)

![NodeStatus](https://user-images.githubusercontent.com/124823644/217804034-1388326c-89ac-45b7-aa31-ac52fd766595.png)

## Features

 - Summary of total active nodes
 - Breakdown of nodes by country, block height, agent version and network protocol
 - Filterable list of all nodes
 - Global map of filtered node location (Initial map load may take up to 1 hour, but after that it is cached)
 - Ability to select detailed status of any node 
 - Monitoring of selected node status including pop up alerts and email alerts if any issues arise
 - Highly configurable behaviour including start with windows, minimize to tray and minimise on close
 
## Requirements

 - Network connection to the internet
 - No inbound ports need to be opened
 - Microsoft Windows operating system (I have tested on Windows 10 only)
 - Dot Net Framework 4.7.2
 
## To Do List

- progress bar for initial map load
- Test button for email configuration
- Plot currently selected node location on map
- Add tooltips
 
## Acknowledgements

Thanks to the following API providers used as the source of data for this application

- https://blockchair.com/
- https://ip-api.com/
- https://github.com/
