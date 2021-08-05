
namespace Minecraft_Backup_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewBackup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtiNewBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mtiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mtiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mtiVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblDataGridViewMessage = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditBackup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBackup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenBackup = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewBackup
            // 
            this.btnNewBackup.Location = new System.Drawing.Point(12, 41);
            this.btnNewBackup.Name = "btnNewBackup";
            this.btnNewBackup.Size = new System.Drawing.Size(101, 23);
            this.btnNewBackup.TabIndex = 0;
            this.btnNewBackup.Text = "New Backup";
            this.btnNewBackup.UseVisualStyleBackColor = true;
            this.btnNewBackup.Click += new System.EventHandler(this.btnNewBackup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mtiOptions,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtiNewBackup,
            this.toolStripSeparator1,
            this.mtiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mtiNewBackup
            // 
            this.mtiNewBackup.Name = "mtiNewBackup";
            this.mtiNewBackup.Size = new System.Drawing.Size(140, 22);
            this.mtiNewBackup.Text = "New Backup";
            this.mtiNewBackup.Click += new System.EventHandler(this.mtiNewBackup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // mtiExit
            // 
            this.mtiExit.Name = "mtiExit";
            this.mtiExit.Size = new System.Drawing.Size(140, 22);
            this.mtiExit.Text = "Exit";
            this.mtiExit.Click += new System.EventHandler(this.mtiExit_Click);
            // 
            // mtiOptions
            // 
            this.mtiOptions.Name = "mtiOptions";
            this.mtiOptions.Size = new System.Drawing.Size(61, 20);
            this.mtiOptions.Text = "Options";
            this.mtiOptions.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtiHelp,
            this.mtiVersion});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mtiHelp
            // 
            this.mtiHelp.Name = "mtiHelp";
            this.mtiHelp.Size = new System.Drawing.Size(112, 22);
            this.mtiHelp.Text = "Help";
            this.mtiHelp.Click += new System.EventHandler(this.mtiHelp_Click);
            // 
            // mtiVersion
            // 
            this.mtiVersion.Name = "mtiVersion";
            this.mtiVersion.Size = new System.Drawing.Size(112, 22);
            this.mtiVersion.Text = "Version";
            this.mtiVersion.Click += new System.EventHandler(this.mtiVersion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePath,
            this.BackupName,
            this.BackupDate,
            this.MCPlatform,
            this.EditBackup,
            this.DeleteBackup,
            this.OpenBackup});
            this.dataGridView1.Location = new System.Drawing.Point(132, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(881, 568);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(12, 70);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(101, 23);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lblDataGridViewMessage
            // 
            this.lblDataGridViewMessage.BackColor = System.Drawing.Color.DarkGray;
            this.lblDataGridViewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataGridViewMessage.Location = new System.Drawing.Point(171, 85);
            this.lblDataGridViewMessage.Name = "lblDataGridViewMessage";
            this.lblDataGridViewMessage.Size = new System.Drawing.Size(804, 57);
            this.lblDataGridViewMessage.TabIndex = 4;
            this.lblDataGridViewMessage.Text = "No backups found in folder: ";
            this.lblDataGridViewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDataGridViewMessage.Visible = false;
            // 
            // filePath
            // 
            this.filePath.HeaderText = "File Path";
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Visible = false;
            // 
            // BackupName
            // 
            this.BackupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BackupName.HeaderText = "Backup Name";
            this.BackupName.Name = "BackupName";
            this.BackupName.ReadOnly = true;
            // 
            // BackupDate
            // 
            this.BackupDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BackupDate.HeaderText = "Backup Date";
            this.BackupDate.Name = "BackupDate";
            this.BackupDate.ReadOnly = true;
            // 
            // MCPlatform
            // 
            this.MCPlatform.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MCPlatform.HeaderText = "MC Platform";
            this.MCPlatform.Name = "MCPlatform";
            this.MCPlatform.ReadOnly = true;
            // 
            // EditBackup
            // 
            this.EditBackup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditBackup.HeaderText = "Edit Backup";
            this.EditBackup.Name = "EditBackup";
            this.EditBackup.ReadOnly = true;
            this.EditBackup.Text = "Edit Backup";
            this.EditBackup.UseColumnTextForButtonValue = true;
            // 
            // DeleteBackup
            // 
            this.DeleteBackup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteBackup.HeaderText = "Delete Backup";
            this.DeleteBackup.Name = "DeleteBackup";
            this.DeleteBackup.ReadOnly = true;
            this.DeleteBackup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteBackup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteBackup.Text = "Delete Backup";
            this.DeleteBackup.UseColumnTextForButtonValue = true;
            // 
            // OpenBackup
            // 
            this.OpenBackup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OpenBackup.HeaderText = "Open Backup";
            this.OpenBackup.Name = "OpenBackup";
            this.OpenBackup.ReadOnly = true;
            this.OpenBackup.Text = "Open Backup";
            this.OpenBackup.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 607);
            this.Controls.Add(this.lblDataGridViewMessage);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewBackup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(624, 261);
            this.Name = "Form1";
            this.Text = "Minecraft Backup Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBackup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtiNewBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mtiExit;
        private System.Windows.Forms.ToolStripMenuItem mtiOptions;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mtiHelp;
        private System.Windows.Forms.ToolStripMenuItem mtiVersion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblDataGridViewMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCPlatform;
        private System.Windows.Forms.DataGridViewButtonColumn EditBackup;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBackup;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBackup;
    }
}

