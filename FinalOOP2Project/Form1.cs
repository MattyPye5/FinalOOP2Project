namespace FinalOOP2Project
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Main Form of the Application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// This is the constructor method.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
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
            // Try/Catch for checking for empty fields.
            try
            {
                // Checks for Empty Strings
                if (userTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the username");
                }
                else if (passTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter the password");
                }
                else
                {
                    // Checks If username and Password are in database
                    var login = (from u in db.Users
                                 where u.Username == userTextBox.Text
                                 select u).First();
                    if (login.Username == userTextBox.Text && login.Password == passTextBox.Text)
                    {
                        // Opens Main Client Form.
                        ClientForm cf = new ClientForm();
                        cf.ShowDialog();
                    }

                    // Exception catch.
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password");
                    }
                }
            }

            // Exception catch.
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
