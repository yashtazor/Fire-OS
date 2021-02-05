# Fire OS.
A minature Operating System made with COSMOS and C# in Visual Studio.  

![62bad0f9cdd74956df81e794536fde54](https://user-images.githubusercontent.com/42903859/82881655-96dc0d00-9f5d-11ea-8d7d-63ec80f472ff.png)

## Contents

1. Setting up the environment
2. Features
3. List of Commands
4. How to Run?
5. Credits


### 1. Setting up the environment

<b>Prerequisites</b>  
These have to be installed before installing COSMOS.

1. Visual Studio
2. Visual Studio Workload: .NET Core Tools
3. .NET Framework 4.6.2 Developer Pack 
4. VMWare Workstation (Should include VMWare Player)

#### NOTE 
1. I haven't mentioned the versions here because it is adviced to use the latest version of it at the time of you viewing this project.
2. COSMOS only works with VMWare Player. So, VirtualBox, etc won't work.

After installing all the pre-requisites, install COSMOS from here. Make sure VS is not running.
https://github.com/CosmosOS/Cosmos/releases/tag/Userkit_20190628

Now, if COSMOS installed for you, great! Skip to the next part.  
If not, don't worry. We were in a similar situation and here is a work-around for it.

1. Clone this repository  
https://github.com/CosmosOS/Cosmos
2. Run the install-VS2019.bat file from the repository
3. Simply import any demo project from the 'Demos' folder in VS.

Now, VS automatically detects the missing files and stuff and does the installing for you. Just go through the setup.  

More help in installation can be found here  
https://www.gocosmos.org/docs/install/


### 2. Features

Here is what our OS can do in a nutshell!

1. Security features like locking the system with a password.
2. Run programs like text editor, calculator, XnO game, music player & a basic GUI.
3. Implements a FAT file system (not ExFAT).
4. Implements simple system commands.  


### 3. Commands List

The commands are divided in 3 parts as 'Program' commands, 'File System' commands & 'System' commands.

1. Program Commands    
<b>programs</b>  
Lists all the programs available.

2. File System Commands  
<b>fstats</b>  
Gives the summary of the file system like space free, all files & directories, etc.  
<b>md</b>  
Creates a directory at the current path.  
<b>cd</b>  
Changes the directory to the specified folder.  
<b>curr</b>  
Returns the current path.  
<b>ls</b>  
Lists all the files & folder in the current path.  
<b>df</b>  
Deletes a specified file provided it exists.  
<b>dd</b>  
Deletes a specified folder provided it exists.  
<b>cp</b>  
Copies a file to a specified directory provided both the file and new directory exists.  
<b>mv</b>  
Moves a file to a specified directory provided both the file and new directory exists.  
<b>search</b>  
Search for a file or folder in the current directory.  

3. System Commands  
<b>cls</b>  
Clears the screen.  
<b>echo</b>  
Echos a string to the screen.  
<b>version</b>  
Returns the version of the current build.  
<b>dnt</b>  
Returns the current date & time.  
<b>lock</b>  
Locks the system.  
<b>restart</b>  
Restarts the OS.  
<b>shutdown</b>  
Shuts down the OS.  
<b>about</b>  
Returns information about the OS. 


### 4. How to Run?

The steps involved are

1. Clone this repository.
2. Open in VS.
3. Open the OSProject.sln file.
4. Click COSMOS button on the top in VS.

This would open the running OS in VMWare Player.


### 5. Credits

Some of the modules of the projects weren't created by us. We've listed the features & their creators here.

1. Music Player by
<b>Original COSMOS Creators</b>  
https://github.com/CosmosOS/Cosmos/tree/master/Demos/BeepDemo  

2. Basic GUI Implementation by
<b>Original COSMOS Creators</b>  
https://github.com/CosmosOS/Cosmos/tree/master/Demos/CosmosGraphicSubsystem

##### Created by Yash Dekate & Ayanabha Jana.
