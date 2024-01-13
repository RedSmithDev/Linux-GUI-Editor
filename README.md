# Linux-GUI-Editor

## Overview

Yet another WSWYG GUI Editor for Linux Desktop apps.
The Editor is based in WinForms C#, to develop Linux  desktop apps in WinForms C#,
using MonoDevelop .net support for Linux.

Create the project -> Edit the GUI interface -> Click the Mono button on the toolbar -> start coding !

*note: the executable created in Linux can run on Windows also*

### Creating a simple project in Linux

![](Images/KitchenTimer_editing.gif)

### Screenshots
#### Project creation:

![](Images/01-CreateProject.png)

####  Default project:

![](Images/02-WelcomeForm.png)

####  Editing:

![](Images/03-EditingForm.png)


#### Mono project automatically generated (ready to code):

![](Images/05-GeneratedMONOProject.png)


## Installation

### Debian / Ubuntu / Mint

#### First install Mono Develop, generally this will work :

```bash
sudo apt install ca-certificates gnupg
sudo gpg --homedir /tmp --no-default-keyring --keyring /usr/share/keyrings/mono-official-archive-keyring.gpg --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb [signed-by=/usr/share/keyrings/mono-official-archive-keyring.gpg] https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
sudo apt install monodevelop
```

But you can refer to the proper documentation :

https://www.mono-project.com/download/stable/

#### After install Mono Develop :

Download from the folder Releases  LCSF_Release_vX.X.Alpha.zip unzip the file

```bash
bash: mono ./LCSF_Editor.exe
```

### Events code

```C#
private void Controls_Click(Control sender, efrmMainControls ctlName, EventArgs e)
    {
        switch(ctlName)
        {
	        case efrmMainControls.btn0:
		        btn0.Text = "Clicked";
	        break;
        }
    }
}
```

### Bugs


* Editing Forms while the MonoDevelop project is open causes MonoDevelop to glitch, close and reopen MonoDevelop or unload reload the project. (will be fixed)
*  The ListBox the HEIGHT can't be changed using drag , only using properties panel
* The preview writes the actual form so it's "save and preview"
* Redo  buggy

### Open Source

will be .