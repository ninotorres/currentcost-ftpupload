**This application uploads data from a Current Cost meter to a nominated FTP site so that you can track your electricity use in real time.**

If sent to the Meniscus site then once registered with us (this is free) you can view the data through a Microsoft Silverlight dashboard - this is not part of this Project but can be found at http://home-energy.meniscus.co.uk . We carry out a range of real time processing of the data to help you analyse your electricity use and cost.

You can see an example of the Dashboard at http://dashboard.meniscus.co.uk/home-energy.html or if you do not have Microsoft Silverlight installed then there is a <a href='http://home-energy.meniscus.co.uk/flash/Home%20Energy%20Dashboard.htm'>video here</a>

The application lets you 'batch' up a number of readings to reduce the frequency of upload. This batch is automatically truncated at the end of the day to prevent files having different date stamps. The application also lets you set up a unique identifier for your Current Cost meter that forms part of the file name.

Code is available for both the Windows and Linux (Ubuntu) operating systems.

For Windows then we have a standalone and a Windows Service version of the code. With the standalone version you have to start the application each time you want to upload data - but you have a application interface to see what is going on. With the Windows Service then the application starts automatically when your PC starts. Both applications have a User Interface that lets you test your connection to the Current Cost to make sure COM ports and the like are set correctly and start sending data up to our servers.

You can set up one free account for each e-mail address that you use.

Please check our forums for more information & help - http://home-energy.meniscus.co.uk/forums
