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
    public partial class AdminDashbord : Form
    {
        public AdminDashbord()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            RegistWorker rg = new();
            rg.ShowDialog();
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            Ordersview ov = new();
            ov.ShowDialog();
        }
    }
}
