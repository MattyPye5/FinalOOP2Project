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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the username");
                }
                else if (passTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the password");
                }
                else
                {
                    var login = (from u in db.Users
                                 where u.Username == userTextBox.Text
                                 select u).First();
                    if (login.Username == userTextBox.Text && login.Password == passTextBox.Text)
                    {
                        MessageBox.Show("YESSSS!!!");
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
        }   }

        private void managerLoginOpenLabel_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.Show();
        }

        private void registerOpenLabel_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
