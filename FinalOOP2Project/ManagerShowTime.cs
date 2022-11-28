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
    public partial class ManagerShowTime : Form
    {
        public ManagerShowTime()
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
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.ShowTime);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
