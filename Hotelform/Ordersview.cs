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
    public partial class Ordersview : Form
    {
        HotelDBContext hdb = new HotelDBContext();
        RoomType types;
        public Ordersview()
        {
            InitializeComponent();
        }

        private void FillCustGrid()
        {
            dtgorders.DataSource = hdb.Orders.Include(x => x.Customer).Include(x => x.Room).Select(x => new
            {
                x.User.Username,
                x.Customer.FullName,
                x.Customer.Email,
                x.Customer.PhoneNumber,
                x.Room.Roomtype.Name,
                x.Checkin,
                x.CheckDate,
                x.TotalPrice
            }).ToList();
           
        }

        private void Ordersview_Load(object sender, EventArgs e)
        {
            FillCustGrid();
        }

        private void dtgorders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnDelete.Visible = true;
            btnEdit.Visible = true;
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string csName = txtCName.Text;
            string csNumber = txtPhonenumber.Text;
            string csEmail = txtEmail.Text;
            string identity = txtIdentity.Text;
            string romtypes = cmbRoomtype.Text;
            string roomNumber = cmbRoomNumb.Text;
            DateTime checkin = dtCheckin.Value;
            DateTime checkdate = dtCheckdate.Value;
            types = hdb.RoomTypes.FirstOrDefault(x => x.Name == romtypes);

         

        }

       
    }
  }
