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
                if (userManagerTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the username");
                }
                else if (passManagerTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the password");
                }else
                {
                    var login = (from u in db.Managers
                                 where u.ManagerUsername == userManagerTextBox.Text
                                 select u).First();
                    if (login.ManagerUsername == userManagerTextBox.Text && login.ManagerPassword == passManagerTextBox.Text)
                    {
                        MessageBox.Show("YESSSS!!! BUT FOR MANAGER");
                        ManagerForm manager = new ManagerForm();
                        manager.ShowDialog();
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

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
