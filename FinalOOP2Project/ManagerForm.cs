namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///  Main Manager Form Class.
    /// </summary>
    public partial class ManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerForm"/> class.
        /// This is the constructor method.
        /// </summary>
        public ManagerForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This method displays TicketForm.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void ticketsButton_Click(object sender, EventArgs e)
        {
            TicketForm myTicket = new TicketForm();
            myTicket.Show();
        }

        /// <summary>
        /// This method displays ScreenRoomForm.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void screenRoomButton_Click(object sender, EventArgs e)
        {
            ScreenRoomForm myScreenRoom = new ScreenRoomForm();
            myScreenRoom.ShowDialog();
        }

        /// <summary>
        /// This method displays ManagerMovieListForm.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void moviesButton_Click(object sender, EventArgs e)
        {
            ManagerMovieListForm myMovies = new ManagerMovieListForm();
            myMovies.Show();
        }

        /// <summary>
        /// This method displays ManagerShowTimeForm.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void showtimeButton_Click(object sender, EventArgs e)
        {
            ManagerShowTimeForm myShowTime = new ManagerShowTimeForm();
            myShowTime.ShowDialog();
        }

        /// <summary>
        /// This method closes the Form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        /// <summary>
        /// This Method opens Client Form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void clientButton_Click(object sender, EventArgs e)
        {
            ManagerClientForm myManagerClientForm = new ManagerClientForm();
            myManagerClientForm.ShowDialog();
        }
    }
}
