﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Minecraft_Backup_Manager
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public string filePath { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Path.GetFileName(filePath) != txtBackupName.Text)
            {
                string fileName = Path.GetFileName(filePath);
                int indexOfFirstDash = fileName.IndexOf('-');
                string everythingButBackupName = fileName.Substring(indexOfFirstDash);
                string newName = txtBackupName.Text + everythingButBackupName;
                File.Move(filePath, Path.GetDirectoryName(filePath) + "/" + newName);
            }

            Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            lblBackupFileName.Text = Path.GetFileName(filePath);
            string backupName = Path.GetFileName(filePath).Split('-')[0];
            txtBackupName.Text = backupName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
