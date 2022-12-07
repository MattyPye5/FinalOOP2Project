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
    /// <summary>
    /// Client Register Form
    /// </summary>
    public partial class Register : Form
    {
        /// <summary>
        /// Method Holds form 
        /// </summary>
        public Register()
        {
            InitializeComponent();
        }

        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
                if (this.passRegisterTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All Fields");
                }
                else if (this.userRegisterTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All Fields");
                }
                else
                {
                    User newUser = new User
                    {
                        Password = this.passRegisterTextBox.Text,
                        Username = this.userRegisterTextBox.Text,

                    };
                    db.Users.InsertOnSubmit(newUser);
                    db.SubmitChanges();
                    this.Close();
                }
        }
    }
}
