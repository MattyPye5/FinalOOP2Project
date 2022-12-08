namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class For Manager ManagerShowTime List Form.
    /// </summary>
    public partial class ManagerShowTimeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerShowTimeForm"/> class.
        /// Method For Loading Form.
        /// </summary>
        public ManagerShowTimeForm()
        {
            // Loads Form.
            InitializeComponent();
        }

        /// <summary>
        /// DataGridView Controls, Saves Data, Deletes and modifies table information.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void showTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showTimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);
        }

        /// <summary>
        /// Collects Data From Database.
        /// </summary>
        /// <param name="sender">References Load.</param>
        /// <param name="e">Holds Event Data.</param>
        private void ManagerShowTimeForm_Load(object sender, EventArgs e)
        {
            this.showTimeTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.ShowTime);
        }

        /// <summary>
        /// Closes Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
