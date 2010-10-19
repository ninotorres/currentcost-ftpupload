using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Net;
using System.Configuration;

/***********************************************************************
 * Written by Jason Ward - Meniscus Systems Ltd
 * Released under GPLv3 - http://www.gnu.org/licenses/gpl.html
 * 
 * Please direct any comments to jward@meniscus.co.uk
 * Still learning c# so any tips always appreciated too!
 * 
 * Credit for the inputbox to Les Smith :-
 * http://www.knowdotnet.com/articles/inputbox.html
 * 
 * Written using VS2008 - August 2010
 *********************************************************************** */

namespace CurrentCost_Ftp
{
    public partial class Main : Form
    {
        Configuration Config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

        string[] ports;
        bool fail;
        SerialPort sp;

        string tempPath;

        string meterAlias;
        string batchNo;

        DataTable xmlStream;
        DataRow xmlRow;

        int IOfails = 0;

        string ftpServerIP;
        string ftpUserID;
        string ftpPassword;

        int linesCollected = 0;
        int linesPerFile = 20;

        int linesRead = 0;
        int filesSent = 0;

         
        public Main()
        {
            InitializeComponent();

            meterAlias = Config.AppSettings.Settings["ConfigCode"].Value.ToString();
            batchNo = Config.AppSettings.Settings["BatchNumber"].Value.ToString();
            ftpServerIP = Config.AppSettings.Settings["ftpServerIP"].Value.ToString();
            ftpUserID = Config.AppSettings.Settings["ftpUserID"].Value.ToString();
            ftpPassword = Config.AppSettings.Settings["ftpPassword"].Value.ToString();
            
            if (meterAlias == "")
            {
                MessageBox.Show("Please ensure that the Windows USB driver for the Current Cost lead is installed and the Meter is on and connected to the PC");
                fail = true;
                do
                {
                    meterAlias = InputBox("Please enter your 8 digit config code you were sent when signing up to the Meniscus Current Cost Website.  If you do not have it, enter any 8 characters as you can change it later", "Please Enter your config code", "");
                    if (meterAlias.Length == 8)
                    {
                        Config.AppSettings.Settings["ConfigCode"].Value = meterAlias;
                        Config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        fail = false;
                    }
                    else
                    {
                        MessageBox.Show("Please enter the 8 character config code you were sent.");
                    }
                } while (fail);
            }
            if (batchNo == "")
            {
                fail = true;
                do
                {
                    batchNo = InputBox("How many readings do you want to batch together before uploading (min 10)? ", "Batch Number", "20");
                    try
                    {
                        linesPerFile = Convert.ToInt16(batchNo);
                        if (linesPerFile < 10) { linesPerFile = 10; } 
                        Config.AppSettings.Settings["BatchNumber"].Value = batchNo;
                        Config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");
                        fail = false;
                    }
                    catch
                    {
                        MessageBox.Show("Please enter a number");
                    }
                } while (fail==true);
            }
            else
            {
                linesPerFile = Convert.ToInt16(batchNo);
            }
            txtBatch.Text = linesPerFile.ToString();
            txtCode.Text = meterAlias;
            //Set Temp Folder
            tempPath = Application.StartupPath + "\\temp";
            if (!System.IO.Directory.Exists(tempPath))
            {
                System.IO.Directory.CreateDirectory(tempPath);
            }

            ports = SerialPort.GetPortNames();
            foreach (string t in ports)
            {
                selPort.Items.Add(t);
            }
            selPort.SelectedIndex = selPort.Items.Count - 1;

            //setup results table
            xmlStream = new DataTable();
            xmlStream.Columns.Add("xmlInput", typeof(String));

            //Add a handler for minimising the application
            this.Resize += new EventHandler(Main_Resize);
            this.FormClosing += new FormClosingEventHandler(Main_FormClosing);
        }

        void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            stIcon.Dispose();
        }

        void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            Hide();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (selPort.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please Select a valid Com port");
                return;
            }
            //Open the port with the settings selected
            sp = new SerialPort(selPort.SelectedItem.ToString(), Convert.ToInt32(selBaud.SelectedItem), Parity.None, 8, StopBits.One);
            sp.ReadBufferSize = 4096;

            sp.Open();
            rtbDisplay.AppendText(selPort.SelectedItem.ToString() + " port opened" + "\n");

            btnChangeCode.Enabled = false;
            btnOpenPort.Enabled = false;
            btnClosePort.Enabled = true;
            btnExit.Enabled = false;

            //Our events to handle data being received
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataRecieved);
            //sp.ErrorReceived += new SerialErrorReceivedEventHandler(sp_ErrorRecieved);
        }

        private void sp_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
        }

        private void sp_ErrorRecieved(object sender, SerialErrorReceivedEventArgs e)
        {
            //You could add error trapping for a receive error in here and un-comment the event handler for it
        }

        private void DoUpdate(object s, EventArgs e)
        {
            try
            {
                string sp_data = sp.ReadLine();
                linesRead++;
                linesCollected++;
                txtLinesRead.Text = linesRead.ToString();
                xmlRow = xmlStream.NewRow();
                xmlRow["xmlInput"] = sp_data;
                xmlStream.Rows.Add(xmlRow);
                rtbDisplay.AppendText("Line " + (linesCollected).ToString() + " received" + "\n");
                
                if (linesCollected == linesPerFile)
                {
                    linesCollected = 0;
                    rtbDisplay.Clear();
                    Write_file();
                    Upload();
                }
            }
            catch
            {
                //Due to the fact we get data every 6 seconds, we ignore errors here and simply process the next line
            }
        }

        private void Write_file()
        {
            string tFileName = tempPath + @"\" + meterAlias + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            TextWriter tw = new StreamWriter(@tFileName);
            foreach (DataRow dr in xmlStream.Rows)
            {
                tw.WriteLine(dr["xmlInput"].ToString());
            }
            tw.Close();
            xmlStream.Clear();
        }

        private void Upload()
        {
            //We look at the folder contents to allow us to resend files that may have failed
            //or where sent when the ftp was unavailable etc
            string[] fileEntries = Directory.GetFiles(tempPath, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string fileName in fileEntries)
            {
                Upload_file(fileName);
                rtbDisplay.AppendText("File uploaded - " + fileName + "\n");
            }
        }

        private void Upload_file(string filename)
    {
        FileInfo fileInf = new FileInfo(filename);
        string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
        FtpWebRequest reqFTP;
        reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
        reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        reqFTP.KeepAlive = false;
        reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
        reqFTP.UseBinary = true;
        reqFTP.ContentLength = fileInf.Length;
        reqFTP.UsePassive = true;

        try
        {
            int buffLength = 2048;
            Stream ftpStream = reqFTP.GetRequestStream();
            FileStream fs = fileInf.OpenRead();
            byte[] buff = new byte[buffLength];


            int bytesread = 0;

            do
            {
                bytesread = fs.Read(buff, 0, buffLength);
                ftpStream.Write(buff, 0, bytesread);
            }
            while (bytesread != 0);

            fs.Close();
            ftpStream.Close();

            filesSent++;
            txtFilesSent.Text = filesSent.ToString();

            //Delete the file
            fileInf.Delete();
        }
        catch 
        {
            IOfails++;
            txtIOfails.Text = IOfails.ToString();
        }
    }

        private void txtBatch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                linesPerFile = Convert.ToInt16(txtBatch.Text);
                Config.AppSettings.Settings["BatchNumber"].Value = txtBatch.Text;
                Config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            {
                MessageBox.Show("Batch Number must be a number");
            }
        }

        private void stIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                BringToFront();
                Show();
                WindowState = FormWindowState.Normal;
            }
            else
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnChangeCode_Click(object sender, EventArgs e)
        {
            fail = true;
            do
            {
                meterAlias = InputBox("Enter your 8 digit config code", "Please Enter your config code", "");
                if (meterAlias.Length == 8)
                {
                    Config.AppSettings.Settings["ConfigCode"].Value = meterAlias;
                    Config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    fail = false;
                }
                else
                {
                    MessageBox.Show("Please enter the 8 character config code you were sent.");
                }
            } while (fail);
            txtCode.Text = meterAlias;
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            sp.DataReceived -= new SerialDataReceivedEventHandler(sp_DataRecieved);
            sp.ErrorReceived -= new SerialErrorReceivedEventHandler(sp_ErrorRecieved);
            sp.Close();
            btnChangeCode.Enabled = true;
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
            btnExit.Enabled = true;
            rtbDisplay.AppendText(selPort.SelectedItem.ToString() + " port closed" + "\n");
        }

        public static string InputBox(string prompt, string title, string defaultValue)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = prompt;
            ib.FormCaption = title;
            ib.DefaultValue = defaultValue;
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
