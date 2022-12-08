namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// E-Ticket Form Class.
    /// </summary>
    public partial class E_TickeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="E_TickeForm"/> class.
        /// This method displays the movie name, ticketNo(ticket id), roomNo and date time of the movie choosen.
        /// </summary>
        /// <param name="text">Name of movie.</param>
        /// <param name="ticketNo">Ticket id of movie.</param>
        /// <param name="roomNo">Room number of movie.</param>
        /// <param name="movieShowTime">Date and time of movie.</param>
        public E_TickeForm(string text, int ticketNo, int roomNo, DateTime movieShowTime)
        {
            InitializeComponent();

            this.movieOutputLabel.Text = text;
            this.ticketNoOutputLabel.Text = ticketNo.ToString();
            this.roomNoOutputlabel.Text = roomNo.ToString();
            this.timeOutputLabel.Text = movieShowTime.ToString();

        }

        /// <summary>
        /// This method closes the form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }
    }
}