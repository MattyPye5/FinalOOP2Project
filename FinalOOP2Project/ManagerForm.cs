﻿using System;
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
            
        }

        private void showtimeButton_Click(object sender, EventArgs e)
        {
            ManagerShowTime myManagerShowTime = new ManagerShowTime();
            myManagerShowTime.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
