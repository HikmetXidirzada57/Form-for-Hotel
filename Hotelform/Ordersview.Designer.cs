
namespace Hotelform
{
    partial class Ordersview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordersview));
            this.dtgorders = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbRoomFloor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRoomNumb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRoomtype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCheckdate = new System.Windows.Forms.DateTimePicker();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgorders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgorders
            // 
            this.dtgorders.AllowUserToAddRows = false;
            this.dtgorders.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgorders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgorders.Location = new System.Drawing.Point(0, 0);
            this.dtgorders.Name = "dtgorders";
            this.dtgorders.RowHeadersWidth = 51;
            this.dtgorders.RowTemplate.Height = 29;
            this.dtgorders.Size = new System.Drawing.Size(1053, 249);
            this.dtgorders.TabIndex = 0;
            this.dtgorders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgorders_RowHeaderMouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1053, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(21, 606);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(159, 43);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "E d i t";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(321, 606);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "D e l e t e";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // cmbRoomFloor
            // 
            this.cmbRoomFloor.FormattingEnabled = true;
            this.cmbRoomFloor.Location = new System.Drawing.Point(691, 385);
            this.cmbRoomFloor.Name = "cmbRoomFloor";
            this.cmbRoomFloor.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomFloor.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(700, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Room Floor";
            // 
            // cmbRoomNumb
            // 
            this.cmbRoomNumb.FormattingEnabled = true;
            this.cmbRoomNumb.Location = new System.Drawing.Point(817, 309);
            this.cmbRoomNumb.Name = "cmbRoomNumb";
            this.cmbRoomNumb.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomNumb.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(817, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 42;
            this.label9.Text = "Room Number";
            // 
            // cmbRoomtype
            // 
            this.cmbRoomtype.FormattingEnabled = true;
            this.cmbRoomtype.Location = new System.Drawing.Point(589, 309);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomtype.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(589, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Room type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(509, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Checkout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(45, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Checkin";
            // 
            // dtCheckdate
            // 
            this.dtCheckdate.Location = new System.Drawing.Point(509, 467);
            this.dtCheckdate.Name = "dtCheckdate";
            this.dtCheckdate.Size = new System.Drawing.Size(332, 27);
            this.dtCheckdate.TabIndex = 37;
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(45, 467);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(332, 27);
            this.dtCheckin.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(266, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Identitfication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(280, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Customer Name";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(266, 310);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(181, 27);
            this.txtIdentity.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(266, 392);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 27);
            this.txtEmail.TabIndex = 30;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(37, 392);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(181, 27);
            this.txtPhonenumber.TabIndex = 29;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(37, 310);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(181, 27);
            this.txtCName.TabIndex = 28;
            // 
            // Ordersview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1053, 681);
            this.Controls.Add(this.cmbRoomFloor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRoomNumb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtCheckdate);
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgorders);
            this.Name = "Ordersview";
            this.Text = "Ordersview";
            this.Load += new System.EventHandler(this.Ordersview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgorders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgorders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbRoomFloor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRoomNumb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRoomtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCheckdate;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtCName;
    }
}