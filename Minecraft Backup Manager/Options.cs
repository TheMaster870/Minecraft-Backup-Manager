using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Backup_Manager
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BedrockSavesLocation == "")
            {
                txtBedrockLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds\";
            }
            else
            {
                txtBedrockLocation.Text = Properties.Settings.Default.BedrockSavesLocation;
            }

            if (Properties.Settings.Default.JavaSavesLocation == "")
            {
                txtJavaLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\saves\";
            }
            else
            {
                txtJavaLocation.Text = Properties.Settings.Default.JavaSavesLocation;
            }


            txtBackupLocation.Text = Properties.Settings.Default.BackupLocation;

            fbdBackupLocation.SelectedPath = Properties.Settings.Default.BackupLocation;
            fbdBedrockLocation.SelectedPath = Properties.Settings.Default.BedrockSavesLocation;
            fbdJavaLocation.SelectedPath = Properties.Settings.Default.JavaSavesLocation;
        }

        private void btnChangeBackupLocation_Click(object sender, EventArgs e)
        {
            fbdBackupLocation.SelectedPath = txtBackupLocation.Text;
            if (fbdBackupLocation.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = fbdBackupLocation.SelectedPath;
            }
        }

        private void btnChangeBedrockLocation_Click(object sender, EventArgs e)
        {
            fbdBedrockLocation.SelectedPath = txtBedrockLocation.Text;
            if (fbdBedrockLocation.ShowDialog() == DialogResult.OK)
            {
                txtBedrockLocation.Text = fbdBedrockLocation.SelectedPath;
            }
        }

        private void btnChangeJavaLocation_Click(object sender, EventArgs e)
        {
            if (fbdJavaLocation.ShowDialog() == DialogResult.OK)
            {
                txtJavaLocation.Text = fbdJavaLocation.SelectedPath;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupLocation = txtBackupLocation.Text;
            Properties.Settings.Default.BedrockSavesLocation = txtBedrockLocation.Text;
            Properties.Settings.Default.JavaSavesLocation = txtJavaLocation.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
