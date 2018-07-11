# Module 9: Automating Integration with Azure Resources

# Lab: Automating the Creation of Azure Assets using PowerShell and the Azure CLI

### Scenario

Now that you have created many of the resources that you will use in your Azure application, you have decided to automate the creation of your assets in Azure. Some of your administrators are Windows experts and would prefer to automate using PowerShell while others use Linux and would prefer to automate from the command line. Due to this requirement, you will try and implement automation using PowerShell and separately using a cross-platform CLI interface.

### Objectives

After you complete this lab, you will be able to:

- Use Azure CLI to Create and Manage an Azure Web App

- Use PowerShell to Create and Manage an Azure Storage Account

### Lab Setup

- *Estimated Time*: 90 minutes

Before starting this lab, you must complete the lab in Module 2. For the lab in this module, you will use the available host machine. Also, you must complete the following steps:

1.  On the host computer, click **Start**, type **Remote**, and then click **Remote Desktop Connection**.

1.  In Remote Desktop Connection, provide the name of your virtual machine in the **Computer** box by using the following format:

    -   **[Your VM IP Address]:[*Your VM RDP Port*]**

    > **Note:** The name and port for your virtual machine might be saved in the Computer drop-down list. If this is the case, use this value instead of typing it in manually. If you are unsure about your virtual machine’s RDP port, use either of the Azure portals to find your virtual machine’s endpoints. The endpoint with the name **Remote Desktop** is the correct port for RDP. This port is randomized to protect your virtual machine from unauthorized access.

1.  In Remote Desktop Connection, click **Connect**. Wait until the RDP client accesses the virtual machine.

1.  If necessary, sign in by using the following credentials:

    -   User name: **Student**

    -   Password: **AzurePa$$w0rd**

1.  Verify that you received the credentials to sign in to the Azure portal from your training provider. You will use these credentials and the Azure account throughout the labs in this course.

## Exercise 1: Use Azure CLI to Create and Manage an Azure Web App

#### Task 1: Preparing the Azure CLI Environment

1. Go to *(<https://aka.ms/installazurecliwindows>)*.

1. Install the **azure-cli** MSI installer.

1. Wait for the installation process to complete.

1. Open **Command Prompt**.

1. Validate that the **azure** CLI command is available with the following command:
    
    ```
    az --help
    ```
    
#### Task 2: Login to Your Azure Subscription Using Interactive Login

1. Use the following command to login:
       
    ```
    az login
    ```
       
1. Follow instructions to complete the authentication process.

1. Validate that process was successful with the following command:

    ```
    az account list
    ```

    > **Note**: If you have multiple Azure subscriptions, you can use **az account set --subscription [subscription-name]** to select the appropriate subscription. If you are unsure about your subscription's name, you can simply use **az account list**. If your Azure subscription is provided by a Learning Partner, it might be an auto-generated account without any details. In such a case, this command will return an empty result.


#### Task 3: Create a New Web App

1. Using command prompt, create a new resource group with the following details:

    - Name: MOD09ZCLI

    - Location: West US

    ```
    az group create --name MOD09ZCLI --location "West US"
    ```

1. view the list of your research groups.

1. Using command prompt, create a new **App Service Plan** with the following details:

    - Name: InexpensivePlan

    - Resource Group: MOD09ZCLI

    - OS: Linux

    - Pricing Tier: B1

    ```
    az appservice plan create --resource-group MOD09ZCLI --name InexpensivePlan --is-linux --sku B1
    ```

1. Using command prompt, create a new **Web App** using the following details

    - Name: Any unique name

    - Resource Group: MOD09ZCLI

    - App Service plan: InexpensivePlan

    - Runtime Stack: node|6.2

    ```
    az webapp create --name [Unique Name] --resource-group MOD09ZCLI --plan InexpensivePlan --runtime "node|6.2"
    ```

1. View a list of Resources in the **MOD09ZCLI** Resource Group.

1. Use the command prompt to pull the details of the newly created *website*

    ```
    az resource show --name [Unique Name] --resource-type "Microsoft.Web/Sites" --resource-group MOD09ZCLI
    ```

1. Record the **defaultHostName** value from the list of key-value pairs that are generated.

1. Access the **defaultHostName** on internet explorer to verify the web app is running.

1. Close Internet explorer and return to the command prompt.

#### Task 4: Remove a Resource Group

1. Remove the resource group **MOD09ZCLI** from your subscription.s

    ```
    az group delete --name MOD09ZCLI  
    ```

1. Verify the resouce group remains no longer 

    ```  
    az group list
    ```

## Exercise 2: Use PowerShell to Create and Manage an Azure Storage Account

#### Task 1: Authenticate to Azure Resource Manager Using PowerShell

1. Open **Windows PowerShell**

1. Using PowerShell log into Azure.

    ```
    Login-AzureRmAccount
    ```

1. View your current Azure PowerShell session:

    ```
    Get-AzureRmContext
    ```
    > **Note**: If you have multiple Azure subscriptions, you can use **Select-AzureRmSubscription** to select the appropriate subscription.

#### Task 2: Create a resource group by using PowerShell

1. Using powershell, create a new resource group with the following details:

    - Name: MOD09ZPSH

    - Location: West US

    ```
    New-AzureRmResourceGroup -Name MOD09ZPSH -Location "West US"
    ```

1. Create a new template with the following details:

    - Resource Group: MOD09ZPSH
    
    - Template File: F:\Mod09\Labfiles\Starter\azuredeploy.json

    - administratorLogin: testuser

    - administratorPassword: TestPa$$w0rd

1. To provide the parameters for the template, type the following command in the console, and then perform the following steps:

    ```
    New-AzureRmResourceGroupDeployment -ResourceGroupName MOD09ZPSH -TemplateFile "F:\Mod09\Labfiles\Starter\azuredeploy.json"
    ```

    a. For the **administratorLogin** prompt, provide the value **testuser**, and then press Enter.

    a. For the **administratorLoginPassword** prompt, provide the value **TestPa$$w0rd**, and press Enter.

    > **Note**: Wait for the provisioning process to complete. Status messages will be displayed periodically and the final message with the details will be displayed when provisioning is complete.

1. View the Details of your new resource group.

    ```
    Get-AzureRmResourceGroup –ResourceGroupName MOD09ZPSH
    ```

1. Use the console to pull the details of the newly created *website*

    ```
    (Get-AzureRmResource -IsCollection -ResourceGroupName MOD09ZPSH -ResourceType "Microsoft.Web/sites" -ApiVersion 2016-08-01).Properties
    ```

1. Record the value of the **hostNames** property.

    > **Note**: this hostname property will look similar to this: ``DefaultHostName : websitepiaxfa4veu6lw.azurewebsites.net``.

1. To view the new Website in Internet Explorer, type the following command in the console, and then press Enter:

    ```
    explorer "http://[Host Name]"
    ```

1. Verify that the new Website is running.

1. Close Internet Explorer.

1. Switch to the **Windows PowerShell** console window.

#### Task 4: Remove the resource group by using PowerShell

1. To remove your new resource group, type the following command in the console, and then press Enter:

    ```
    Remove-AzureRmResourceGroup –Name MOD09ZPSH
    ```

1. Type **Y** to indicate that you want to remove the Website, and then press Enter.

    > **Note**: Because removing a resource group involves removing multiple resources, this process can take 5 to 15 minutes on average.

1. Close the **Windows PowerShell** console window.

> **Results**: After completing this exercise, you will have used Azure to interact with the Resource Manager, resource groups, and resource group templates.