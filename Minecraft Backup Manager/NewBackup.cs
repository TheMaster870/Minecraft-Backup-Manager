using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Minecraft_Backup_Manager
{
    public partial class frmNewBackup : Form
    {
        public frmNewBackup()
        {
            InitializeComponent();
        }

        private void txtBackupName_TextChanged(object sender, EventArgs e)
        {
            if (txtBackupName.Text != "")
            {
                cmbPlatform.Enabled = true;
            }
        }

        private void cmbPlatform_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPlatform.SelectedItem.ToString() != "")
            {
                if (cmbPlatform.SelectedItem.ToString() == "Bedrock")
                {
                    txtSavesLocation.Text = Properties.Settings.Default.BedrockSavesLocation;
                }
                else
                {
                    txtSavesLocation.Text = Properties.Settings.Default.JavaSavesLocation;
                }

                txtSavesLocation.Enabled = true;
                btnChangeSavesLocation.Enabled = true;

                LoadSaves();
            }
        }

        private void txtSavesLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtSavesLocation.Text != "")
            {
                txtBackupLocation.Text = Properties.Settings.Default.BackupLocation;
                txtBackupLocation.Enabled = true;
                btnChangeBackupLocation.Enabled = true;
            }
        }

        private void txtBackupLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text != "")
            {
                btnEnter.Enabled = true;
                cblSaves.Enabled = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cblSaves.Items.Count != cblSaves.CheckedItems.Count)
            {
                string[] checkedSaves = cblSaves.CheckedItems.OfType<string>().ToArray();
                BackupSaves(txtBackupName.Text, cmbPlatform.SelectedItem.ToString(), txtSavesLocation.Text, txtBackupLocation.Text, checkedSaves);
            }
            else
            {
                BackupSaves(txtBackupName.Text, cmbPlatform.SelectedItem.ToString(), txtSavesLocation.Text, txtBackupLocation.Text);
            }

            
            DialogResult = DialogResult.OK;
        }

        private bool BackupSaves(string backupName, string platformType, string savesLocation, string backupLocation, string[] savesToBackup = null)
        {
            string timeDate = DateTime.Now.ToString("MM;dd;yyyy#HH;mm");
            string zipFileName = backupName + "-" + timeDate + "-" + platformType + "-MCBackup.zip";
            string zipFileLocation = backupLocation + "/" + zipFileName;

            if (savesToBackup == null)
            {
                ZipFile.CreateFromDirectory(savesLocation, zipFileLocation);
            }
            else
            {
                if (platformType == "Java")
                {
                    string[] foldersInFolder = Directory.GetDirectories(savesLocation);
                    foreach (string folder in foldersInFolder)
                    {
                        if (savesToBackup.Contains(Path.GetFileName(folder)))
                        {
                            Directory.CreateDirectory(backupLocation + "/temp/" + Path.GetFileName(folder));
                            CopyFilesRecursively(folder, backupLocation + "/temp/" + Path.GetFileName(folder));
                        }
                    }

                    ZipFile.CreateFromDirectory(backupLocation + "/temp/", zipFileLocation);
                }else if (platformType == "Bedrock")
                {
                    string[] foldersInFolder = Directory.GetDirectories(savesLocation);
                    foreach (string folder in foldersInFolder)
                    {
                        if (savesToBackup.Contains(File.ReadAllText(folder + "/levelname.txt")))
                        {
                            Directory.CreateDirectory(backupLocation + "/temp/" + Path.GetFileName(folder));
                            CopyFilesRecursively(folder, backupLocation + "/temp/" + Path.GetFileName(folder));
                        }
                    }

                    ZipFile.CreateFromDirectory(backupLocation + "/temp/", zipFileLocation);
                }
            }

            

            return true;
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnChangeSavesLocation_Click(object sender, EventArgs e)
        {
            fbdSavesLocation.ShowDialog();
            txtSavesLocation.Text = fbdSavesLocation.SelectedPath;
        }

        private void btnChangeBackupLocation_Click(object sender, EventArgs e)
        {
            fbdBackupLocation.ShowDialog();
            txtBackupLocation.Text = fbdBackupLocation.SelectedPath;
        }

        private void LoadSaves()
        {
            string savesLocation = txtSavesLocation.Text;

            if (cmbPlatform.SelectedItem.ToString() == "Java")
            {
                string[] foldersInFolder = Directory.GetDirectories(savesLocation);
                cblSaves.Items.Clear();
                foreach (string folder in foldersInFolder)
                {
                    cblSaves.Items.Add(Path.GetFileName(folder), true);
                }
            }
            else
            {
                string[] foldersInFolder = Directory.GetDirectories(savesLocation);
                cblSaves.Items.Clear();
                foreach (string folder in foldersInFolder)
                {
                    string worldName = File.ReadAllText(folder + @"\levelname.txt");
                    cblSaves.Items.Add(worldName, true);
                }
            }
        }
    }
}
