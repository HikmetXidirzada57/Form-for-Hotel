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
    public partial class RegistWorker : Form
    {
        HotelDBContext hdb = new();
        
        public RegistWorker()
        {
            InitializeComponent();
        }

        private void btnLgin_Click(object sender, EventArgs e)
        {
            string userName = Username.Text;
            string fullname = Fullname.Text;
            string Pass = password.Text;
            string confpass = ConfPass.Text;
            string[] mylsit = new string[] { userName, fullname, Pass,confpass};

            if (Utilities.IsEmpty(mylsit))
            {
             User Setuser = hdb.Users.FirstOrDefault(x => x.Username == userName);

                if (Setuser == null)
                {
                    if (confpass==Pass)
                    {
                        User newuser = new()
                        {
                            Username = userName,
                            FullName = fullname,
                            Password = Pass.Hassme()
                        };
                        hdb.Users.Add(newuser);
                        hdb.SaveChanges();
                    

                        int roleId = hdb.Rols.FirstOrDefault(x => x.RolName == "Worker").RolId;
                        UserToRol usrrol = new()
                        {
                            UserId = roleId,
                            RoleId=roleId
                        };
                        hdb.UserToRols.Add(usrrol);
                        hdb.SaveChanges();
                        MessageBox.Show("User has been added!", "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                        FillUsergrid();
                    }
                    else
                    {
                        error.Text = "The password is not valid";
                    }

                }
                else
                {
                    error.Text = "User already exist!";
                }
              
            }
            else
            {
                error.Visible = true;
            }

        }
        private void FillUsergrid()
        {
            dtgUserlist.DataSource = hdb.Users.Select(x=>new
            {    
                x.FullName,
                x.Username,
                x.Password
            }).ToList();
        }

        private void RegistWorker_Load(object sender, EventArgs e)
        {
            FillUsergrid();
        }

      
    }
}
