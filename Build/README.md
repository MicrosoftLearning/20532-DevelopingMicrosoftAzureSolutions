# Building the course

It is **strongly** recommended that you use the released files for instructor-led or online deliveries. These steps exist to help you re-build the files manually.

## Prerequisites

* Pandoc 1.13.2
  * Windows Installer: [https://github.com/jgm/pandoc/releases](https://github.com/jgm/pandoc/releases/tag/1.13.2)
* PowerShell Community Extensions 3.2.0
  * Installer: [https://www.powershellgallery.com/packages/Pscx/](https://www.powershellgallery.com/packages/Pscx/3.2.2)

> For some scenarios, you may need to reboot your machine or log off after installing the two prerequisites. This manual build has only been tested with the above versions of each dependency.

## Manual Builds
A PowerShell script is included that will build the course and output two zip files, one for the **AllFiles** and one for the **Lab Instructions**.  The script will initially prompt you for a version number and that version number is used in the name of the resulting zip files.  Both prerequisites must be installed prior to running the script.

> If you are new to PowerShell, you may need to set the execution policy of remote scripts on your machine.  More details can be found here [TechNet: Using the Set-ExecutionPolicy Cmdlet](https://technet.microsoft.com/en-us/library/ee176961.aspx)
