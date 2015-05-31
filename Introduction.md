# Introduction to the Ubuntu version #

This application is designed to upload data from a Current Cost meter to an ftp site. It includes the setting up and operation of a daemon to automatically poll the meter. There is a logging facility to track connections made to the ftp site and the batching up of readings. This batching facility allows the user to set the number of raw readings to include in each data file. The aplication automatically creates a new batch if the data changes to ensure that each file only has raw data for the one day.

Each file is named with a configurable name followed by the date and time stamp that the data was uploaded.

There are 5 files for the application:
  * cc.cfg -  Configuration file
  * ccdaemon.py - When run as a daemon this module is the interface to start, stop and restart the process
  * daemon.py - This module implements teh daemon process
  * currcost.py - Implementation file. Connects to the Current Cost meter and to the FTP site. Creates a temporary file, writes the XML header, batches the data and writes the temporary file to the ftp server
  * loggerconfig.py - Set up the python logging system. This file grows without restriction
Format of the Configuration file
```
  [CurrentCostMeter] 
  port: /dev/ttyUSB0 
  baud: 57600 
  bytesize: 8 
  parity: N 
  stopbits: 1 
  timeout: 3 

  [Upload] 
  host: Enter FTP address
  user: Enter FTP username
  password: Enter FTP password
  file: Enter the Unique Number we mail you in here
  tmp: samples.dat 
  datapath:  <Enter the name for the data folder - part of the CurrentCost download> i.e. /home/meniscus/CurrentCostClient/data
  batch: 20 (number of readings to batch together)
```