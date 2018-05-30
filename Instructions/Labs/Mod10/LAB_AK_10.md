# Module 10: DevOps in Azure

# Lab: Deploying Templated Environments Using the Cloud Shell

## Exercise 1: Start the Cloud Shell

#### Task 1: Sign in to the Azure Portal

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://portal.azure.com>)*.

1. In the email address box, type the email address of your Microsoft account.

1. Click **Next**.

1. In the password box, type the password for your Microsoft account.

1. Click **Sign In**.

	> **Note**: If this is your first time logging in to the Portal, you may be prompted with a “Welcome” dialog. You can safely close this dialog and continue.

#### Task 2: Run the Cloud Shell

1. At the top of the portal, click the **Cloud Shell** icon to open a new shell instance.

    > **Note**: The **Cloud Shell** icon is a symbol that is constructed of the combination of the *greater than* and *underscore* characters.

1. If this is your first time opening the **Cloud Shell** using your *Azure Pass* subscription, you will see a wizard to configure **Cloud Shell** for first-time usage. Perform the following actions:

    a. When offered a choice between **Bash** or **PowerShell**, select the **Bash** option.

    a. You will then see a dialog prompting you to create a new **Storage Account** to begin using the shell. You can safely accept the default settings and click the **Create storage** button.

    a. Wait for the **Cloud Shell** to finish its first-time setup procedures before moving on with the lab.

    > If you do not see the configuration options for **Cloud Shell**, this is most likely because you are using an existing subscription with this course's labs. The labs are written from the perspective that you are using a new Azure Pass subscription. You may see some small discrepancies in future lab instructions.

#### Task 3: Create Resource Group & Resources

1. To create a new **Resource Group**, type the following command into the shell and press Enter:

    ```
    az group create --name MOD10MNUL --location eastus
    ```

1. To create a new **Azure Cosmos DB Account** in the resource group, type the following command into the shell and press Enter:

    ```
    az cosmosdb create --name csms20532[Your Name Here] --resource-group MOD10MNUL
    ```

1. Once the **Azure Cosmos DB Account** is created, type the following command into the shell and press Enter to view your **Endpoint Uri**. Record this value as you will need to use it later in this lab:

    ```
    az cosmosdb show --name csms20532[Your Name Here] --resource-group MOD10MNUL --query 'documentEndpoint' --output tsv
    ```

1. Type the following command into the shell and press Enter to view your **Key** for your **Azure Cosmos DB Account**. Record this value as you will need to use it later in this lab:

    ```
    az cosmosdb list-keys --name csms20532[Your Name Here] --resource-group MOD10MNUL --query 'primaryMasterKey' --output tsv
    ```

1. To create a new **SQL Server** in the resource group, type the following command into the shell and press Enter:

    ```
    az sql server create --name srvr20532[Your Name Here] --resource-group MOD10MNUL --admin-user testuser --admin-password TestPa$$w0rd --location eastus
    ```

1. To add a new *firewall rule* to allow all Azure-originating IP ranges to access your server, type the following command into the shell and press Enter:

    ```
    az sql server firewall-rule create --name AllowAllWindowsAzureIps --server srvr20532[Your Name Here] --resource-group MOD10MNUL --start-ip-address 0.0.0.0 --end-ip-address 0.0.0.0
    ```

1. To create a new **SQL Database** in the resource group, type the following command into the shell and press Enter:

    ```
    az sql db create --name ContosoDB --server srvr20532[Your Name Here] --resource-group MOD10MNUL --edition Basic
    ```

1. Once the **SQL Database** is created, type the following command into the shell and press Enter to view your **Connection String**. Record this value as you will need to use it later in this lab.  Be sure to replace the placeholder values for ``<username>`` and ``<password>`` with the values **testuser** and **TestPa$$w0rd** respectively.

    ```
    az sql db show-connection-string --name ContosoDB --server srvr20532[Your Name Here] --client ado.net --output tsv
    ```

	> **Note**: For example, if your copied connection string is ``Server=tcp:sv20532microsoft.database.windows.net,1433;Initial Catalog=db20532;Persist Security Info=False;User ID=<username>;Password=<password>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;``, your updated connection string would be ``Server=tcp:sv20532microsoft.database.windows.net,1433;Initial Catalog=db20532;Persist Security Info=False;User ID=testuser;Password=TestPa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;``:

1. To create a new **App Service Plan** in the resource group, type the following command into the shell and press Enter:

    ```
    az appservice plan create --name contosoPlan --resource-group MOD10MNUL --sku S1
    ```

1. To create a new **Web App** for the management web application, type the following command into the shell and press Enter:

    ```
    az webapp create --name webp20532[Your Name Here] --resource-group MOD10MNUL --plan contosoPlan
    ```

1. To configure the **Web App** and enable the **Always On** feature, type the following command into the shell and press Enter:

    ```
    az webapp config set --name webp20532[Your Name Here] --resource-group MOD10MNUL --always-on true
    ```

1. To set a **Connection String** in the **Web App**'s configuration, type the following command into the shell and press Enter. Remember to replace the ``[SQL Database Connection String]`` placeholder the **Connection String** from the **SQL Database** instance you created earlier in this lab:

    ```
    az webapp config connection-string set --name webp20532[Your Name Here] --resource-group MOD10MNUL --connection-string-type SQLAzure --settings EventsContextConnectionString='[SQL Database Connection String]'
    ```

1. To set an **App Setting** in the **Web App**'s configuration, type the following command into the shell and press Enter. Remember to replace the ``[Azure Cosmos DB Endpoint Uri]`` placeholder the **Endpoint Uri** from the **Azure Cosmos DB** account you created earlier in this lab:

    ```
    az webapp config appsettings set --name webp20532[Your Name Here] --resource-group MOD10MNUL --settings CosmosSettings:EndpointUrl='[Azure Cosmos DB Endpoint Uri]'
    ```

1. To set an **App Setting** in the **Web App**'s configuration, type the following command into the shell and press Enter. Remember to replace the ``[Azure Cosmos DB Key]`` placeholder the **Key** from the **Azure Cosmos DB** account you created earlier in this lab:

    ```
    az webapp config appsettings set --name webp20532[Your Name Here] --resource-group MOD10MNUL --settings CosmosSettings:AuthorizationKey='[Azure Cosmos DB Key]'
    ```

#### Task 4: Deploy Web Application Manually

1. On the Start screen, click the **Desktop** tile.

1. On the taskbar, click the **File Explorer** icon.

1. In the *This PC* window, go to **Allfiles (F):\\Mod10\\Labfiles\\Starter**, and then double-click **Contoso.Events.sln**.

1. In the **Solution Explorer** pane of the Contoso.Events - Microsoft Visual Studio window, right-click the **Contoso.Events.Web** project and then select the **Publish** option.

1. In the **Pick a publish target** dialog, perform the following actions:

    a. Select the **App Service** option on the left of the dialog.

    a. In the **Azure App Service** section, select the **Select Existing** option.

    a. Click the **Publish** button.

1. In the **App Service** dialog, perform the following actions:

    a. The **Subscription** list should automatically populate with your Azure Subscription data.
    
    a. In the **View** list, select the **Resource Type** option.

    a. In the **Search** field, enter the value **webp20532**.

    a. In the tree view, select the single **Web App** instance that has a prefix of **webp20532**.

    a. Click the **OK** button to begin the deployment process.

1. The deployment process will begin immediately. You can view the status of the deployment by watching the **Web Publish Activity** pane.

1. Wait for the deployment to complete. Visual Studio will automatically open the deployed web application in a browser window.

1. In the deployed web application, observe the events listed on the home page of the application.

## Exercise 2: Use the Cloud Shell to Deploy an ARM Template

#### Task 1: Create Resource Group

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Resource groups**.

1. In the **Resource groups** blade that displays, view your list of Resource groups.

1. At the top of the **Resource groups** blade, click the **Add** button.

1. In the *Create an empty resource group* blade, perform the following actions:

    a. In the **Resource group name** field, enter the value **MOD10ARMG**.

    a. In the **Resource group location** field, select the region closest to your current location.

    a. Click the **Create** button.

#### Task 2: Create Deployment

1. On the left side of the portal, click the **Create a resource** link.

1. At the top of the **New** blade, locate the **Search the Marketplace** field.

1. Enter the text **Template Deployment** into the search field and press **Enter**.

1. In the **Everything** search results blade, select the **Template deployment** result.

1. In the **Template deployment** blade, click the **Create** button.

1. In the **Custom deployment** blade, click the *Build your own template in the editor* link.

1. In the **Edit template** blade, locate the text editor and delete the existing template content.

1. In the **Edit template** blade, click the **Load file** link.

1. In the **Open** file dialog that appears, navigate to the **Allfiles (F):\\Mod10\\Labfiles\\Starter** folder.

1. Select the **azuredeploy.json** file.

1. Click the **Open** button.

1. Back in the **Edit template** blade, click the **Save** button to persist the template.

1. Back in the **Custom deployment** blade, perform the following actions:

    a. Leave the **Subscription** field set to it's default value.

    a. In the **Resource group** section, select the **Use existing** option.

    a. In the **Resource group** section, locate the list and select the value **MOD10ARMG** option.

    a. Leave the remaining fields in the **SETTINGS** section set to their default values.

    a. In the **Terms and Conditions** section, select the *I agree to the terms and conditions stated above* checkbox.

    a. Click the **Purchase** button.

1. Wait for the creation task to complete before moving on with this lab.

#### Task 3: Validate Deployment

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Resource groups**.

1. In the **Resource groups** blade that displays, click the **MOD10ARMG** resource group.

1. In the **MOD10ARMG** blade, locate and click the **Web App** resource that has a prefix of **webp**.

    > **Note**: There is another **Web App** instance with a prefix of **webm** and a **Function App** instance with a prefix of **func**.

1. In the **Web App** blade, click the **Browse** button at the top of the blade.

1. On the home page of the web application, verify that it displays a list of events.

1. Click any of the events in the list.

1. On the event web page, click the **Register Now** button.

1. Fill out all of the fields in the registration form and click Submit.

1. Close the browser window/tab that is displaying the website.

## Exercise 3: Cleanup Subscription

#### Task 1: Open Cloud Shell

1. At the top of the portal, click the **Cloud Shell** icon to open a new shell instance.

1. In the **Cloud Shell** command prompt at the bottom of the portal, type in the following command and press **Enter** to list all resource groups in the subscription:

    ```
    az group list
    ```

1. Type in the following command and press **Enter** to view a list of possible CLI commands to *delete a Resource Group*:

    ```
    az group delete --help
    ```

#### Task 2: Delete Resource Groups

1. Type in the following command and press **Enter** to delete the **MOD10MNUL** *Resource Group*:

    ```
    az group delete --name MOD10MNUL --no-wait --yes
    ```

1. Type in the following command and press **Enter** to delete the **MOD10ARMG** *Resource Group*:

    ```
    az group delete --name MOD10ARMG --no-wait --yes
    ```

1. Close the **Cloud Shell** prompt at the bottom of the portal.

#### Task 3: Close Active Applications

1. Close the currently running web browser application.

1. Close the currently running **Visual Studio** application.

> **Review**: In this exercise, you "cleaned up your subscription" by removing the **Resource Groups** used in this lab.
