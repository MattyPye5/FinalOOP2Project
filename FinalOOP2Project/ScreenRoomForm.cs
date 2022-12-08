namespace FinalOOP2Project
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Class For Manager ScreenRoomForm List Form.
    /// </summary>
    public partial class ScreenRoomForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenRoomForm"/> class.
        /// Method For Loading Form.
        /// </summary>
        public ScreenRoomForm()
        {
            // Loads Form.
            InitializeComponent();
        }

        /// <summary>
        /// DataGridView Controls, Saves Data, Deletes and modifies table information.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void screenRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screenRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);
        }

        /// <summary>
        /// Collects Data From Database.
        /// </summary>
        /// <param name="sender">References Load.</param>
        /// <param name="e">Holds Event Data.</param>
        private void ScreenRoomForm_Load(object sender, EventArgs e)
        {
            this.screenRoomTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.ScreenRoom);
        }

        /// <summary>
        /// Returns To Main Manager Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void backButton_Click(object sender, EventArgs e)
        {
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
