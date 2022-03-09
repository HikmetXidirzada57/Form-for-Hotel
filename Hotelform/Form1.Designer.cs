
namespace Hotelform
{
    partial class Ordering
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.dtCheckdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbRoomtype = new System.Windows.Forms.ComboBox();
            this.cmbRoomNumb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbRoomFloor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(14, 96);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(181, 27);
            this.txtCName.TabIndex = 1;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(14, 178);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(181, 27);
            this.txtPhonenumber.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(243, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(243, 96);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(181, 27);
            this.txtIdentity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(257, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(243, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Identitfication";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(96, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtCheckin
            // 
            this.dtCheckin.Location = new System.Drawing.Point(9, 415);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(332, 27);
            this.dtCheckin.TabIndex = 10;
            // 
            // dtCheckdate
            // 
            this.dtCheckdate.Location = new System.Drawing.Point(9, 500);
            this.dtCheckdate.Name = "dtCheckdate";
            this.dtCheckdate.Size = new System.Drawing.Size(332, 27);
            this.dtCheckdate.TabIndex = 11;
            this.dtCheckdate.ValueChanged += new System.EventHandler(this.dtCheckdate_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Checkin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Checkout";
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AllowUserToAddRows = false;
            this.dtgCustomer.AllowUserToDeleteRows = false;
            this.dtgCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCustomer.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgCustomer.Location = new System.Drawing.Point(532, 0);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.ReadOnly = true;
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 29;
            this.dtgCustomer.Size = new System.Drawing.Size(581, 613);
            this.dtgCustomer.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "Room type";
            // 
            // cmbRoomtype
            // 
            this.cmbRoomtype.FormattingEnabled = true;
            this.cmbRoomtype.Location = new System.Drawing.Point(11, 261);
            this.cmbRoomtype.Name = "cmbRoomtype";
            this.cmbRoomtype.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomtype.TabIndex = 21;
            this.cmbRoomtype.SelectedIndexChanged += new System.EventHandler(this.cmbRoomtype_SelectedIndexChanged);
            // 
            // cmbRoomNumb
            // 
            this.cmbRoomNumb.FormattingEnabled = true;
            this.cmbRoomNumb.Location = new System.Drawing.Point(239, 261);
            this.cmbRoomNumb.Name = "cmbRoomNumb";
            this.cmbRoomNumb.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomNumb.TabIndex = 23;
            this.cmbRoomNumb.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNumb_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(239, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Room Number";
            // 
            // cmbRoomFloor
            // 
            this.cmbRoomFloor.FormattingEnabled = true;
            this.cmbRoomFloor.Location = new System.Drawing.Point(113, 337);
            this.cmbRoomFloor.Name = "cmbRoomFloor";
            this.cmbRoomFloor.Size = new System.Drawing.Size(190, 28);
            this.cmbRoomFloor.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(122, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Room Floor";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("ROG Fonts", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(113, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(161, 22);
            this.lblUser.TabIndex = 28;
            this.lblUser.Text = "Useronline:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(332, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 30;
            this.label11.Text = "Day*price:";
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblmoney.Location = new System.Drawing.Point(434, 540);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(62, 23);
            this.lblmoney.TabIndex = 31;
            this.lblmoney.Text = "money";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(364, 455);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(84, 27);
            this.txtprice.TabIndex = 32;
            this.txtprice.Visible = false;
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1113, 613);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbRoomFloor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRoomNumb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbRoomtype);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtCheckdate);
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtCName);
            this.Name = "Ordering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.Ordering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.DateTimePicker dtCheckdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRoomtype;
        private System.Windows.Forms.ComboBox cmbRoomNumb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRoomFloor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.TextBox txtprice;
    }
}

