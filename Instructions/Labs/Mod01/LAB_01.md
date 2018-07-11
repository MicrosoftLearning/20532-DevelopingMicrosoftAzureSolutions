# Module 1: Overview of the Microsoft Azure Platform

# Lab: Exploring the Azure Portal

### Scenario

You are designated by your team as the individual who will explore the Azure Portal and then train the other team members on how to use the portal. You decided to customize a few features of the portal and create a new service instance.

### Objectives

After you complete this lab, you will be able to:

- Sign in to the Azure Portal.

- Customize your Dashboard.

- Identify a blade.

- Identify a journey.

- Identify a journey part.

- Close a journey without persisting your changes.

### Lab Setup

- *Estimated Time*: 15 minutes

For this lab, you will use the available host machine. Before you begin this lab, you must complete the following step:

1. Verify that you received the credentials to sign in to the Azure portal from you training provider. You will use these credentials and the Azure account throughout the labs in this course.

## Exercise 1: Signing in to the Azure Portal

#### Task 1: Sign in to the Azure Portal

1. Sign in to the Azure Portal (https://portal.azure.com).

1. If this is your first time logging in to the Azure portal, you will see a dialog with a tour of the portal. Click Get Started.

> **Results**: After completing this exercise, you will have signed in to the Azure Portal.

## Exercise 2: Customizing the Azure Portal

#### Task 1: Customize the Dashboard

1. View the **Customization** mode of the Dashboard.

1. Add a new **Service Health** tile using the **2x4** size.

1. Add a new **Markdown** tile using the following content:

	```
	# Account Details:
	## Corporate Account
	Account **&#35;&#52;&#55;&#57;** is managed by the ``IT department``.
	> &copy;2016
	```

1. Close the Customization mode of the Dashboard.

#### Task 2: View a blade

1. Open the **All services** panel, and then click the **Subscriptions** option.

1. View the **Subscriptions** blade.

1. Click the gear button (for settings) in the top right corner of the portal.

1. View the **Portal Settings** blade.

#### Task 3: Begin a journey

1. Open the **New** panel, and then navigate to the **Marketplace**.

1. In the **Marketplace** blade, select the **Web** group, and then create a new instance using the **Web App** template.

1. In the **Web App** journey, view the journey part for creating a new **App Service Plan**.

1. Close the **Web App** blade to view the warning message that notifies you about losing the changes you made in the journey or a journey part.

> **Results**: After completing this exercise, you will have viewed blades, journeys, and journey parts.

### Exercise 3: Exploring the Azure Cloud Shell

#### Task 1: Open the Cloud Shell

1. At the top of the portal, click the **Cloud Shell** icon to open a new instance of the shell.

1. If this is your first time you have opened the Cloud Shell, ensure that you are using the **Bash** version of the shell.

#### Task 2: Test Cloud Shell

1. Run the following commands in the Cloud Shell and observe the output:

	```
	az --help
	```

	```
	az group --help
	```

	```
	az group create --help
	```

	```
	az group list --help
	```

> **Results**: After completing this exercise, you will have used the Azure Cloud Shell to interactively invoke commands using the Azure CLI.
