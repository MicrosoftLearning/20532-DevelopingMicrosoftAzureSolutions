# Module 3: Hosting Web Applications on the Azure Platform

# Demo: Autoscaling a Web App

1.  On the Start screen, click the **Internet Explorer** tile.

1.  Go to https://portal.azure.com.

1.  Enter the email address of your Microsoft account.

1.  Click **Continue**

1.  Enter the password for your Microsoft account.

1.  Click **Sign In**.

1.  At the lower-left corner of the screen, click **New**.

1.  In the **New** blade that displays, click the **Web App** option.

1.  In the **Web App** blade that displays, perform the following steps:

	a.  In the **URL** box, provide a unique name for your Web App.

	b.  Click **App Service Plan**.

	c.  In the **App Service Plan** blade, locate the **Name** box, and type **Autoscale**.

	d.  Locate and select the **S1 Standard** size option.

	e.  Click **OK**.

	f.  In the **Web App** blade, click **Create**.

1.  After the Web App is created, the new Web App blade will automatically appear.

1.  In the new blade that displays for your Web App, perform the following steps:

	a.  Click the **Settings** tile.

	b.  In the **Settings** blade, click **Scale**.

	c.  In the **Scale** blade, select the **Performance** option for the autoscale mode.

	d.  Set the **Instance Range** to a minimum value of **2** and a maximum value of **5**.

	e.  Set the **CPU Percentage** threshold to a minimum value of **50** and a maximum value of **70**.

	f.  Click save at the top of the blade.

1.  Close **Internet Explorer**.
