using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalOOP2Project
{
    public partial class E_TickeForm : Form
    {
        /// <summary>
        /// This method displays the movie name, ticketNo(ticket id), roomNo and date time of the movie choosen.
        /// </summary>
        /// <param name="text">Name of movie.</param>
        /// <param name="ticketNo">Ticket id of movie.</param>
        /// <param name="roomNo">Room number of movie.</param>
        /// <param name="movieShowTime">Date and time of movie.</param>
        public E_TickeForm(string text, int ticketNo, int roomNo, DateTime movieShowTime)
        {
            InitializeComponent();
            movieOutputLabel.Text = text;
            ticketNoOutputLabel.Text = ticketNo.ToString();
            roomNoOutputlabel.Text = roomNo.ToString();
            timeOutputLabel.Text = movieShowTime.ToString();

        }

        /// <summary>
        /// This method closes the form.
        /// </summary>
        /// <param name="sender">It contains a reference to the control/object that raised the event.</param>
        /// <param name="e">It contains the event data.</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            // It closes the form
            this.Close();
        }
    }
}