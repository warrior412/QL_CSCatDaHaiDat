using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Configuration;

namespace QL_CATDAHAIDAT
{
    public partial class BackUpForm : Form
    {

        public delegate void ShowPercentCompleteDelegate(int percent);
        public delegate void ShowMessageDelegate(string message);

        public BackUpForm()
        {
            InitializeComponent();
        }

        private void BackUpForm_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
        public void backupData(string dbName,string bkURL)
        {
            Server myServer = new Server();
            ////Using windows authentication
            //myServer.ConnectionContext.ConnectionString = Common.GetInstance().CurrentShop;
            //myServer.ConnectionContext.LoginSecure = true;
            //myServer.ConnectionContext.Connect();
            //////
            ////Do your work
            //////
            //if (myServer.ConnectionContext.IsOpen)
            //    myServer.ConnectionContext.Disconnect();
            //Using SQL Server authentication
            myServer.ConnectionContext.LoginSecure = false;
            myServer.ConnectionContext.ConnectionString = Common.GetInstance().CurrentShop;

            Backup bkpDBFull = new Backup();
            /* Specify whether you want to back up database or files or log */
            bkpDBFull.Action = BackupActionType.Database;
            /* Specify the name of the database to back up */
            bkpDBFull.Database = dbName;
            /* You can take backup on several media type (disk or tape), here I am
             * using File type and storing backup on the file system  @"D:\AdventureWorksFull.bak"*/
            bkpDBFull.Devices.AddDevice(bkURL, DeviceType.File);
            bkpDBFull.BackupSetName = "QLCatDaHaiDat database Backup";
            bkpDBFull.BackupSetDescription = "QLCatDaHaiDat database - Full Backup";
            /* You can specify the expiration date for your backup data
             * after that date backup data would not be relevant */
            bkpDBFull.ExpirationDate = DateTime.Today.AddDays(10);

            /* You can specify Initialize = false (default) to create a new 
             * backup set which will be appended as last backup set on the media. You
             * can specify Initialize = true to make the backup as first set on the
             * medium and to overwrite any other existing backup sets if the all the
             * backup sets have expired and specified backup set name matches with
             * the name on the medium */
            bkpDBFull.Initialize = false;

            /* Wiring up events for progress monitoring */
            bkpDBFull.PercentComplete += new PercentCompleteEventHandler(CompletionStatusInPercent);
            bkpDBFull.Complete += new ServerMessageEventHandler(Backup_Completed);

            /* SqlBackup method starts to take back up
             * You can also use SqlBackupAsync method to perform the backup 
             * operation asynchronously */
            bkpDBFull.SqlBackupAsync(myServer);
        }
        private void CompletionStatusInPercent(object sender, PercentCompleteEventArgs args)
        {
            object[] percent = new object[1];
            percent[0] = args.Percent;

            this.BeginInvoke(new ShowPercentCompleteDelegate(
              ShowPercentComplete), percent);
        }
        private void Backup_Completed(object sender, ServerMessageEventArgs args)
        {
            object[] message = new object[1];
            message[0] = args.Error.Message;

            this.BeginInvoke(
              new ShowMessageDelegate(ShowMessage), message);
        }

        public void ShowPercentComplete(int percent)
        {
            progressBar1.Value = percent;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
            progressBar1.Hide();
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string dbname = "";
            string bkURL = "";
            DateTime date = DateTime.Now;
            string filename = date.ToFileTime().ToString();
            if (Common.GetInstance().CurrentShop.Equals(ConfigurationManager.ConnectionStrings["QL_CATDAHAIDAT.Properties.Settings.DB_QLCatDaHaiDatConnectionString"].ConnectionString))
            {
                dbname = "DB_QLCatDaHaiDat";
                filename += "_haidat.bak";
            }
            else
            {
                dbname = "DB_QLCatDa";
                filename += "_baon.bak";
            }
            bkURL = textBox1.Text + @"\" + filename;
            progressBar1.Show();
            this.backupData(dbname, bkURL);
        }
    }
}
