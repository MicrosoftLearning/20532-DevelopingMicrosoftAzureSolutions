# Module 10: DevOps in Azure

# Lab: Deploying Templated Environments Using the Cloud Shell

### Scenario

Insert scenario here

### Objectives

After you complete this lab, you will be able to:

- Task 1

- Task 2

- Task 3

### Lab Setup

- *Estimated Time*: 90 minutes

For this lab, you will use the available host machine. Before you begin this lab, you must complete the following steps:

1. Setup 1

## Exercise 1: Start the Cloud Shell

### Scenario

Insert Scenario here

The main tasks for this exercise are as follows:

1. Sign in to the Azure Portal.

1. 

#### Task 1: Sign in to the Azure Portal

1. Sign in to the Azure Portal (https://portal.azure.com).

1. If this is your first time logging in to the Azure portal, you will see a dialog with a tour of the portal. Click Get Started.

#### Task 2: Create Resource Group & Resources

1. Open a new **Cloud Shell** instance.

1. Create a new **Resource Group** with the following details:

    - Name: MOD10MNUL
    
    - Location: EastUS

    ```
    az group create --name MOD10MNUL --location eastus
    ```

1. Create a new **Azure Cosmos DB Account** with the following details:

    - Name: csms20532[Your Name Here] 
    
    - Resource Group: MOD10MNUL

    ```
    az cosmosdb create --name csms20532[Your Name Here] --resource-group MOD10MNUL
    ```

1. Display and record the **Endpoint Uri** of the newly created **Azure Cosmos DB Account**.

    ```
    az cosmosdb show --name csms20532[Your Name Here] --resource-group MOD10MNUL --query 'documentEndpoint' --output tsv
    ```

1. Display and record the **Key** of the newly created **Azure Cosmos DB Account**.

    ```
    az cosmosdb list-keys --name csms20532[Your Name Here] --resource-group MOD10MNUL --query 'primaryMasterKey' --output tsv
    ```

1. Create a new **SQL Server** with the following details:

    - Name: srvr20532[Your Name Here] 

    - Resource Group: MOD10MNUL

    - Admin Username: testuser

    - Admin Password: TestPa$$w0rd

    - Location: East US

    ```
    az sql server create --name srvr20532[Your Name Here] --resource-group MOD10MNUL --admin-user testuser --admin-password TestPa$$w0rd --location eastus
    ```

1. Once the **SQL Server** is created add a *firewall rule* to allow all Azure-originating IP ranges to access your server.
    ```
    az sql server firewall-rule create --name AllowAllWindowsAzureIps --server srvr20532[Your Name Here] --resource-group MOD10MNUL --start-ip-address 0.0.0.0 --end-ip-address 0.0.0.0
    ```

1. Create a new **SQL Database** with the following details:

    - Name: ContosoDB

    - Server: srvr20532[Your Name Here]

    - Resource Group: MOD10MNUL

    - Pricing Tier: Basic

    ```
    az sql db create --name ContosoDB --server srvr20532[Your Name Here] --resource-group MOD10MNUL --edition Basic
    ```

1. Once the **SQL Database** is created, view your **Connection String**. Record this value as you will need to use it later in this lab.  Be sure to replace the placeholder values for ``<username>`` and ``<password>`` with the values **testuser** and **TestPa$$w0rd** respectively.

    ```
    az sql db show-connection-string --name ContosoDB --server srvr20532[Your Name Here] --client ado.net --output tsv
    ```

	> **Note**: For example, if your copied connection string is ``Server=tcp:sv20532microsoft.database.windows.net,1433;Initial Catalog=db20532;Persist Security Info=False;User ID=<username>;Password=<password>;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;``, your updated connection string would be ``Server=tcp:sv20532microsoft.database.windows.net,1433;Initial Catalog=db20532;Persist Security Info=False;User ID=testuser;Password=TestPa$$w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;``:

1. Create an **App Service Plan** with the following details:

    - Name: contosoPlan
    
    - Resource Group: MOD10MNUL

    - Pricing Tier: S1

    ```
    az appservice plan create --name contosoPlan --resource-group MOD10MNUL --sku S1
    ```

1. Create an **Web App** with the following details:

    - Name: webp20532[Your Name Here]
    
    - Resource Group: MOD10MNUL

    - App Service Plan: contosoPlan

    ```
    az webapp create --name webp20532[Your Name Here] --resource-group MOD10MNUL --plan contosoPlan
    ```

1. Configure the newly created **Web App** to enable the **Always On** feature.

    ```
    az webapp config set --name webp20532[Your Name Here] --resource-group MOD10MNUL --always-on true
    ```

1. Set the Connection String for the **Web App**. Remember to replace the ``[SQL Database Connection String]`` placeholder the **Connection String** from the **SQL Database** instance you created earlier in this lab:

    ```
    az webapp config connection-string set --name webp20532[Your Name Here] --resource-group MOD10MNUL --connection-string-type SQLAzure --settings EventsContextConnectionString='[SQL Database Connection String]'
    ```

1. Update the **App Setting** of the **Web App**'s with the following details:

    - Setting: CosmosSettings:EndpointUrl

    - CosmosSettings:EndpointUrl Value: '[Azure Cosmos DB Endpoint Uri]'

    ```
    az webapp config appsettings set --name webp20532[Your Name Here] --resource-group MOD10MNUL --settings CosmosSettings:EndpointUrl='[Azure Cosmos DB Endpoint Uri]'
    ```
    > Note: Remember to replace the ``[Azure Cosmos DB Endpoint Uri]`` placeholder the **Endpoint Uri** from the **Azure Cosmos DB** account you created earlier in this lab.

1. Update the **App Setting** of the **Web App**'s with the following details:

    - Setting: CosmosSettings:AuthorizationKey

    - CosmosSettings:AuthorizationKey Value: '[Azure Cosmos DB Key]'

    ```
    az webapp config appsettings set --name webp20532[Your Name Here] --resource-group MOD10MNUL --settings CosmosSettings:AuthorizationKey='[Azure Cosmos DB Key]'
    ```

    > Note: Remember to replace the ``[Azure Cosmos DB Key]`` placeholder the **Key** from the **Azure Cosmos DB** account you created earlier in this lab.

#### Task 4: Deploy Web Application Manually

1. Open the **Contoso.Events.sln** solution found in **Allfiles (F):\\Mod10\\Labfiles\\Starter**.

1. Publish the **Contoso.Events.Web** project with the following details:

    - Publish Target: Existing App Service

    - View: Resource Group

    - Search: webp20532. Select the **web app** instance that has the preview listed.

1. Wait for the deployment to complete. Visual Studio will automatically open the deployed web application in a browser window.

1. In the deployed web application, observe the events listed on the home page of the application.

## Exercise 2: Use the Cloud Shell to Deploy an ARM Template

#### Task 1: Create Resource Group

1. Create a new **Resource Group** with the following details:

    - Name: MOD10ARMG

    - Location: The region closest to your current location

#### Task 2: Create Deployment

1. Create a **Template Deployment** with the following details.

    - Custom Deployment: **Allfiles (F):\\Mod10\\Labfiles\\Starter\\azuredeploy.json**

    - New Resource Group: MOD10ARMG

1. Wait for the creation task to complete before moving on with this lab.

#### Task 3: Validate Deployment

1. Access the newly created **Web App** within the **MOD10ARMG** resource group with a prefix of **webp**.

1. Browse the **Web App** to verify it displays a list of events.

1. Select any of hte events on the list and Click the **Register Now** button.

1. Complete and submit the registration form.

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