# Module 3: Hosting Web Applications on the Azure Platform

# Demo: Contoso Events Walkthrough

1.	On the Start screen, seach for and click the **Microsoft Azure Storage Emulator** application to start the application.

1.	On the Start screen, seach for and click the **Azure Cosmos DB Emulator** application to start the application.

    > **Note**: Wait for both emulators to start and be at a "ready" state before continuing with this demo.

1. On the Start screen, click the **Desktop** tile.

1. On the taskbar, click the **File Explorer** icon.

1. In the *This PC* window, go to **Allfiles (F):\\Mod07\\Labfiles\\Starter**, and then double-click **Contoso.Events.sln** to open the solution in Visual Studio.

1. In the **Solution Explorer** pane, right-click the **Contoso.Events** solution, and then click **Properties**.

1. Navigate to the **Startup Project** section located under the **Common Properties** header.

1. In the **Startup Project** section, locate and select the **Multiple startup projects** option.

1. Within the **Multiple startup projects** table, perform the following actions:

    b. Locate the **Contoso.Events.Management** entry and change it's *Action* from **None** to **Start**.

    c. Locate the **Contoso.Events.Worker** entry and change it's *Action* from **None** to **Start**.

1. Click the **OK** button to close the *Property* dialog.

1. On the **Debug** menu, click **Start Debugging**.

1. Locate the browser window showing the **Contoso Events** web application. This browser window will have a blue navigation bar.

1. On the home page of the web application, verify that it displays a list of events.

1. Click any one of the events to go to the event details webpage.

1. View the selected event details.

1. To go to the event’s registration page, click **Register Now**.

1. Ensure that every blank field in the registration form has a value.

1. Click the **Submit** button.

1. Click the **Go back to Events List** buton.

1. Locate the browser window showing the **Contoso Events Administration** web application. This browser window will have a red navigation bar.

1. Select the same event that you registered for previously with the **Contoso Events** web application.

1. Click the **Generate Sign-In Sheet** button.

1. The next page will show the following message: **Sign-In Document Generation In Progress**

1. Locate the console window showing the **Azure Functions** runtime. Wait for the function to detect your request to generate a sign-in sheet and complete the generation of that document.

1. Return to the browser window showing the **Contoso Events Administration** web application. Refresh the web page.

1. You should now see a section titled **Sign-In Document Already Exists**. This indicates that the sign-in document was generated successfully.

1. Click either link to download the generated sign-in document.

1. Observe the names listed in the sign-in sheet using the local **WordPad** editor.

1. Close the **Internet Explorer** application.

1. Close the **Visual Studio** application.