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
    public partial class ScreenRoomForm : Form
    {
        public ScreenRoomForm()
        {
            InitializeComponent();
        }

        private void screenRoomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.screenRoomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);

        }

        private void ScreenRoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.ScreenRoom' table. You can move, or remove it, as needed.
            this.screenRoomTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.ScreenRoom);

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ManagerForm mF=new ManagerForm();
            mF.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
