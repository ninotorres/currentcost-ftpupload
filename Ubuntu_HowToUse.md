**This application has been tested and developed using Ubuntu 9.1**

  1. Install files in a new folder
  1. Right click on the file names ccdaemon.py. Goto the Permissions tab and make sure that the file has Execute permissions.
  1. Configure the cc.cfg file to include ftp logging details (version 1.1.1 on has these details already set up)
  1. If using the Meniscus service to present data in a Silverlight dashboard then enter create an account with Meniscus at http://home-energy.meniscus.co.uk/Default.aspx and enter the unique reference e-mailed to you into the cc.cfg file
  1. Open Terminal application
  1. Type gedit .bashrc and then enter the following command at the bottom of the file "export CURRENT\_COST\_HOME=/home/meniscus/CurrentClostClient" - or wherever you have installed the CurrentCost application. This command is required to allow Ubuntu to find and run the CurrentCost application
  1. Change directory to that created in 1 above using using the cd command
  1. ./ccdaemon.py start - this command starts the daemon
  1. ./ccdaemon.py stop - this command stops the daemon
  1. tail cclogging.log - this command shows the latest logging information

**Some of the features of the application**

  1. Version 1.2
    * Log files are limited to 4Mb each. Two files created and the first one is overwritten once the second reached the 4Mb limit.
    * Data files are now stored on the local machine in the CurrentCostClient/data directory if the ftp server is stopped. Files are automatically uploaded once the connection is re-established.

  1. Version 1.0
    * Each 6 second reading is batched into a file depending on the value set in the cc.cfg configuration file.
    * new files are automatically created in the middle of a batch period if the computer date switches i.e. at midnight.


**An example of the logging information**
```
2010-03-02 20:30:36,711 - cc.CCDaemon.run - -1216059712 - INFO  - Daemon running...
2010-03-02 20:30:36,734 - cc.CurrentCostUpload - -1216059712 - INFO  - CurrentCostUpload starting...
2010-03-02 20:30:36,760 - cc.CurrentCostUpload - -1216059712 - INFO  - Read/ Upload cycle starting...
2010-03-02 20:30:36,837 - cc.CurrentCostUpload - -1216059712 - INFO  - Connected to CurrentCost device
2010-03-02 20:30:37,226 - cc.CurrentCostUpload - -1216059712 - INFO  - Connected to FTP server
2010-03-02 20:30:57,992 - cc.CurrentCostUpload - -1216059712 - INFO  - Batch = 5
2010-03-02 20:31:16,425 - cc.CurrentCostUpload - -1216059712 - INFO  - Batch = 10
2010-03-02 20:31:34,985 - cc.CurrentCostUpload - -1216059712 - INFO  - Batch = 15
2010-03-02 20:31:53,415 - cc.CurrentCostUpload - -1216059712 - INFO  - Batch = 20
2010-03-02 20:31:54,112 - cc.CurrentCostUpload - -1216059712 - INFO  - Sent data to FTP server
```

**An example of the xml output file**
```
 <?xml version="1.0" ?> 
- <CurrentCostReadings date="30/03/2010">
-  <msg>
    <src>CC128-v0.12</src> 
    <dsb>00022</dsb> 
    <time>21:58:49</time> 
    <tmpr>24.5</tmpr> 
    <sensor>0</sensor> 
    <id>00077</id> 
    <type>1</type> 
- <ch1>
   <watts>00686</watts> 
</ch1>
- <ch2>
   <watts>00759</watts> 
</ch2>
</msg>
```