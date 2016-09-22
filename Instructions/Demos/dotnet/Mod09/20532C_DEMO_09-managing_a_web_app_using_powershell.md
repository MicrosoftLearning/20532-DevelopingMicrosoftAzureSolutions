# Module 9: Automating Integration with Azure Resources

# Demo: Managing a Web App Using PowerShell

1.  On the Windows Start screen, click the down arrow to view all the applications, and then click **Windows PowerShell**.

1.  Switch to the **Windows PowerShell** console window.

1.  To sign in to Azure, type the following command in the console, and then press Enter:

	```
	Add-AzureAccount
	```

	> **Note:** If you have not used *Windows PowerShell* before, you may be prompted to allow PowerShell to collect usage data. You can safely skip this dialog.

1.  In the **Sign in to your account** dialog box, perform the following steps:

	a.  Enter the email address of your Microsoft account..

	b.  Click **Continue**.

	c.  Enter the password for your Microsoft account.

	d.  Click **Sign In**.

1.  To view your account details, type the following command in the console, and the press Enter:

	```
	Get-AzureAccount
	```

1.  To get your publish settings file, type the following command in the console, and then press Enter:

	```
	Get-AzurePublishSettingsFile
	```

1.  In the **Internet Explorer** tab that opens, perform the following steps:

	a.  Enter the email address of your Microsoft account.

	b.  Click **Continue**.

	c.  Enter the password for your Microsoft account.

	d.  Click **Sign In**.

	e.  At the bottom of the Internet Explorer window, click the arrow that is on the right side of the **Save** button, and then click **Save As** in the download dialog box.

1.  In the **Save As** dialog box that displays, perform the following steps:

	a.  Go to the **AllFiles (F):\\Mod09\\Demofiles** folder.

	b.  In the **File Name** box, type **20532**.

	c.  In the **Save as type** box, ensure that the **PUBLISHSETTINGS File** option is selected.

	d.  Click **Save**.

1.  Close Internet Explorer.

1.  Switch to the **Windows PowerShell** console window.

1.  To import your publish settings file, type the following command in the console, and then press Enter:

	```
	Import-AzurePublishSettingsFile F:\Mod09\Demofiles\20532.publishsettings
	```

1.  To view any available account details (there might be none), type the following command in the console, and then press Enter:

	```
	Get-AzureAccount
	```

1.  To create a new Website, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

	```
	New-AzureWebsite [Unique Name]
	```

	> You might get an error message notifying you that your Website’s name is not unique. If this occurs, select a new name until your Website is created.

1.  To view the list of Websites, type the following command in the console, and then press Enter:

	```
	Get-AzureWebsite
	```

1.  To view the details for your new Website, type the following command in the console by providing the unique name selected for your website, and then press Enter:

	```
	Get-AzureWebsite –Name [Unique Name]
	```

1.  To stop your new Website, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

	```
	Stop-AzureWebsite –Name [Unique Name]
	```

1.  To view the list of your Websites, type the following command in the console, and press Enter:

	```
	Get-AzureWebsite
	```

1.  To remove your new Website, type the following command in the console by providing the unique name selected for your Website, and then press Enter:

	```
	Remove-AzureWebsite –Name [Unique Name]
	```

1.  Type **Y** to indicate that you want to remove the Website, and then press Enter.

1.  To verify that your Website is removed, type the following command in the console by providing the unique name selected for your Website, and then press Enter. The result should be empty:

	```
	Get-AzureWebsite –Name [Unique Name]
	```

1.  Close the **Windows PowerShell** console window.
