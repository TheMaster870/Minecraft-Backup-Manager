
namespace Minecraft_Backup_Manager
{
    partial class frmNewBackup
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
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSavesLocation = new System.Windows.Forms.TextBox();
            this.btnChangeSavesLocation = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cblSaves = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.btnChangeBackupLocation = new System.Windows.Forms.Button();
            this.fbdSavesLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdBackupLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.Enabled = false;
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.Items.AddRange(new object[] {
            "Java",
            "Bedrock"});
            this.cmbPlatform.Location = new System.Drawing.Point(118, 64);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(121, 21);
            this.cmbPlatform.TabIndex = 0;
            this.cmbPlatform.SelectedValueChanged += new System.EventHandler(this.cmbPlatform_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MC Platform:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saves Location:";
            // 
            // txtSavesLocation
            // 
            this.txtSavesLocation.Enabled = false;
            this.txtSavesLocation.Location = new System.Drawing.Point(118, 97);
            this.txtSavesLocation.Name = "txtSavesLocation";
            this.txtSavesLocation.Size = new System.Drawing.Size(297, 20);
            this.txtSavesLocation.TabIndex = 3;
            this.txtSavesLocation.TextChanged += new System.EventHandler(this.txtSavesLocation_TextChanged);
            // 
            // btnChangeSavesLocation
            // 
            this.btnChangeSavesLocation.Enabled = false;
            this.btnChangeSavesLocation.Location = new System.Drawing.Point(421, 94);
            this.btnChangeSavesLocation.Name = "btnChangeSavesLocation";
            this.btnChangeSavesLocation.Size = new System.Drawing.Size(25, 25);
            this.btnChangeSavesLocation.TabIndex = 4;
            this.btnChangeSavesLocation.Text = "...";
            this.btnChangeSavesLocation.UseVisualStyleBackColor = true;
            this.btnChangeSavesLocation.Click += new System.EventHandler(this.btnChangeSavesLocation_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Enabled = false;
            this.btnEnter.Location = new System.Drawing.Point(405, 442);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(106, 23);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Start Backup";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cblSaves
            // 
            this.cblSaves.Enabled = false;
            this.cblSaves.FormattingEnabled = true;
            this.cblSaves.Location = new System.Drawing.Point(118, 167);
            this.cblSaves.Name = "cblSaves";
            this.cblSaves.Size = new System.Drawing.Size(267, 259);
            this.cblSaves.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Backup Name:";
            // 
            // txtBackupName
            // 
            this.txtBackupName.Location = new System.Drawing.Point(118, 31);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(297, 20);
            this.txtBackupName.TabIndex = 9;
            this.txtBackupName.TextChanged += new System.EventHandler(this.txtBackupName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Backup Location:";
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Enabled = false;
            this.txtBackupLocation.Location = new System.Drawing.Point(118, 130);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(297, 20);
            this.txtBackupLocation.TabIndex = 11;
            this.txtBackupLocation.TextChanged += new System.EventHandler(this.txtBackupLocation_TextChanged);
            // 
            // btnChangeBackupLocation
            // 
            this.btnChangeBackupLocation.Enabled = false;
            this.btnChangeBackupLocation.Location = new System.Drawing.Point(421, 127);
            this.btnChangeBackupLocation.Name = "btnChangeBackupLocation";
            this.btnChangeBackupLocation.Size = new System.Drawing.Size(25, 25);
            this.btnChangeBackupLocation.TabIndex = 12;
            this.btnChangeBackupLocation.Text = "...";
            this.btnChangeBackupLocation.UseVisualStyleBackColor = true;
            this.btnChangeBackupLocation.Click += new System.EventHandler(this.btnChangeBackupLocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Saves:";
            // 
            // frmNewBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 477);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChangeBackupLocation);
            this.Controls.Add(this.txtBackupLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBackupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cblSaves);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnChangeSavesLocation);
            this.Controls.Add(this.txtSavesLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlatform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSavesLocation;
        private System.Windows.Forms.Button btnChangeSavesLocation;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox cblSaves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Button btnChangeBackupLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdSavesLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdBackupLocation;
        private System.Windows.Forms.Label label5;
    }
}