
namespace Minecraft_Backup_Manager
{
    partial class frmOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackupLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBedrockLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJavaLocation = new System.Windows.Forms.TextBox();
            this.btnChangeBackupLocation = new System.Windows.Forms.Button();
            this.btnChangeBedrockLocation = new System.Windows.Forms.Button();
            this.btnChangeJavaLocation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.fbdBackupLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdBedrockLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdJavaLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Backup Location:";
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBackupLocation.Location = new System.Drawing.Point(202, 31);
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.Size = new System.Drawing.Size(292, 20);
            this.txtBackupLocation.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Default Bedrock Saves Location: ";
            // 
            // txtBedrockLocation
            // 
            this.txtBedrockLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBedrockLocation.Location = new System.Drawing.Point(202, 71);
            this.txtBedrockLocation.Name = "txtBedrockLocation";
            this.txtBedrockLocation.Size = new System.Drawing.Size(292, 20);
            this.txtBedrockLocation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Default Java Saves Location:";
            // 
            // txtJavaLocation
            // 
            this.txtJavaLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJavaLocation.Location = new System.Drawing.Point(202, 111);
            this.txtJavaLocation.Name = "txtJavaLocation";
            this.txtJavaLocation.Size = new System.Drawing.Size(292, 20);
            this.txtJavaLocation.TabIndex = 5;
            // 
            // btnChangeBackupLocation
            // 
            this.btnChangeBackupLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeBackupLocation.Location = new System.Drawing.Point(500, 28);
            this.btnChangeBackupLocation.Name = "btnChangeBackupLocation";
            this.btnChangeBackupLocation.Size = new System.Drawing.Size(25, 25);
            this.btnChangeBackupLocation.TabIndex = 6;
            this.btnChangeBackupLocation.Text = "...";
            this.btnChangeBackupLocation.UseVisualStyleBackColor = true;
            this.btnChangeBackupLocation.Click += new System.EventHandler(this.btnChangeBackupLocation_Click);
            // 
            // btnChangeBedrockLocation
            // 
            this.btnChangeBedrockLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeBedrockLocation.Location = new System.Drawing.Point(500, 68);
            this.btnChangeBedrockLocation.Name = "btnChangeBedrockLocation";
            this.btnChangeBedrockLocation.Size = new System.Drawing.Size(25, 25);
            this.btnChangeBedrockLocation.TabIndex = 6;
            this.btnChangeBedrockLocation.Text = "...";
            this.btnChangeBedrockLocation.UseVisualStyleBackColor = true;
            this.btnChangeBedrockLocation.Click += new System.EventHandler(this.btnChangeBedrockLocation_Click);
            // 
            // btnChangeJavaLocation
            // 
            this.btnChangeJavaLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeJavaLocation.Location = new System.Drawing.Point(500, 108);
            this.btnChangeJavaLocation.Name = "btnChangeJavaLocation";
            this.btnChangeJavaLocation.Size = new System.Drawing.Size(25, 25);
            this.btnChangeJavaLocation.TabIndex = 6;
            this.btnChangeJavaLocation.Text = "...";
            this.btnChangeJavaLocation.UseVisualStyleBackColor = true;
            this.btnChangeJavaLocation.Click += new System.EventHandler(this.btnChangeJavaLocation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.Location = new System.Drawing.Point(481, 162);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Save";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // fbdBackupLocation
            // 
            this.fbdBackupLocation.ShowNewFolderButton = false;
            // 
            // fbdBedrockLocation
            // 
            this.fbdBedrockLocation.ShowNewFolderButton = false;
            // 
            // fbdJavaLocation
            // 
            this.fbdJavaLocation.ShowNewFolderButton = false;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 197);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeJavaLocation);
            this.Controls.Add(this.btnChangeBedrockLocation);
            this.Controls.Add(this.btnChangeBackupLocation);
            this.Controls.Add(this.txtJavaLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBedrockLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBackupLocation);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1399, 236);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(584, 236);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBackupLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBedrockLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJavaLocation;
        private System.Windows.Forms.Button btnChangeBackupLocation;
        private System.Windows.Forms.Button btnChangeBedrockLocation;
        private System.Windows.Forms.Button btnChangeJavaLocation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.FolderBrowserDialog fbdBackupLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdBedrockLocation;
        private System.Windows.Forms.FolderBrowserDialog fbdJavaLocation;
    }
}