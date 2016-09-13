# Module 3: Hosting Web Applications on the Azure Platform

# Demo: Managing Application Settings

1.  On the Start screen, click the **Internet Explorer** tile.

1.  Go to https://portal.azure.com.

1.  Enter the email address of your Microsoft account.

1.  Click **Continue**.

1.  Enter the password for your Microsoft account.

1.  Click **Sign In**.

1.  At the top-left corner of the screen, click **New**.

1.  In the **New** blade that displays, click **Web + Mobile**.

1.	In the **Web + Mobile** blade that displays, click **Web App**.

1.  In the **Web App** blade that displays, do the following:

	a.  In the **App name** dialog box, provide a unique name for your Web App.

	b. 	In the **Resource Group** section, locate the **Create new** radio button and select it.

	c. 	In the **Resource Group** section, locate the dialog box and enter **20532WebApp** as the name of the *Resource Group*.

	d.  Click **Create**.

1.  After the Web App is created, the new Web App blade will automatically open.

1.  In the new blade that displays for your Web App, perform the following steps:

	a.  Click the **Settings** button at the top of the blade.

	b.  In the **Settings** section, click the **Application Settings** option.

	c.  Locate the **Connection strings** section, and then add a connection string using the **Name** *entrycount* and the **Value** *8*.

	d.  Locate the **App settings** section, and add an app setting using the **Key** *externaldatabase* and the **Value** *URL=http://dataService;Data Format=JSON;Auto Cache=true;*.

	e.  Click the **SAVE** button at the top of the blade.

1.  Close **Internet Explorer**.
