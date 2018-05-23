# Module 1: Overview of the Microsoft Azure Platform

# Lab: Exploring the Azure Portal

### Exercise 1: Signing in to the Azure Portal

#### Task 1: Sign in to the Azure Portal

1. On the Start screen, click the **Internet Explorer** tile.

1. Go to *(<https://portal.azure.com>)*.

1. Enter the email address of your Microsoft account.

1. Click Next.

1. Enter the password for your Microsoft account

1. Click **Sign In**.

1. If this is your first time logging in to the Azure portal, you will see a dialog with a tour of the portal. Click **Get Started**.

> **Results**: After completing this exercise, you will have signed in to the Azure Portal.

### Exercise 2: Customizing the Azure Portal

#### Task 1: Customize the Dashboard

1. After the dashboard is fully loaded, right-click the **Dashboard** (home screen), and then click **Edit**.

1. In the **Tile Gallery**, drag the *Service Health* tile onto your dashboard.

1. At the top of the tile, click the button with three ellipses *“…”*.

1. Select the **2x4** size option.

1. In the **Tile Gallery**, drag the *Markdown* tile onto your dashboard.

1. In the **Content** section of the **Edit Markdown** dialog that appears, update the content with the following markup:

	```
	# Account Details:
	## Corporate Account
	Account **&#35;&#52;&#55;&#57;** is managed by the ``IT department``.
	> &copy;2016
	```

1. Click the **Done** button.

1. Right-click the **Dashboard** (home screen), and then click **Done customizing**.

#### Task 2: View a blade

1. In the navigation pane on the left side, click **All services**.

1. Within the list located in the panel that displays, click **Subscriptions**.

1. Observe the **Subscriptions** blade that displays.

1. In the top menu bar, click the gear icon.

1. Observe the **Portal Settings** blade that displays.

#### Task 3: Begin a journey

1. At the top-left corner of the screen, click **Create a resource**.

1. In the **New** panel that displays, click the **See all** link next to the **Azure Marketplace** header.

1. In the **Marketplace** blade that displays, click **Web**.

1. In the **Web** blade that displays, locate the search box at the top of the blade, type in the text **starter** and then press *Enter*.

1. In the search **results**, locate and select the **ASP.NET Starter Web App** option.

1. In the **ASP.NET Starter Web App** blade that displays, click **Create**.

1. In the next **ASP.NET Starter Web App** blade that displays, click the **App Service plan/Location** option.

1. In the App Service Plan blade, click the **Create New** button.

1. Provide a name for your new **App Service Plan**.

1. Scroll to the left, and click the close (**X**) button on the first **ASP.NET Starter Web App** blade to close the journey.

1. In the **Message from webpage** Internet Explorer dialog box, click **OK**.

> **Results**: After completing this exercise, you will have viewed blades, journeys, and journey parts.

### Exercise 3: Exploring the Azure Cloud Shell

#### Task 1: Open the Cloud Shell

1. At the top of the portal, click the **Cloud Shell** icon to open a new shell instance.

    > **Note**: The **Cloud Shell** icon is a symbol that is constructed of the combination of the *greater than* and *underscore* characters.

1. Because this is your first time opening the **Cloud Shell** using your *Azure Pass* subscription, you will see a wizard to configure **Cloud Shell** for first-time usage. Perform the following actions:

    a. When offered a choice between **Bash** or **PowerShell**, select the **Bash** option.

    a. You will then see a dialog prompting you to create a new **Storage Account** to begin using the shell. You can safely accept the default settings and click the **Create storage** button.

    a. Wait for the **Cloud Shell** to finish its first-time setup procedures before moving on with the lab.

    > If you do not see the configuration options for **Cloud Shell**, this is most likely because you are using an existing subscription with this course's labs. The labs are written from the perspective that you are using a new Azure Pass subscription. You may see some small discrepancies in future lab instructions.

#### Task 2: Test Cloud Shell

1. In the **Cloud Shell** command prompt at the bottom of the portal, type in the following command and press **Enter** to view a list of possible CLI commands:

    ```
    az --help
    ```

1. Type in the following command and press **Enter** to view a list of possible CLI commands for *Resource Groups*:

    ```
    az group --help
    ```

1. Type in the following command and press **Enter** to view a list of possible CLI commands to *create a Resource Group*:

    ```
    az group create --help
    ```

1. Type in the following command and press **Enter** to view a list of possible CLI commands to *list Resource Groups*:

    ```
    az group list --help
    ```

1. Close the currently running web browser application.

> **Results**: After completing this exercise, you will have used the Azure Cloud Shell to interactively invoke commands using the Azure CLI.