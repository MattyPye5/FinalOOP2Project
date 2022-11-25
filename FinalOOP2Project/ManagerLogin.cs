using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOP2Project
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
        private void loginManagerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userManagerTextBox.Text == "" && passManagerTextBox.Text == "")
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                else
                {
                    var login = (from u in db.Managers
                                 where u.ManagerUsername == userManagerTextBox.Text
                                 select u).First();
                    if (login.ManagerUsername == userManagerTextBox.Text && login.ManagerPassword == passManagerTextBox.Text)
                    {
                        MessageBox.Show("YESSSS!!! BUT FOR MANAGER");
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Username or Password");
        }  }
    }
}
