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
    public partial class Loginf : Form
    {
        HotelDBContext hdb = new HotelDBContext();

        public Loginf()
        {
            InitializeComponent();
        }

     

        private void btnLgin_Click(object sender, EventArgs e)
        {
            string userName = Username.Text;
            string pass = password.Text;

            User user = hdb.Users.FirstOrDefault(x => x.FullName == userName);
            

             if (!string.IsNullOrWhiteSpace(userName)&& !string.IsNullOrWhiteSpace(pass))
            {
                if (user.FullName==userName && user.Password==pass)
                {
                    if (rememberMe.Checked)
                    {
                        Properties.Settings.Default.username = userName;
                        Properties.Settings.Default.password = pass;
                        Properties.Settings.Default.ischecked = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.username = "";
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.ischecked = false;
                        Properties.Settings.Default.Save();

                    }
                    string userrolename = hdb.UserToRols.Include(x => x.Role).FirstOrDefault(x => x.UserId == user.UserId).Role.RolName;
                    if (userrolename=="Admin")
                    {
                        AdminDashbord ad = new AdminDashbord();
                        ad.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Ordering or = new Ordering(user);
                        or.ShowDialog();
                        this.Close();
                    }
                   
                }
                else
                {
                    MessageBox.Show(" Username or password isn't true!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Username.Text = "";
                    password.Text = "";
                }

            }
            else
            {
                error.Visible = true;
            }
        }

        private void Loginf_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ischecked)
            {
                Username.Text = Properties.Settings.Default.username;
                password.Text = Properties.Settings.Default.password;
                rememberMe.Checked = true;

            }
        }
    }
}
