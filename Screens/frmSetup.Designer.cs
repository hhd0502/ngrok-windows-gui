
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAuthtoken = new System.Windows.Forms.Button();
            this.txtAuthtoken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExits = new Ngrok_Desktop.CircleButton(this.components);
            this.btnMinimized = new Ngrok_Desktop.CircleButton(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.txtPath5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "NGROK GUI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::Ngrok_Desktop.Properties.Resources.link;
            this.pictureBox1.Image = global::Ngrok_Desktop.Properties.Resources.link;
            this.pictureBox1.InitialImage = global::Ngrok_Desktop.Properties.Resources.link;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAuthtoken
            // 
            this.btnAuthtoken.BackColor = System.Drawing.Color.DarkGray;
            this.btnAuthtoken.FlatAppearance.BorderSize = 0;
            this.btnAuthtoken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthtoken.ForeColor = System.Drawing.Color.White;
            this.btnAuthtoken.Location = new System.Drawing.Point(300, 129);
            this.btnAuthtoken.Name = "btnAuthtoken";
            this.btnAuthtoken.Size = new System.Drawing.Size(200, 30);
            this.btnAuthtoken.TabIndex = 8;
            this.btnAuthtoken.Text = "Add Authtoken";
            this.btnAuthtoken.UseVisualStyleBackColor = false;
            // 
            // txtAuthtoken
            // 
            this.txtAuthtoken.Location = new System.Drawing.Point(123, 83);
            this.txtAuthtoken.Name = "txtAuthtoken";
            this.txtAuthtoken.ReadOnly = true;
            this.txtAuthtoken.Size = new System.Drawing.Size(555, 29);
            this.txtAuthtoken.TabIndex = 9;
            this.txtAuthtoken.Text = "23eSeDLXzAPoTfdfNyIFquk8ven_2Y9ZRf8LivgQe8jowpoVN";
            this.txtAuthtoken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Authtoken:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnExits
            // 
            this.btnExits.BackColor = System.Drawing.Color.Red;
            this.btnExits.FlatAppearance.BorderSize = 0;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.Location = new System.Drawing.Point(750, 12);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(30, 30);
            this.btnExits.TabIndex = 12;
            this.btnExits.UseVisualStyleBackColor = false;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Yellow;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(710, 12);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(30, 30);
            this.btnMinimized.TabIndex = 13;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 51);
            this.panel1.TabIndex = 14;
            // 
            // txtPath1
            // 
            this.txtPath1.Font = new System.Drawing.Font("UTM Avo", 8F);
            this.txtPath1.Location = new System.Drawing.Point(13, 208);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(767, 22);
            this.txtPath1.TabIndex = 15;
            this.txtPath1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPath2
            // 
            this.txtPath2.Font = new System.Drawing.Font("UTM Avo", 8F);
            this.txtPath2.Location = new System.Drawing.Point(14, 247);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.ReadOnly = true;
            this.txtPath2.Size = new System.Drawing.Size(767, 22);
            this.txtPath2.TabIndex = 16;
            this.txtPath2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPath3
            // 
            this.txtPath3.Font = new System.Drawing.Font("UTM Avo", 8F);
            this.txtPath3.Location = new System.Drawing.Point(14, 285);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.ReadOnly = true;
            this.txtPath3.Size = new System.Drawing.Size(767, 22);
            this.txtPath3.TabIndex = 17;
            this.txtPath3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPath4
            // 
            this.txtPath4.Font = new System.Drawing.Font("UTM Avo", 8F);
            this.txtPath4.Location = new System.Drawing.Point(14, 320);
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.ReadOnly = true;
            this.txtPath4.Size = new System.Drawing.Size(767, 22);
            this.txtPath4.TabIndex = 18;
            this.txtPath4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPath5
            // 
            this.txtPath5.Font = new System.Drawing.Font("UTM Avo", 8F);
            this.txtPath5.Location = new System.Drawing.Point(13, 355);
            this.txtPath5.Name = "txtPath5";
            this.txtPath5.ReadOnly = true;
            this.txtPath5.Size = new System.Drawing.Size(767, 22);
            this.txtPath5.TabIndex = 19;
            this.txtPath5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.txtPath5);
            this.Controls.Add(this.txtPath4);
            this.Controls.Add(this.txtPath3);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnExits);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthtoken);
            this.Controls.Add(this.btnAuthtoken);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UTM Avo", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngrok Desktop";
            this.Load += new System.EventHandler(this.frmSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAuthtoken;
        private System.Windows.Forms.TextBox txtAuthtoken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private CircleButton btnExits;
        private CircleButton btnMinimized;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.TextBox txtPath4;
        private System.Windows.Forms.TextBox txtPath5;
    }
}

