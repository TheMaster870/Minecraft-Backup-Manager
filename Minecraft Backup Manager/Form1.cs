using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Backup_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool allSettingsSet = false;

            while (allSettingsSet == false)
            {
                string message = "";
                if (Properties.Settings.Default.BackupLocation == "")
                {
                    message += "Default Backup Location Missing.\n";
                }
                if (Properties.Settings.Default.BedrockSavesLocation == "")
                {
                    message += "Default Bedrock Saves Location Missing.\n";
                }
                if (Properties.Settings.Default.JavaSavesLocation == "")
                {
                    message += "Default Java Saves Location Missing.\n";
                }

                if (message != "")
                {
                    MessageBox.Show(message);
                    frmOptions frmOptions = new frmOptions();
                    frmOptions.ShowDialog();
                    if (frmOptions.DialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    allSettingsSet = true;
                }
            }

            RefreshBackupList();
        }

        private void btnNewBackup_Click(object sender, EventArgs e)
        {
            CreateNewBackup();
        }

        private void CreateNewBackup()
        {
            frmNewBackup frmNewBackup = new frmNewBackup();
            if (frmNewBackup.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Backup complete");
            }

            RefreshBackupList();
        }

        private void RefreshBackupList()
        {
            //Remove all current saves
            dataGridView1.Rows.Clear();

            //Get default backup location
            string backupsLocation = Properties.Settings.Default.BackupLocation;


            List<string> saveFileList = new List<string>();
            
            //Looks for any backup zips
            string[] allFilesInBackupLocation = Directory.GetFiles(backupsLocation);
            foreach (string file in allFilesInBackupLocation)
            {
                if (file.Contains("-MCBackup.zip"))
                {
                    saveFileList.Add(file);
                }
            }

            if (saveFileList.Count == 0)
            {
                //No backups found
                lblDataGridViewMessage.Visible = true;
                lblDataGridViewMessage.Text = "No backups found in folder: " + backupsLocation;
            }
            else
            {
                lblDataGridViewMessage.Visible = false;

                List<string[]> fileDetailsList = new List<string[]>();
                foreach (string filePath in saveFileList)
                {
                    //Splits up the file name into backup details
                    string fileName = Path.GetFileName(filePath);
                    string[] nameSplit = fileName.Split('-');
                    string fileBackupName = nameSplit[0];
                    string fileDate = nameSplit[1].Split('#')[0].Replace(';', '/');
                    string fileTime = nameSplit[1].Split('#')[1].Replace(';', ':');
                    string fileDateTime = fileDate + " " + fileTime;
                    string platformType = nameSplit[2];

                    string[] detailsArray = { filePath, fileBackupName, fileDateTime, platformType };

                    fileDetailsList.Add(detailsArray);
                }


                foreach (string[] file in fileDetailsList)
                {
                    //Add found backups to list on screen
                    dataGridView1.Rows.Add(file);
                }
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        private void OpenOptions()
        {
            frmOptions frmOptions = new frmOptions();
            frmOptions.ShowDialog();

            CheckSettingsPresent();

            RefreshBackupList();
        }

        private void CheckSettingsPresent()
        {
            bool allSettingsSet = false;

            while (allSettingsSet == false)
            {
                string message = "";
                if (Properties.Settings.Default.BackupLocation == "")
                {
                    message += "Default Backup Location Missing.\n";
                }

                if (Properties.Settings.Default.BedrockSavesLocation == "")
                {
                    message += "Default Bedrock Saves Location Missing.\n";
                }

                if (Properties.Settings.Default.JavaSavesLocation == "")
                {
                    message += "Default Java Saves Location Missing.\n";
                }

                if (message != "")
                {
                    //Setting(s) missing
                    MessageBox.Show(message);
                    frmOptions frmOptions = new frmOptions();
                    frmOptions.ShowDialog();
                }
                else
                {
                    allSettingsSet = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    //Edit button clicked
                    Edit editBackup = new Edit
                    {
                        filePath = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()
                    };
                    editBackup.ShowDialog();
                }
                else if (e.ColumnIndex == 5)
                {
                    //Delete button clicked
                    string filePath = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string fileName = Path.GetFileName(filePath);

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this backup?\n" + fileName, "Confirm Delete", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.Delete(filePath);
                    }
                }
                else if (e.ColumnIndex == 6)
                {
                    //Open button clicked
                    string filePath = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    System.Diagnostics.Process.Start(filePath);
                }
            }

            RefreshBackupList();
        }

        private void mtiNewBackup_Click(object sender, EventArgs e)
        {
            CreateNewBackup();
        }

        private void mtiExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mtiVersion_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void mtiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You work it out.");
        }
    }
}
