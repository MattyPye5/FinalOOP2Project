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
    public partial class ManagerMovieListForm : Form
    {
        public ManagerMovieListForm()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movie_FinalDB_ProjectDataSet);

        }

        private void ManagerMovieListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movie_FinalDB_ProjectDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.movie_FinalDB_ProjectDataSet.Movies);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
