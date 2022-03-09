
namespace Hotelform
{
    partial class Loginf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginf));
            this.panel1 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLgin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rememberMe);
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLgin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(104, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 422);
            this.panel1.TabIndex = 0;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(197, 393);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(177, 25);
            this.error.TabIndex = 6;
            this.error.Text = "Please fill all fileds!";
            this.error.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLgin
            // 
            this.btnLgin.BackColor = System.Drawing.Color.Blue;
            this.btnLgin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLgin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLgin.Location = new System.Drawing.Point(197, 342);
            this.btnLgin.Name = "btnLgin";
            this.btnLgin.Size = new System.Drawing.Size(175, 48);
            this.btnLgin.TabIndex = 4;
            this.btnLgin.Text = "L O G I N";
            this.btnLgin.UseVisualStyleBackColor = false;
            this.btnLgin.Click += new System.EventHandler(this.btnLgin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(237, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(165, 263);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(237, 32);
            this.password.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(165, 179);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(237, 32);
            this.Username.TabIndex = 0;
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rememberMe.ForeColor = System.Drawing.Color.Maroon;
            this.rememberMe.Location = new System.Drawing.Point(218, 301);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(127, 24);
            this.rememberMe.TabIndex = 7;
            this.rememberMe.Text = "Remeber me?";
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // Loginf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(795, 586);
            this.Controls.Add(this.panel1);
            this.Name = "Loginf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Loginf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLgin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.CheckBox rememberMe;
    }
}