namespace FinalOOP2Project
{
    partial class ClientMovieList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMovieList));
            this.movie_FinalDB_ProjectDataSet1 = new FinalOOP2Project.Movie_FinalDB_ProjectDataSet();
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter1 = new FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager1 = new FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager();
            this.moviesBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moviesBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.moviesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movie_FinalDB_ProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1BindingNavigator)).BeginInit();
            this.moviesBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_FinalDB_ProjectDataSet1
            // 
            this.movie_FinalDB_ProjectDataSet1.DataSetName = "Movie_FinalDB_ProjectDataSet";
            this.movie_FinalDB_ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.movie_FinalDB_ProjectDataSet1;
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ManagerTableAdapter = null;
            this.tableAdapterManager1.MoviesTableAdapter = this.moviesTableAdapter1;
            this.tableAdapterManager1.MovieTicketUserTableAdapter = null;
            this.tableAdapterManager1.ScreenRoomTableAdapter = null;
            this.tableAdapterManager1.ShowTimeTableAdapter = null;
            this.tableAdapterManager1.TicketTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableAdapter = null;
            // 
            // moviesBindingSource1BindingNavigator
            // 
            this.moviesBindingSource1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moviesBindingSource1BindingNavigator.BindingSource = this.moviesBindingSource1;
            this.moviesBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moviesBindingSource1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moviesBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.moviesBindingSource1BindingNavigatorSaveItem});
            this.moviesBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moviesBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moviesBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moviesBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moviesBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moviesBindingSource1BindingNavigator.Name = "moviesBindingSource1BindingNavigator";
            this.moviesBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moviesBindingSource1BindingNavigator.Size = new System.Drawing.Size(564, 25);
            this.moviesBindingSource1BindingNavigator.TabIndex = 0;
            this.moviesBindingSource1BindingNavigator.Text = "bindingNavigator1";

            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // moviesBindingSource1BindingNavigatorSaveItem
            // 
            this.moviesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moviesBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesBindingSource1BindingNavigatorSaveItem.Image")));
            this.moviesBindingSource1BindingNavigatorSaveItem.Name = "moviesBindingSource1BindingNavigatorSaveItem";
            this.moviesBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.moviesBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            this.moviesBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.moviesBindingSource1BindingNavigatorSaveItem_Click_1);
            // 
            // moviesDataGridView1
            // 
            this.moviesDataGridView1.AutoGenerateColumns = false;
            this.moviesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.moviesDataGridView1.DataSource = this.moviesBindingSource1;
            this.moviesDataGridView1.Location = new System.Drawing.Point(12, 28);
            this.moviesDataGridView1.Name = "moviesDataGridView1";
            this.moviesDataGridView1.Size = new System.Drawing.Size(540, 220);
            this.moviesDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn6.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MovieName";
            this.dataGridViewTextBoxColumn7.HeaderText = "MovieName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn8.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateOfRelease";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateOfRelease";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Actors";
            this.dataGridViewTextBoxColumn10.HeaderText = "Actors";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(12, 275);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(154, 43);
            this.buyButton.TabIndex = 14;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(398, 275);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(154, 43);
            this.logoutButton.TabIndex = 15;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ClientMovieList
            // 
            this.ClientSize = new System.Drawing.Size(564, 350);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.moviesDataGridView1);
            this.Controls.Add(this.moviesBindingSource1BindingNavigator);
            this.Name = "ClientMovieList";
            this.Load += new System.EventHandler(this.ClientMovieList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movie_FinalDB_ProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1BindingNavigator)).EndInit();
            this.moviesBindingSource1BindingNavigator.ResumeLayout(false);
            this.moviesBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private Movie_FinalDB_ProjectDataSet movie_FinalDB_ProjectDataSet;
        private System.Windows.Forms.BindingSource showTimeBindingSource;
        private Movie_FinalDB_ProjectDataSetTableAdapters.ShowTimeTableAdapter showTimeTableAdapter;
        private Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private Movie_FinalDB_ProjectDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridView moviesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Movie_FinalDB_ProjectDataSet movie_FinalDB_ProjectDataSet1;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private Movie_FinalDB_ProjectDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter1;
        private Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator moviesBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton moviesBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView moviesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button logoutButton;
    }
}