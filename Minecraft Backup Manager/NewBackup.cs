using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;

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
            CheckIfReady();
        }

        private void cmbPlatform_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedItemString = cmbPlatform.SelectedItem.ToString();
            if (selectedItemString != "")
            {
                if (selectedItemString == "Bedrock")
                {
                    txtSavesLocation.Text = Properties.Settings.Default.BedrockSavesLocation;
                    LoadSaves();
                }
                else if (selectedItemString == "Java")
                {
                    txtSavesLocation.Text = Properties.Settings.Default.JavaSavesLocation;
                    LoadSaves();
                }
            }

            CheckIfReady();
        }

        private void txtSavesLocation_TextChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }

        private void txtBackupLocation_TextChanged(object sender, EventArgs e)
        {
            CheckIfReady();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cmbPlatform.Text != "Java" && cmbPlatform.Text != "Bedrock")
            {
                MessageBox.Show("Platform is invalid, must be 'Java' or 'Bedrock'.");
            }
            else if (txtBackupName.Text.Contains('-'))
            {
                MessageBox.Show("The backup name cannot contain a '-'.");
            }
            else
            {
                //Are all items ticked?
                if (cblSaves.Items.Count != cblSaves.CheckedItems.Count)
                {
                    //No
                    CreatingBackup creatingBackup = new CreatingBackup();
                    creatingBackup.Show();
                    string[] checkedSaves = cblSaves.CheckedItems.OfType<string>().ToArray();
                    BackupSaves(txtBackupName.Text, cmbPlatform.SelectedItem.ToString(), txtSavesLocation.Text, txtBackupLocation.Text, checkedSaves);
                    creatingBackup.allowClose = true;
                    creatingBackup.Close();
                }
                else
                {
                    //Yes
                    CreatingBackup creatingBackup = new CreatingBackup();
                    creatingBackup.Show();
                    BackupSaves(txtBackupName.Text, cmbPlatform.SelectedItem.ToString(), txtSavesLocation.Text, txtBackupLocation.Text);
                    creatingBackup.allowClose = true;
                    creatingBackup.Close();
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void BackupSaves(string backupName, string platformType, string savesLocation, string backupLocation, string[] savesToBackup = null)
        {
            string timeDate = DateTime.Now.ToString("MM;dd;yyyy#HH;mm");
            string zipFileName = backupName + "-" + timeDate + "-" + platformType + "-MCBackup.zip";
            string zipFileLocation = backupLocation + "/" + zipFileName;

            //Backing up all saves in folder?
            if (savesToBackup == null)
            {
                //Yes
                ZipFile.CreateFromDirectory(savesLocation, zipFileLocation);
            }
            else
            {
                //No
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
                    Directory.Delete(backupLocation + "/temp/", true);
                }
                else if (platformType == "Bedrock")
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
                    Directory.Delete(backupLocation + "/temp/");
                }
            }
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
            if (fbdSavesLocation.ShowDialog() == DialogResult.OK)
            {
                txtSavesLocation.Text = fbdSavesLocation.SelectedPath;
            }
        }

        private void btnChangeBackupLocation_Click(object sender, EventArgs e)
        {
            if (fbdBackupLocation.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = fbdBackupLocation.SelectedPath;
            }
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
            else if (cmbPlatform.SelectedItem.ToString() == "Bedrock")
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

        private void frmNewBackup_Load(object sender, EventArgs e)
        {
            txtBackupLocation.Text = Properties.Settings.Default.BackupLocation;
        }

        private void CheckIfReady()
        {
            bool isReady = true;

            if (txtBackupName.Text == "")
            {
                isReady = false;
            }
            else if (cmbPlatform.Text == "")
            {
                isReady = false;
            }
            else if (txtSavesLocation.Text == "")
            {
                isReady = false;
            }
            else if (txtBackupLocation.Text == "")
            {
                isReady = false;
            }

            btnEnter.Enabled = isReady;
        }
    }
}
