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
        /// <summary>
        /// This is the constructor method.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an object of LINQ querie.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// This method verifys the input of the user and if it's the right input and correct data then it dislays another form, if not, it displays a messagebox to show the user that it's not the right input or correct data.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
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
                        ClientForm cf=new ClientForm();
                        cf.ShowDialog();
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
            }
        }

        /// <summary>
        /// This method displays the ManagerLogin form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void managerLoginOpenLabel_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.ShowDialog();
        }

        /// <summary>
        /// This method displays the Register form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void registerOpenLabel_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
        }
    }
}
