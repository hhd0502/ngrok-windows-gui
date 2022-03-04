
namespace Ngrok_Desktop
{
    partial class frmSetup
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
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectory = new System.Windows.Forms.Button();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.pgbDownloading = new System.Windows.Forms.ProgressBar();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(98, 414);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.Size = new System.Drawing.Size(555, 29);
            this.txtSaveFile.TabIndex = 0;
            this.txtSaveFile.Text = "Browse directory";
            // 
            // btnBrowseDirectory
            // 
            this.btnBrowseDirectory.BackColor = System.Drawing.Color.DarkGray;
            this.btnBrowseDirectory.FlatAppearance.BorderSize = 0;
            this.btnBrowseDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseDirectory.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseDirectory.Location = new System.Drawing.Point(668, 414);
            this.btnBrowseDirectory.Name = "btnBrowseDirectory";
            this.btnBrowseDirectory.Size = new System.Drawing.Size(97, 29);
            this.btnBrowseDirectory.TabIndex = 1;
            this.btnBrowseDirectory.Text = "Browse";
            this.btnBrowseDirectory.UseVisualStyleBackColor = false;
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.BackColor = System.Drawing.Color.Transparent;
            this.lblBrowse.Location = new System.Drawing.Point(16, 417);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(76, 22);
            this.lblBrowse.TabIndex = 2;
            this.lblBrowse.Text = "Save at: ";
            // 
            // pgbDownloading
            // 
            this.pgbDownloading.Location = new System.Drawing.Point(98, 465);
            this.pgbDownloading.Name = "pgbDownloading";
            this.pgbDownloading.Size = new System.Drawing.Size(555, 25);
            this.pgbDownloading.TabIndex = 3;
            this.pgbDownloading.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(730, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(690, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pgbDownloading);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.btnBrowseDirectory);
            this.Controls.Add(this.txtSaveFile);
            this.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.Button btnBrowseDirectory;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.ProgressBar pgbDownloading;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

