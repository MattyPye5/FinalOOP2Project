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
    public partial class ManagerForm : Form
    {
        /// <summary>
        /// This is the constructor method.
        /// </summary>
        public ManagerForm()
        {
            InitializeComponent();
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
            //Close the form
            this.Close();
        }
    }
}
