using Hotelform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelform
{
    public partial class Ordering : Form
    {
         HotelDBContext hdb = new HotelDBContext();
         RoomType Type;
         User ActiveUser;

        public TimeSpan TimeSpan { get; private set; }

        public Ordering(User us)
        {
            InitializeComponent();
            ActiveUser = us;
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string csName = txtCName.Text;
            string csNumber = txtPhonenumber.Text;
            string csEmail = txtEmail.Text;
            string identity = txtIdentity.Text; 
            string romtype = cmbRoomtype.Text;
            string roomNumber = cmbRoomNumb.Text;
            DateTime checkin = dtCheckin.Value;
            DateTime checkdate = dtCheckdate.Value;
            TimeSpan ts = checkdate - checkin;
            int days = ts.Days;
            string [] empty = new[] { csName, csEmail, csNumber, identity, };

             Type = hdb.RoomTypes.FirstOrDefault(x => x.Name==romtype);  
             int romID = hdb.Rooms.FirstOrDefault(x => x.RoomNumber.ToString() == roomNumber).RoomId;

            if (Utilities.IsEmpty(empty))

            {

                if (checkdate>checkin)
                {
                    Customer cs = new()
                    {
                        FullName = csName,
                        PhoneNumber = csNumber,
                        Email = csEmail,
                        IdentificationId =Convert.ToInt32(identity)
                        
                    };
                    hdb.Customers.Add(cs);
                    hdb.SaveChanges();
                    MessageBox.Show("Customers's order completed!","succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtCName.Text = "";
                    txtEmail.Text = "";
                    txtIdentity.Text = "";

                    cmbRoomtype.Text = "";
                    cmbRoomNumb.Text = "";
                    cmbRoomFloor.Text = "";
                    Order neworder = new()
                    {
                        CustomerId = cs.CustomerId,
                        RoomId = romID,
                        UserId = ActiveUser.UserId,
                        IsRefunded = true,
                        Checkin = checkin,
                        CheckDate = checkdate,
                        TotalPrice = Type.Price
                    };
                    hdb.Orders.Add(neworder);
                    hdb.SaveChanges();

                    FillCustGrid();
                }
                else
                {
                    MessageBox.Show("Date isn;t true!","error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all!","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillCustGrid()
        {    
            dtgCustomer.DataSource = hdb.Orders.Where(x=>x.UserId==ActiveUser.UserId).Include(x=>x.Customer).Include(x=>x.Room).Select(x => new
           {
               x.Customer.FullName,
               x.Customer.Email,
               x.Customer.PhoneNumber,
               x.Customer.IdentificationId,
               x.Room.Roomtype.Name,
               x.Room.RoomNumber,
               x.Checkin,
               x.CheckDate,
               x.TotalPrice              
            }).ToList(); 
           
        }
        private void FillRomType()
        {
            cmbRoomtype.Items.AddRange(hdb.RoomTypes.Select(x => x.Name).ToArray());
        }
        private void FillRomNumb()
        {
            cmbRoomNumb.Items.AddRange(hdb.Rooms.Select(x => x.RoomNumber.ToString()).ToArray());
        }

        

        private void cmbRoomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNumb.Text = "";
            string roomtypename = cmbRoomtype.Text;
            int roomId = hdb.RoomTypes.FirstOrDefault(x => x.Name == roomtypename).RoomTypeId;
            cmbRoomNumb.Items.Clear();
            cmbRoomNumb.Items.AddRange(hdb.Rooms.Where(x => x.RoomtypeId == roomId).Select(x => x.RoomNumber.ToString()).ToArray());
            DateTime checkin = dtCheckin.Value;
            DateTime checkout = dtCheckdate.Value;
            TimeSpan ts = checkout - checkin;
            int days = ts.Days;
            lblmoney.Text = days.ToString()+"gun";
        }

        private void cmbRoomNumb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NumberId = hdb.Rooms.FirstOrDefault(x => x.RoomNumber.ToString() == cmbRoomNumb.Text).RoomId;
            cmbRoomFloor.Items.Clear();
            cmbRoomFloor.Items.AddRange(hdb.Rooms.Where(x => x.RoomId == NumberId).Select(x => x.Floor.FloorNumber.ToString()).ToArray());
        }

        private void Ordering_Load(object sender, EventArgs e)
        {
            FillRomType();
            FillRomNumb();
            FillCustGrid();
            lblUser.Text = "Online  " + ActiveUser.FullName;
        }

        private void dtCheckdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkin = dtCheckin.Value;
            DateTime checkout = dtCheckdate.Value;
            TimeSpan ts = checkout - checkin;
            int days = ts.Days;
            lblmoney.Text = days.ToString() + "gun";
        }
    }
}
