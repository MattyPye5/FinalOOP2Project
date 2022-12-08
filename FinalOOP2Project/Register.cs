namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Client Register Form.
    /// </summary>
    public partial class Register : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Register"/> class.
        /// Method Starts Form.
        /// </summary>
        public Register()
        {
            // Opens Form.
            InitializeComponent();
        }

        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// Adds New User To Database and checks fields to make sure theyre not empty. 
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data</param>
        private void loginRegisterButton_Click(object sender, EventArgs e)
        {
            // Checking for empty fields
                if (this.passRegisterTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All Fields");
                }
                else if (this.userRegisterTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All Fields");
                }

                // Registers data into database
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
