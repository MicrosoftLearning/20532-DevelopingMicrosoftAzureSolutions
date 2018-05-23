# Module 11: Securing Azure Web Applications

# Lab: Integrating Azure Active Directory with the Events Administration Portal

## Exercise 1: Creating an Azure AD Directory

#### Task 1: Sign in to the Azure Portal

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://portal.azure.com>)*.

1. In the email address box, type the email address of your Microsoft account.

1. In the password box, type the password for your Microsoft account.

1. Click **Sign In**.

	> **Note**: If this is your first time logging in to the Portal, you may be prompted with a “Welcome” dialog. You can safely close this dialog and continue.

#### Task 2: Creating an Azure Active Directory Instance

1. At the top of the Azure Portal, click the **Directory and Subscription filter** button. This button typically appears with a book icon.

1. Observe the value printed out next to the **Current directory** text. This directory is known as your **default directory** in Azure. Record this value as you will need to switch back to this directory later in this lab.

1. In the navigation pane on the left side of the portal, click the **Create a resource** link.

1. At the top of the **New** blade, locate the **Search the Marketplace** field.

1. Enter the text **Active Directory** into the search field and press **Enter**.

1. In the **Everything** search results blade, select the **Azure Active Directory** result.

1. In the **Azure Active Directory** blade, click the **Create** button.

1. In the *Create directory* blade, perform the following actions:

    a. In the **Organization name** field, enter the name *Contoso Events*.

    a. In the **Initial domain name** field.

    a. In the **Country or region** list, select the region closest to your location.

    a. Click the **Create** button.

	> **Note**: Wait for Azure to finish creating the Azure Active Directory instance prior to moving forward with the lab. You will receive a notification when the *Azure AD directory* is created.

1. Once the directory is created, the *Create directory* blade will have a button (usually with the text *click here*) to switch to the new directory.

1. The portal will reload within the context of the **Contoso Events** directory. The blade for the Azure Active Directory instance will automatically open.

#### Task 3: Switch Back to Your Primary Directory

1. At the top of the Azure Portal, click the **Directory and Subscription filter** button. This button typically appears with a book icon.

1. In the **Directory + subscription** popup that apepars, select the default directory created with your Azure subscription.

#### Task 4: Populate the Directory With An Example User

> **Note**: If you created your Azure subscription using an organizational identity. You will likely not have access to create new users in your directory. You can safely skip this task and use your own identity in the remaining exercises.

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Azure Active Directory**.

1. In the **Azure Active Directory** blade, locate the **Manage** section on the left-side of the blade and click the **Users** link.

1. In the **Users - All users** pane, observe that your currently logged in account was automatically added to the directory as an administrator.

1. Click the **New user** button at the top of the pane.

1. In the **User** blade, perform the following actions:

    a. In the **Name** field, enter the value **Example Person**.

    a. In the **User name** field, enter the value **exampleperson@[your domain]**. Make sure you use the domain for your default Azure Active Directory instance. For example, if your default domain was ``contoso.onmicrosoft.com``, the value for this field would be ``exampleperson@contoso.onmicrosoft.com``. Record this username as you will need it to login to your application later in this lab.

    a. Ensure the checkbox for the **Show Password** option is selected.

    a. Copy the value of the **Password** field. You will need this temporary password to login to your application later in this lab.

    a. Click the **Create** button to create the new user and temporary password.

## Exercise 2: Securing an Existing ASP.NET Web Application

#### Task 1: Deploying the Contoso Events Solution using ARM

1. On the left side of the portal, click the **Create a resource** link.

1. At the top of the **New** blade, locate the **Search the Marketplace** field.

1. Enter the text **Template Deployment** into the search field and press **Enter**.

1. In the **Everything** search results blade, select the **Template deployment** result.

1. In the **Template deployment** blade, click the **Create** button.

1. In the **Custom deployment** blade, click the *Build your own template in the editor* link.

1. In the **Edit template** blade, locate the text editor and delete the existing template content.

1. In the **Edit template** blade, click the **Load file** link.

1. In the **Open** file dialog that appears, navigate to the **Allfiles (F):\\Mod11\\Labfiles\\Starter** folder.

1. Select the **azuredeploy.json** file.

1. Click the **Open** button.

1. Back in the **Edit template** blade, click the **Save** button to persist the template.

1. Back in the **Custom deployment** blade, perform the following actions:

    a. Leave the **Subscription** field set to it's default value.

    a. In the **Resource group** section, select the **Create new** option.

    a. In the **Resource group** section, locate the list and select the value **MOD11AZAD** option.

    a. Leave the remaining fields in the **SETTINGS** section set to their default values.

    a. In the **Terms and Conditions** section, select the *I agree to the terms and conditions stated above* checkbox.

    a. Click the **Purchase** button.

1. Wait for the creation task to complete before moving on with this lab.

#### Task 2: Enabling Azure AD Integration with Azure App Service

1. In the navigation pane on the left side of the Azure Portal, click **All services**.

1. In the **All services** blade that displays, click **Resource groups**.

1. In the **Resource groups** blade that displays, click the **MOD11AZAD** resource group.

1. In the **MOD11AZAD** blade, locate and click the **Web App** resource that has a prefix of **webm**.

    > **Note**: There is another **Web App** instance with a prefix of **webp** and a **Function App** instance with a prefix of **func**.

1. In the **Web App** blade, click the **Browse** button.

1. Observe that the application loads successfully.

1. Return to the Azure Portal browser tab/window.

1. Back in the **Web App** blade, locate the **Settings** section on the left-side of the blade and click the **Authentication / Authorization** link.

1. In the **Authentication / Authorization** pane, perform the following actions:

    a. In the **App Service Authentication** section, select the **On** option.

    a. In the **Action to take when request is not authenticated** list, select the **Log in with Azure Active Directory** option.

    a. Click the **Azure Active Directory** list item in the **Authentication Providers** section.

1. In the **Azure Active Directory Settings** blade, perform the following actions:

    a. In the top **Management Mode** section, select the **Express** option.

    a. In the second **Management mode** section that appears, select the **Create New AD App** option.

    a. In the **Create App** field, enter the value **contosoevents[Your Name Here]**.

    a. In the **Grant Common Data Services Permissions** section, select the **On** option.

    a. Click the **OK** button.

1. Back in the **Authentication / Authorization** pane, click the **Save** button.

#### Task 3: Validate Azure AD Security

1. On the left-side of the blade, locate and click the **Overview** link.

1. Click the **Browse** button at the top of the blade.

    > **Note**: First, you will be prompted to login using an account in your default directory. You can login using the same account you used to login to the portal or the **Example Person** account you created earlier.

1. In the email address box, type the email address of your Microsoft account.

1. In the password box, type the password for your Microsoft account.

1. Click **Sign In**.

    > **Note**: You will now see a prompt asking if you authorize the **contosoevents[Your Name Here]** application in Azure Active Directory to have specific permissions on your behalf.

1. Click the **Accept** button.

1. Observe that the web application has remain unchanged but it is now secure.

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

#### Task 2: Delete Resource Group

1. Type in the following command and press **Enter** to delete the **MOD10MNUL** *Resource Group*:

    ```
    az group delete --name MOD11AZAD --no-wait --yes
    ```

1. Close the **Cloud Shell** prompt at the bottom of the portal.

#### Task 3: Close Active Applications

1. Close the currently running web browser application.

1. Close the currently running **Visual Studio** application.

> **Review**: In this exercise, you "cleaned up your subscription" by removing the **Resource Groups** used in this lab.