# Module 2: Building Application Infrastructure in Azure

# Lab: Creating an Azure Virtual Machine for Development and Testing

### Scenario

Before you begin the process of migrating your application from an on premise server to Azure, you must create a development environment. You have elected to use Azure to host a Windows Server 2016 Virtual Machine. This Virtual Machine will already have the following software installed: Visual Studio 2017, SQL Server LocalDB, Azure Storage Emulator, Azure SDK for .NET and Azure PowerShell. You will manually install the Azure Cosmos DB Emulator. Once complete, you will use this virtual machine for all remaining development tasks.

### Objectives

After you complete this lab, you will be able to:

- Create a virtual network.

- Create a Storage account.

- Create a virtual machine.

- Manage the virtual machine VHDs.

- Install development software on a virtual machine.

### Lab Setup

- *Estimated Time*: 90 minutes

For this lab, you will use the available host machine. Before you begin this lab, you must complete the following steps:

1. Verify that you received the credentials from your training provider to sign in to the Azure portal. You will use these credentials and the Azure account throughout the labs in this course.

## Exercise 1: Creating a Network and Resource Container

#### Task 1: Sign in to the Azure Portal

1. Sign in to the Azure Portal (<https://portal.azure.com>).

1. Click **Get Started**.

#### Task 2: Create a Resource Group

1. View the list of resource groups for your subscription.

1. Create a new resource group using the name: **20532**.

#### Task 3: Create a Virtual Network

1. View the list of virtual networks for your subscription.

1. Create a virtual network by using the following details:

	- Name: **vnet20532**

	- Location: **Select the region that is closest to your location**

	- Existing Resource Group: **20532**

	- Address Space: **10.0.0.0/16**

	- Subnet Name: **Apps**

	- Subnet Address Range: **10.0.0.0/24**

> **Results**: After completing this exercise, you will have a new virtual network and resource group in Azure.

## Exercise 2: Creating a Development Virtual Machine

#### Task 1: Create a Storage Account

1. View the list of Storage instances for your subscription.

1. Create a Storage instance by using the following details:

	- Name: **stor20532[Your Name Here]**

	- Deployment model: **Resource manager**

	- Account kind: **General purpose**

	- Performance: **Standard**

	- Replication: **Locally-redundant storage (LRS)**  

	- Resource Group: **20532**

	- Location: **Select the region that is closest to your location**

#### Task 2: Create a Virtual Machine

1. View the list of virtual machines for your subscription.

1. Go to the Virtual Machine gallery and select the **Visual Studio Community 2017 on Windows Server 2016 (x64)** template.

1. Create a new virtual machine using the template and the following details:

	- Name: **vm20532**

	- VM disk type: **HDD**

	- User Name: **Student**

	- Password: **AzurePa$$w0rd**

	- Size: **F4 Standard**

	- Virtual Network: **vnet20532**

	- Subnet: **Apps**

	- Resource Group: **20532**

	- Storage Account: **stor20532[Your Name Here]**

	- Diagnostic Storage Account: **Disabled**

	- Image: **Windows Server 2012 R2 Datacenter**

1. Add a second disk to the virtual machine by using the following settings:

	- Disk File Name: **vm20532-AllFiles.vhd**

	- Size (GiB): **128**

	- Type: **HDD**

	- Storage Account: **stor20532[Your Name Here]**

	- Storage Container: **vhds**

1. Connect to the newly created virtual machine using Remote Desktop.

> **Results**: After completing this exercise, you will have a new virtual machine stored in a new storage account.

## Exercise 3:	Configuring the Virtual Machine for Development

#### Task 1: Disable IE Enhanced Security Configuration

1. If Server Manager is not already open, open **Server Manager**.

1. Within the *Local Server* configuration screen, disable **Internet Explorer Enhanced Security Configuration** for both *Administrators* and *Users*.

#### Task 2: Create an AllFiles Drive

1. Initialize the new disk by using the Windows Disk Manager.

1. Format the new empty drive partition by using the following settings:

  - Drive Letter: **F**

  - Volume Label: **AllFiles**

  - Partition Style: **MBR (Master Boot Record)**

#### Task 3: Download the AllFiles Content

1. Download the **AllFiles** compressed folder from GitHub:

  - https://github.com/MicrosoftLearning/20532-DevelopingMicrosoftAzureSolutions/releases/latest

1. Unblock the AllFiles compressed folder.

1. Extract the content of the AllFiles compressed folder to the drive F.

  - Extract target: **Allfiles** **(F):\\**

#### Task 4: Add your Azure subscription to Visual Studio

1. Open **Visual Studio 2017**.

1. When prompted, sign-in using the **Microsoft Account** associated with your Azure subscription.

	> **Note**: Ensure that the **Keep me signed in** option is selected when you sign-in.

1. Validate that you can see the Visual Studio **Start Page**.

#### Task 5: Install the Azure Cosmos DB Emulator

1. Download the **Azure Cosmos DB Emulator** installer from the Microsoft website:

  - https://aka.ms/cosmosdb-emulator

1. Unblock the MSI installer.

1. Install the software to your local machine using default settings. 

1. Launch the **Azure Cosmos DB Emulator** at least one before finishing this lab.

> **Results**: After completing this exercise, your development virtual machine will have your lab files installed. Your virtual machine will also have Visual Studio, Azure PowerShell, and the Azure SDK installed. 