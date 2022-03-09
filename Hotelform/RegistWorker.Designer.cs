
namespace Hotelform
{
    partial class RegistWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistWorker));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error = new System.Windows.Forms.Label();
            this.btnLgin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfPass = new System.Windows.Forms.TextBox();
            this.dtgUserlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserlist)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(96, 593);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(177, 25);
            this.error.TabIndex = 12;
            this.error.Text = "Please fill all fileds!";
            this.error.Visible = false;
            // 
            // btnLgin
            // 
            this.btnLgin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLgin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLgin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLgin.Location = new System.Drawing.Point(69, 533);
            this.btnLgin.Name = "btnLgin";
            this.btnLgin.Size = new System.Drawing.Size(230, 57);
            this.btnLgin.TabIndex = 11;
            this.btnLgin.Text = "Register";
            this.btnLgin.UseVisualStyleBackColor = false;
            this.btnLgin.Click += new System.EventHandler(this.btnLgin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(66, 403);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(240, 32);
            this.password.TabIndex = 8;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(64, 222);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(237, 32);
            this.Username.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(132, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Full Name";
            // 
            // Fullname
            // 
            this.Fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fullname.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Fullname.Location = new System.Drawing.Point(66, 316);
            this.Fullname.Name = "Fullname";
            this.Fullname.Size = new System.Drawing.Size(237, 32);
            this.Fullname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(96, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password";
            // 
            // ConfPass
            // 
            this.ConfPass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfPass.Location = new System.Drawing.Point(69, 475);
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.Size = new System.Drawing.Size(237, 32);
            this.ConfPass.TabIndex = 15;
            // 
            // dtgUserlist
            // 
            this.dtgUserlist.AllowUserToAddRows = false;
            this.dtgUserlist.AllowUserToDeleteRows = false;
            this.dtgUserlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUserlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUserlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUserlist.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgUserlist.Location = new System.Drawing.Point(407, 0);
            this.dtgUserlist.Name = "dtgUserlist";
            this.dtgUserlist.ReadOnly = true;
            this.dtgUserlist.RowHeadersWidth = 51;
            this.dtgUserlist.RowTemplate.Height = 29;
            this.dtgUserlist.Size = new System.Drawing.Size(507, 634);
            this.dtgUserlist.TabIndex = 17;
            // 
            // RegistWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(914, 634);
            this.Controls.Add(this.dtgUserlist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fullname);
            this.Controls.Add(this.error);
            this.Controls.Add(this.btnLgin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUserlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button btnLgin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfPass;
        private System.Windows.Forms.DataGridView dtgUserlist;
    }
}