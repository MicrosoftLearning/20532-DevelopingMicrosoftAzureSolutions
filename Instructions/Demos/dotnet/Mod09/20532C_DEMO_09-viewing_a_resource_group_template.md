# Module 9: Automating Integration with Azure Resources

# Demo: Viewing a Resource Group Template

1.  On the Start screen, click the down arrow to view all the applications, and then click **Windows PowerShell**.

1.  Switch to the **Windows PowerShell** console window.

1.  To switch to the **Azure Resource Manager** modules, type the following command in the console, and then press Enter:

	```
	Switch-AzureMode AzureResourceManager
	```

1.  To sign in to Azure, type the following command in the console, and then press Enter:

	```
	Add-AzureAccount
	```

1.  In the **Sign in to Windows Azure** dialog box, perform the following steps:

	a.  Enter the email address of your Microsoft account.

	b.  Click **Continue**.

	c.  Enter the password for your Microsoft account.

	d.  Click **Sign In**.

1.  To view the list of resource group templates, type the following command in the console, and then press Enter:

	```
	Get-AzureResourceGroupGalleryTemplate
	```

1.  To view the description of the resource group template, type the following command in the console, and then press Enter:

	```
	Get-AzureResourceGroupGalleryTemplate -Identity MSOpenTech.OracleDatabase12candWebLogicServer12cSE.0.2.9-preview
	```

1.  To download the resource group template, type the following command in the console, and then press Enter:

	```
	Save-AzureResourceGroupGalleryTemplate -Identity MSOpenTech.OracleDatabase12candWebLogicServer12cSE.0.2.9-preview -Path F:\Mod11\Demofiles
	```

1.  On the Start screen, click the **Desktop** tile.

1.  On the taskbar, click the **File Explorer** icon.

1.  In the Libraries window, go to **Allfiles (F):\\Mod11\\Demofiles**, and then view the content of the JSON file: **MSOpenTech.OracleDatabase12candWebLogicServer12cSE.0.2.9-preview.json**.

	> You can use either Visual Studio 2013 or Notepad to view the content of the JSON file.

1.  Close the **Microsoft Azure PowerShell** console window.
