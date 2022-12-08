namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class For Manager Movie List Form.
    /// </summary>
    public partial class ManagerMovieListForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerMovieListForm"/> class.
        /// Method For Loading Form.
        /// </summary>
        public ManagerMovieListForm()
        {
            // Loads Form.
            InitializeComponent();
        }

        /// <summary>
        /// DataGridView Controls, Saves Data, Deletes and modifies table information.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);
        }

        /// <summary>
        /// Collects Data From Database.
        /// </summary>
        /// <param name="sender">References Load.</param>
        /// <param name="e">Holds Event Data.</param>
        private void ManagerMovieListForm_Load(object sender, EventArgs e)
        {
            this.moviesTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Movies);
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
