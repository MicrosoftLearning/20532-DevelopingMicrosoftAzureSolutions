# Module 2: Building Application Infrastructure in Azure

# Lab: Creating an Azure Virtual Machine for Development and Testing

### Exercise 1:	Creating a Network and Resource Container

#### Task 1: Sign in to the Azure Portal

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://portal.azure.com>)*.

1. Enter the email address of your Microsoft account. Click **Next**.

1. Enter the password for your Microsoft account.

1. Click **Sign In**.

#### Task 2: Create a Resource Group

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Resource groups**.

1. In the **Resource groups** blade that displays, view your list of resource groups.

1. At the top of the **Resource groups** blade, click the **Add** button.

1. In the **Resource group** blade, perform the following steps:

	a. In the **Resource group name** dialog box, provide the value **20532**.

	a. In the **Resource group location** list, select the region that is closest to your current location.

1. In the **Resource group** blade, click **Create**.

#### Task 3: Create a Virtual Network

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Virtual networks**.

1. In the **Virtual networks** blade that displays, view your list of virtual network instances.

1. At the top of the **Virtual networks** blade, click the **Add** button.

1. In the **Create virtual network** blade, perform the following steps:

	a. In the **Name** dialog box, provide the value **vnet20532**.

	a. Ensure that the **Address space** field has the value **10.0.0.0/16**.

	a. In the **Resource group** section, select the **Use existing** option.

	a. In the **Resource group** section, locate the dialog box and provide the value **20532**.

	a. In the **Location** list, select the region that is closest to your current location.

	a. Within the **Subnet** section, in the **Name** field, provide the value **Apps**.

	a. Within the **Subnet** section, ensure that the **Address range** field has the value **10.0.0.0/24**.

	a. Click the **Create** button.

> **Results**: After completing this exercise, you will have a new virtual network and resource group in Azure

### Exercise 2:	Creating a Development Virtual Machine

#### Task 1: Create a Storage Account

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Storage Accounts**.

1. In the **Storage accounts** blade that displays, view your list of Storage instances.

1. At the top of the **Storage accounts** blade, click the **Add** button.

1. In the **Create storage account** blade that displays, perform the following steps:

	a. In the **Name** field, provide the value **stor20532[your name in lowercase here]**.

	a. In the **Deployment model** section, ensure that the *Resource manager* option is selected.

	a. In the **Account kind** list, ensure that the *Storage (general purpose v1)* option is selected.

	a. In the **Location** list, select the region closest to your current location.

	a. Click on the **Replication** list and select the **Locally-redundant storage (LRS)** option.

	a. In the **Performance** section, ensure that the *Standard* option is selected.

	a. In the **Secure transfer required** section, ensure that the *Disabled* option is selected.

	a. In the **Resource group** section, select the **Use existing** option.

	a. In the **Resource group** section, locate the dialog box and provide the value **20532**.

	a. Click the **Create** button.

> **Note**: Wait for Azure to finish creating the storage account prior to moving forward with the lab. You will receive a notification when the *Storage Account* is created and you will see the Storage Account's blade.

#### Task 2: Create a Virtual Machine

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Virtual machines**.

1. In the **Virtual machines** blade that displays, view your list of Virtual Machine instances.

1. At the top of the **Virtual machines** blade, click the **Add** button.

1. In the **Virtual Machines** blade that displays, search for and select the following template:

	- Visual Studio Community 2017 (latest release) on Windows Server 2016 (x64)

	> **Note**: Ensure that you select this specific template as all further lab instructions assume that you are using this exact Azure SDK version, OS and Visual Studio version.

1. In the **Visual Studio Community 2017 (latest release) on Windows Server 2016 (x64)** blade, ensure that the **Resource Manager** deployment model is selected and click the **Create** button.

1. In the **Create virtual machine** blade that displays, click **Basics** and perform the following steps:

	a. In the **Name** dialog box, provide the value **vm20532**.

	a. In the **VM disk type** list, select the value **HDD**.

	a. In the **User Name** dialog box, provide the value **Student**.

	a. In the **Password** and **Confirm Password** dialog boxes, provide the value **AzurePa$$w0rd**

	a. In the **Resource Group** section, locate the **Use existing** option, and then select the **20532** resource group.

	a. In the **Location** list, select the region closest to your current location.

	a. Click the **OK** button.

1. In the **Create Virtual Machine** blade, click **Size** and perform the following steps:

	a. Locate the search field at the top of the blade and then enter the value *F4*.

	a. Locate and select the **F4 Standard** option.

	a. Click the **Select** button.

1. In the **Create Virtual Machine** blade, click **Settings** and perform the following steps:

	a. Under the **Storage > Use managed disks** section, select the **No** option.

	a. Click the **Storage Account** section and then select **stor20532[your name here]**.

	a. Click the **Virtual Network** section and then select **vnet20532**.

	a. Click the **Subnet** section and then select **Apps**.

	a. Leave default values for **Public IP Address**, **Network Security Group (firewall)**, **Extensions** and **High Availability**.

	a. In the **Enable auto-shutdown** section, select the **On** option and configure a shutdown time that is after business hours in your location.

	a. Under the **Monitoring > Boot diagnostics** section, select the **Disabled** option.

	a. Under the **Monitoring > Guest OS diagnostics** section, select the **Disabled** option.

	a. Scroll down and click **OK**.

1. In the **Create Virtual Machine** blade, click **Summary** and then click **Create** to create the virtual machine using your specified configuration.

	> **Note**: The creation of a new virtual machine can take anywhere between 10 to 15 minutes. You will see a notification on the Dashboard (home screen) when your virtual machine is created and running.

1. Select the newly created virtual machine from your Dashboard.

1. In the **vm20532** blade, locate the **Settings** section.

1. In the **Settings** section, select the **Disks** option.

1. In the **Disks** blade, click the **Add data disk** button.

1. In the **Attach unmanaged disk** blade, perform the following steps:

	a. In the **Name** field, provide **vm20532-AllFiles**

	a. For **Source type**, select **New (empty disk)**

	a. For **Account type**, select **Standard (HDD)**.

	a. In the **Size (GiB)** dialog box, provide the value, **128**.

	a. In the **Storage container** section, click on **Browse** and then from the **Storage account** blade, select the previously created storage account, **stor20532[Your Name Here]**

	a. In the **Containers** blade, select **vhds** container and click **Select**.

	a. Click the **OK** button.

	a. To create the second disk, click the **Save** button at the top of the blade.

	> **Note**: Wait about five minutes for the empty disk to be attached to the virtual machine.

1. Select the **Overview** option to return to the **vm20532** blade.

1. Click **Connect** at the top of the screen.

1. In the **Connect to virtual machine** dialog that appears, click the **Download RDP File** button.

1. In the **Internet Explorer download** dialog box, click **Open**.

1. In the **Remote Desktop Connection** dialog box, perform the following steps:

	a. Click **Don’t ask me again for connections to this computer** to prevent this dialog box from displaying again.

	a. Click **Connect**.

1. In the **Windows Security** dialog box, perform the following steps:

	a. Click the **More choices** located at the bottom of the dialog box.
	
	a. Click **Use a different account** that appears.

	a. For the **User name** dialog box, provide the value, **Student**.

	> **Note**: If you computer is on a domain, you may need to add a backslash before the username to "escape" the domain.

	a. For the **Password** dialog box, provide the value, **AzurePa$$w0rd**.

	a. Click the **OK** button.

1. In the **Remote Desktop Connection** dialog box, perform the following steps:

	a. Verify if the Remote certificate name matches the name of your virtual machine.

	a. Click **Don’t ask me again for connections to this computer** to prevent this dialog box from displaying again.

	a. Click **Yes**.

1. When you are prompted to allow your network connection to discover external devices, click **Yes**.

> **Results**: After completing this exercise, you will have a new virtual machine stored in a new storage account.

### Exercise 3: Configuring the Virtual Machine for Development

#### Task 1: Disable IE Enhanced Security Configuration

1. On the Start screen, click the **Server Manager** tile.

1. In the navigation pane on the left side, click **Local Server**.

1. In the **Properties** field, click the **IE Enhanced Security Configuration** option that is currently set to **Off**.

1. In the **Internet Explorer Enhanced Security Configuration** dialog box, perform the following steps:

	a. Under *Administrators*, select **Off**.

	a. Under *Users*, select **Off**.

	a. Click the **OK** button.

#### Task 2: Create an AllFiles Drive

1. Locate and right-click the **Start Menu** located in the lower-left corner of the **Windows** desktop.

	> **Note**: If you are unfamiliar with the latest Windows operating system environment, the **Start Menu** used the **Windows** icon.

1. Select the **Disk Management** option.

1. In the **Initialize Disk** dialog box, perform the following steps:

	a. Verify that **Disk 2** is selected for initialization.

	a. Verify that **MBR (Master Boot Record)** is the selected partition style.

	a. Click the **OK** button.

1. In the lower-half of the Disk Management window, perform the following steps:

	a. Scroll down and find **Disk 2** that was previously initialized.

	a. Right-click the unallocated partition, and then click **New Simple Volume**.

1. In the **New Simple Volume** wizard, perform the following steps:

	a. Click **Next**.

	a. Verify that the **Simple volume size in MB** is a number greater than **100000**.

	a. Click **Next**.

	a. In the **Assign the following drive letter** list, click **F**.

	a. Click **Next**.

	a. Verify that the **File System** setting is set to **NTFS**.

	a. In the **Volume Label** dialog box, provide the value **AllFiles**.

	a. Click **Next**.

	a. Click **Finish** to close the dialog box, and then create the partition.

	> **Note**: If a dialog box displays stating that “You need to format the disk in drive F: before you can use it.”, you can safely close it because you already formatted the disk.

#### Task 3: Download the AllFiles Content

1. On the Start screen, click the **Internet Explorer** tile.

1. If you are prompted to set up Internet Explorer 11, perform the following steps:

	a. Select **Use recommended security, privacy and compatibility settings**.

	a. Click the **OK** button.

1. Go to *(<https://github.com/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions/releases/latest>)*.

1. Scroll down the screen until you find the **allfiles** download link.

1. Click the link to download the AllFiles compressed folder.

1. In the **Internet Explorer** download dialog box, click **Save**.

	> **Note**: The download of the AllFiles executable typically takes around five minutes.

1. Click the **Windows File Explorer** icon in your Taskbar.

1. On the left navigation bar, expand the **This PC** node and click the **Downloads** node:

1. Right-click the **allfiles** compressed folder and select the **Properties** option.

1. In the **allfiles Properties** dialog box, do the following:

	a. Ensure the **Unblock** checkbox is selected.

	a. Click the **OK** button.

1. Right-click the **allfiles** compressed folder and select the **Extract all** option.

1. In the **Extract Compressed (Zipped) Folders** dialog box, do the following:

	a. In the **Files will be extracted to this folder:** dialog, provide the value **F:\\**.

	a. Ensure that the **Show extracted files when complete** checkbox is not selected.

	a. Click **Extract**.

1. Wait for the extraction process to complete.

#### Task 4: Add your Azure subscription to Visual Studio

1. On the Start screen, locate and click the **Visual Studio 2017** tile.

  > **Note**: You might have to use the down arrow to locate the Visual Studio 2017 tile on your Start screen.

1. You will be prompted to sign-in using a **Microsoft Account**. Perform the following steps:

	a. Click the **Sign in** button.

	a. Enter the email address of your Microsoft account. Click **Continue**.

	a. Ensure that the **Keep me signed in** option is selected.

	a. Enter the password for your Microsoft account.

	a. Click **Sign In**.

	> **Note**: You may be prompted by Internet Explorer to remember this password. You can safely close and ignore this dialog.

1. If you have never used **Visual Studio** in the past, you will be prompted to configure your Microsoft Account. Perform the following steps:

	a. Select your **country\region** from the provided list.

	a. Leave the remaining fields set to their default values.

	a. Click the **Continue** button.

1. If you have never used **Visual Studio** in the past, you will also be prompted to configure the apperance of your IDE. Perform the following steps:

	a. Leave all fields set to their default values.

	a. click the **Start Visual Studio** button.

1. Wait for *Visual Studio* to finish **preparing for first use**.

	> **Note**: This process typically takes between 2 to 5 minutes.

1. Validate that you can see the Visual Studio **Start Page**.

	> **Note**: This Virtual Machine will come with **Visual Studio 2017**, the **Azure Storage Emulator** and **SQL LocalDB** pre-installed.

#### Task 5: Install the Azure Cosmos DB Emulator

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://aka.ms/cosmosdb-emulator>)*.

1. In the **Internet Explorer** download dialog box, click **Save**.

	> **Note**: The download of the executable typically takes around two minutes.

1. Click the **Windows File Explorer** icon in your Taskbar.

1. On the left navigation bar, expand the **This PC** node and click the **Downloads** node:

1. Right-click the **Azure Cosmos DB.Emulator** MSI installer and select the **Properties** option.

1. In the **Azure Cosmos DB.Emulator Properties** dialog box, do the following:

	a. Ensure the **Unblock** checkbox is selected.

	a. Click the **OK** button.

1. Right-click the **Azure Cosmos DB.Emulator** MSI installer and select the **Install** option.

1. In the **Azure Cosmos DB Emulator Setup** dialog, perform the following actions:

	a. Ensure the **I accept the terms in the License Agreement** checkbox is selected.

	a. Click the **Install** button.

1. Wait for the installation process to complete.

1. Ensure the **Launch Azure Cosmos DB Emulator** checkbox is unselected.

1. Click the **Finish** button to close the installer.

1. Close the currently running **Visual Studio** application.

> **Results**: After completing this exercise, your development virtual machine will have your lab files installed. Your virtual machine will also have Visual Studio, Azure PowerShell, and the Azure SDK installed.
