namespace FinalOOP2Project
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Manager Login Form Class.
    /// </summary>
    public partial class ManagerLogin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerLogin"/> class.
        /// Manager Login Form Method Loads Manager Form.
        /// </summary>
        public ManagerLogin()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// ClickEvent For the login button on the manager form.
        /// </summary>
        /// <param name="sender">References Button</param>
        /// <param name="e">Holds Event Data.</param>
        private void loginManagerButton_Click(object sender, EventArgs e)
        {
            // Try Catch to make sure fields are not empty
            try
            {
                if (userManagerTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the username");
                }
                else if (passManagerTextBox.Text == "")
                {
                    MessageBox.Show("Please enter the password");
                }
                else
                {
                    // Looks For Usernames and Passwords that already exisist in the Database
                    var login = (from u in db.Managers
                                 where u.ManagerUsername == userManagerTextBox.Text
                                 select u).First();

                    // Reads Textboxes
                    if (login.ManagerUsername == userManagerTextBox.Text && login.ManagerPassword == passManagerTextBox.Text)
                    {
                        ManagerForm manager = new ManagerForm();
                        manager.ShowDialog();
                    }
                    else
                    {
                        // Exception Handling
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                // Exception Handling
                MessageBox.Show("Incorrect Username or Password");
        }
        }
    }
}
