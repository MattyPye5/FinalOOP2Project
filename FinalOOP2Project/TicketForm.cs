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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);

        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Ticket);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mF=new ManagerForm();
            mF.ShowDialog();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
