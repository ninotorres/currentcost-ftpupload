**Current Cost FTP software v1.0**
**Installation and configuration Guide**

Released under GPLv3 – www.gnu.org/licenses/gpl.html

This software is designed to work with the Current Cost electricity monitors. Before running the software, you need to have the monitor setup and connected to your Computer with a USB to Serial converter lead and the correct driver installed for your OS.
You can download the drivers at http://www.currentcost.com/software-downloads.html

Once the OS has identified the equipment as being plugged in, you can run the software.

**Installation**

There are three files contained within the zip file you downloaded from our development site (http://code.google.com/p/currentcost-ftpupload/), this read me, the executable and a configuration file. The source code is also available as a Visual Studio 2008 solution which you can build yourself.

In order to run, place the files into a folder (c:\cc for example) and then run the executable. There is no installation routine and nothing is entered into the registry or the Windows Add/Remove programs list.

**Configuration**

When started for the first time, it will ask you for your 8 digit configuration code. This was sent to you in an email when you signed up for an account at http://home-energy.meniscus.co.uk/ and is used to assign your data to your own site within the dashboard database. You can enter anything you like at this point as you can change it later, but unless you enter a valid code, you wont get to see the data displayed!

You can view your data from http://dashboard.meniscus.co.uk/current-cost.html using the email address you signed up with and the password you chose at that time.

Once you have entered you 8 digit code, it will ask you how many readings your want to send in a batch. It is recommended that you send them in groups of 20, which equates to every 2 minutes. You can change this as you see fit, but we put a lower limit of 10 on in order to reduce the number of files somewhat.

You can now see the screen showing you this batch number and you config code – both of which can be edited at any time you are not collecting data.

If the Port setting section, you should see the newly added com port from the installation of the driver – it defaults to the last com port in the list, so if this is not correct, select the correct port from the drop down. The only other selectable value is the Baud Rate. If you are using the cc128 – currently the most recent model, it uses 57600 as the baud rate. If you have an older model, you can select slower rates from the drop down (The old white model is 2400 for instance).

**Running the CurrentCostFTP software**

Once you are happy with the setting, click on the “Open Port” button. If everything is correct, you will see “Line 1 received” appear in the text area within 6 seconds. This will then continue until your batch number has been reached at which point it will try to send the file. This will clear the text area and write File uploaded with the file name and path following it. You will notice a temp folder has been created (\temp) in the folder you ran the current cost from. This folder will hold the file created whilst it is uploaded. If there is any ftp problem, the file will remain here and each time you create a new file, all existing files will try to be resent via ftp to the Dashboard server.
This can now be left running as long as you wish. If you minimise the application it will just leave a lightning bolt icon in the system tray on your start bar.

If you have any issues or problems, please send us a message using our contact page (http://home-energy.meniscus.co.uk/contact_meniscus.aspx) and we will try to help!