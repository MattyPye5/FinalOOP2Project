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
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {
            TicketForm myTicket = new TicketForm();
            myTicket.Show();
        }

        private void screenRoomButton_Click(object sender, EventArgs e)
        {
            ScreenRoomForm myScreenRoom = new ScreenRoomForm();
            myScreenRoom.ShowDialog();
        }

        private void moviesButton_Click(object sender, EventArgs e)
        {
            ManagerMovieListForm myMovies = new ManagerMovieListForm();
            myMovies.Show();
        }

        private void showtimeButton_Click(object sender, EventArgs e)
        {
            ManagerShowTimeForm myShowTime = new ManagerShowTimeForm();
            myShowTime.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
