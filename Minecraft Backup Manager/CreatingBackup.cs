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
    public partial class CreatingBackup : Form
    {
        public CreatingBackup()
        {
            InitializeComponent();
        }

        public bool allowClose { get; set; } = false;

        private void CreatingBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                e.Cancel = true;
            }
        }
    }
}
