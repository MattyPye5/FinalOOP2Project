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
    public partial class ClientMovieList : Form
    {
        public ClientMovieList()
        {
            InitializeComponent();
        }

        private void showTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showTimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);

        }

        private void ManagerShowTime_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Movies);
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Movies);
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.ShowTime);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void moviesBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.movie_FinalDB_ProjectDataSet1);

        }

        private void moviesBindingSource1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.movie_FinalDB_ProjectDataSet1);

        }

        private void ClientMovieList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter1.Fill(this.movie_FinalDB_ProjectDataSet1.Movies);

        }

        private void moviesBindingSource1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
