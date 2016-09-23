# Module 3: Hosting Web Applications on the Azure Platform

# Demo: Autoscaling a Web App

1.  On the Start screen, click the **Internet Explorer** tile.

1.  Go to https://portal.azure.com.

1.  Enter the email address of your Microsoft account.

1.  Click **Continue**

1.  Enter the password for your Microsoft account.

1.  Click **Sign In**.

1.  At the top-left corner of the screen, click **New**.

1.  In the **New** blade that displays, click **Web + Mobile**.

1.	In the **Web + Mobile** blade that displays, click **Web App**.

1.  In the **Web App** blade that displays, do the following:

	a.  In the **App name** dialog box, provide a unique name for your Web App.

	b.  Click **App Service plan/Location** option.

	c.  In the **App Service plan** blade, click the **Create New** option.

	d.	In the new **App Service plan** blade, locate the **App Service plan** box, and type **Autoscale**.

	e.	Click the **Pricing tier** option.

	f.  In the **Choose your pricing tier** blade, locate and select the **S1 Standard** size option.

	g.	Click the **Select** button.

	h.	In the **App Service plan** blade, click the **OK** button.

	i. 	In the **Web App** blade, locate the **Resource Group** section.

	j.	In the **Resource Group** section, locate the **Create new** radio button and select it.

	k. 	In the **Resource Group** section, locate the dialog box and enter **20532Autoscale** as the name of the *Resource Group*.

	l.  In the **Web App** blade, click **Create**.

1.  After the Web App is created, click the **More services** link in the left navigation bar.

1.	Click the **App Services** option.

1.	Locate and click the **Web App** item in the list that you just created to open the app's blade.

1.  In the new blade that displays for your Web App, perform the following steps:

	a.  In the **Settings** section to the left of the blade, click the **Scale out (App Service plan)** option.

	c.  In the **Scale setting** blade, select the **CPU Percentage** option for the **Scale by** option.

	d.  Set the **Instances** to a minimum value of **2** and a maximum value of **5**.

	e.  Set the **Target range** threshold to a minimum value of **50** and a maximum value of **70**.

	f.  Click the **Save** button at the top of the blade.

1.  Close **Internet Explorer**.
