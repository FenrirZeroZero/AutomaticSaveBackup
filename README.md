TL:DR: 
This program can backup files in a folder.

Details:
It checks the files in a specific folder for changes (a simple check on file change date) an saves them in a sub-folder. 
This sub-folder is (on default) located in the specified folder with the name of "Backup". 
Every File gets an sub-folder named after itself in the backup folder. 
The check is performed every second and backups are only done if a change is detected. 

All configurations are saved on close.

UI Explanation:
- The List contains all file in the selected Folder that are to be saved
	- Backup specifies the last Backup Time of the file since Program start (Show 01.01.0001 00:00:00 if no Backup was made)
- The "Add" button lets you choose an Folder that contains the files to backup
	- This will add the Files in the folder to the Backup list (Based on "Add Filter" Field)
- You can specify Filename Filter in "Add Filter". Refer to the Tooltip regarding usable Wildcards.
- "Backup Amount" specifies how many revisions should be kept PER FILE
- "Copy Backup to" lets you specify a different Folder to store the Backup files (Use "Browse" to choose the folder)
	- Only applies if the checkbox is checked
- "Restore" lets you restore a selected file to a previous Version
- "Activate" well activates the Check for Changes

 Compiled for Windows 10 or higher. (Might work on lower version if .net 5.0 is installed)
