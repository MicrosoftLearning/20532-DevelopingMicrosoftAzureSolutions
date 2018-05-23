# Module 9: Automating Integration with Azure Resources

# Lab: Automating the Creation of Azure Assets using PowerShell and the Azure CLI

## Exercise 1: Use Azure CLI to Create and Manage an Azure Web App

#### Task 1: Preparing the Azure CLI Environment

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://aka.ms/installazurecliwindows>)*.

1. In the **Internet Explorer** download dialog box, click **Save**.

	> **Note**: The download of the executable typically takes around two minutes.

1. Click the **Windows File Explorer** icon in your Taskbar.

1. On the left navigation bar, expand the **This PC** node and click the **Downloads** node:

1. Right-click the **azure-cli** MSI installer and select the **Properties** option.

1. In the **azure-cli Properties** dialog box, do the following:

	a. Ensure the **Unblock** checkbox is selected.

	a. Click the **OK** button.

1. Right-click the **azure-cli** MSI installer and select the **Install** option.

1. In the **Microsoft CLI 2.0 for Azure Setup** dialog, perform the following actions:

	a. Ensure the **I accept the terms in the License Agreement** checkbox is selected.

	a. Click the **Install** button.

1. Wait for the installation process to complete.

1. Click the **Finish** button to close the installer.

1. On the Start screen, click the down arrow to view all the applications, and then click **Command Prompt**.

1. Switch to the **Command Prompt** window.

1. To validate that the **azure** CLI command is available, type the following command in the console, and then press Enter:
    
    ```
    az --help
    ```
    
#### Task 2: Login to Your Azure Subscription Using Interactive Login

1. To begin the interactive login process, type the following command in the console, and then press Enter:
       
    ```
    az login
    ```
       
1. Take a note of the code provided by the CLI command tool:

    > **Note**: The code is displayed in the command prompt. For example, you may see: ``Enter the code A2U763CQ9 to authenticate``. In this example, the code is ``A2U763CQ9``.

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(https://microsoft.com/devicelogin)*.

1. In the code dialog box, type in the code you recorded earlier.

1. If the code is correct, the page will refresh automatically and render the name of the application requesting access to your Azure subscription (**Microsoft Azure CLI**).

1. Click the **Continue** button.

1. In the email address dialog box, type the email address of your Microsoft account.

1. Click **Next**.

1. In the password dialog box, type the password for your Microsoft account.

1. Click **Sign In**.

    > **Note**: If you were successful, you will see the message *"You have signed in to the Microsoft Azure Cross-platform Command Line Interface application on your device"*. The code has a timeout so it is possible to not login quickly enough using the Device Login page. If this happens, simply repeat this task.

1. Return to the **Command Prompt** application.

1. To view your account details, type the following command in the console, and then press Enter:

    ```
    az account list
    ```

    > **Note**: If you have multiple Azure subscriptions, you can use **az account set --subscription [subscription-name]** to select the appropriate subscription. If you are unsure about your subscription's name, you can simply use **az account list**. If your Azure subscription is provided by a Learning Partner, it might be an auto-generated account without any details. In such a case, this command will return an empty result.

> **Results**: After completing this exercise, you will have set up a development environment to use xPlat CLI for Azure service automation.

#### Task 3: Create a New Web App

1. To create a new Resource Group, type the following command in the console by providing the name **rga20532**, the **West US** location and then press Enter:

    ```
    az group create --name MOD09ZCLI --location "West US"
    ```

    > **Note**: You might get an error message notifying you that your Website’s name is not unique. If this occurs, select a new name until your Website is created.

1. To view a list of your Resource Groups, type the following command in the console, and then press Enter:

    ```
    az group list
    ```

1. To create a new App Service Plan Resource, type the following command in the console and then press Enter:

    ```
    az appservice plan create --resource-group MOD09ZCLI --name InexpensivePlan --is-linux --sku B1
    ```

1. To create a new Web App Resource, type the following command in the console by providing the unique name selected for your Web App and then press Enter:

    ```
    az webapp create --name [Unique Name] --resource-group MOD09ZCLI --plan InexpensivePlan --runtime "node|6.2"
    ```

    > **Note**: You might get an error message notifying you that your Web App's name is not unique. If this occurs, select a new name until your Website is created.

1. To view a list of Resources in the **MOD09ZCLI** Resource Group, type the following command in the console, and then press Enter:

    ```
    az resource list --resource-group MOD09ZCLI
    ```

1. To get the details for your new Website, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

    ```
    az resource show --name [Unique Name] --resource-type "Microsoft.Web/Sites" --resource-group MOD09ZCLI
    ```

1. Record the **defaultHostName** value from the list of key-value pairs that are generated by the previous command.

    > **Note**: this hostname property will look similar to this: ``"defaultHostName": "websitepiaxfa4veu6lw.azurewebsites.net"``.

1. To view the new Web App in Internet Explorer, type the following command in the console, and then press Enter:

    ```
    explorer "http://[Host Name]"
    ```

1. Verify that the new Web App is running.

1. Close Internet Explorer.

1. Switch to the **Command Prompt** console window.

#### Task 4: Remove a Resource Group

1. To remove your Resource Group, type the following command in the console by providing the name **MOD09ZCLI**, and then press Enter:

    ```
    az group delete --name MOD09ZCLI  
    ```

1. Type **Y** to indicate that you want to remove the Resource Group, and then press Enter.

1. To verify that your Resource Group has been removed and then press Enter. The resulting array should not include the **MOD09ZCLI** Resource Group:

    ```  
    az group list
    ```

> **Results**: After completing this exercise, you will have used the Azure CLI to manage instances of an Azure service.

## Exercise 2: Use PowerShell to Create and Manage an Azure Storage Account

#### Task 1: Open the Azure PowerShell Console

1. On the Start screen, click the down arrow to view all the applications, and then click **Windows PowerShell**.

1. Switch to the **Windows PowerShell** window.

#### Task 2: Authenticate to Azure Resource Manager Using PowerShell

1. To switch modules, type the following command in the console, and then press Enter:

    ```
    Login-AzureRmAccount
    ```

1. In the **Sign in to your account** dialog box, perform the following steps:

    a. Enter the email address of your Microsoft account.

    a. Click **Next**.

    a. Enter the password for your Microsoft account.

    a. Click **Sign In**.

1. To view your current Azure PowerShell session context type the following command in the console, and then press Enter:

    ```
    Get-AzureRmContext
    ```

> **Note**: If you have multiple Azure subscriptions, you can use **Select-AzureRmSubscription** to select the appropriate subscription.

#### Task 3: Create a resource group by using PowerShell

1. To create a new instance of a resource group from the template, type the following command in the console, and then press Enter:

    ```
    New-AzureRmResourceGroup -Name MOD09ZPSH -Location "West US"
    ```

1. To provide the parameters for the template, type the following command in the console, and then perform the following steps:

    ```
    New-AzureRmResourceGroupDeployment -ResourceGroupName MOD09ZPSH -TemplateFile "F:\Mod09\Labfiles\Starter\azuredeploy.json"
    ```

    a. For the **administratorLogin** prompt, provide the value **testuser**, and then press Enter.

    a. For the **administratorLoginPassword** prompt, provide the value **TestPa$$w0rd**, and press Enter.

    > **Note**: Wait for the provisioning process to complete. Status messages will be displayed periodically and the final message with the details will be displayed when provisioning is complete.

1. To get the details of your new resource group, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

    ```
    Get-AzureRmResourceGroup –ResourceGroupName MOD09ZPSH
    ```

1. To get the details of your new Website, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

    ```
    (Get-AzureRmResource -IsCollection -ResourceGroupName MOD09ZPSH -ResourceType "Microsoft.Web/sites" -ApiVersion 2016-08-01).Properties
    ```

1. Record the value of the **hostNames** property from the JSON data generated by the previous command.

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