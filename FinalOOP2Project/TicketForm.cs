namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class For Manager Ticket List Form.
    /// </summary>
    public partial class TicketForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketForm"/> class.
        /// Method For Loading Form.
        /// </summary>
        public TicketForm()
        {
            // Loads Form
            InitializeComponent();
        }

        /// <summary>
        /// DataGridView Controls, Saves Data, Deletes and modifies table information.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);
        }

        /// <summary>
        /// Collects Data From Database.
        /// </summary>
        /// <param name="sender">References Load.</param>
        /// <param name="e">Holds Event Data.</param>
        private void TicketForm_Load(object sender, EventArgs e)
        {
            this.ticketTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Ticket);
        }

        /// <summary>
        /// Returns To Manager Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mF=new ManagerForm();
            mF.ShowDialog();
        }

        /// <summary>
        /// Closes Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
