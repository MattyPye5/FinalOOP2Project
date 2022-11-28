namespace FinalOOP2Project
{
    partial class ManagerShowTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerShowTime));
            this.closeButton = new System.Windows.Forms.Button();
            this.movie_FinalDB_ProjectDataSet = new FinalOOP2Project.Movie_FinalDB_ProjectDataSet();
            this.showTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showTimeTableAdapter = new FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.ShowTimeTableAdapter();
            this.tableAdapterManager = new FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager();
            this.showTimeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.showTimeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.movie_FinalDB_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingNavigator)).BeginInit();
            this.showTimeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeButton.Location = new System.Drawing.Point(98, 267);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(111, 47);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // movie_FinalDB_ProjectDataSet
            // 
            this.movie_FinalDB_ProjectDataSet.DataSetName = "Movie_FinalDB_ProjectDataSet";
            this.movie_FinalDB_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showTimeBindingSource
            // 
            this.showTimeBindingSource.DataMember = "ShowTime";
            this.showTimeBindingSource.DataSource = this.movie_FinalDB_ProjectDataSet;
            // 
            // showTimeTableAdapter
            // 
            this.showTimeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = null;
            this.tableAdapterManager.MovieTicketUserTableAdapter = null;
            this.tableAdapterManager.ScreenRoomTableAdapter = null;
            this.tableAdapterManager.ShowTimeTableAdapter = this.showTimeTableAdapter;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // showTimeBindingNavigator
            // 
            this.showTimeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.showTimeBindingNavigator.BindingSource = this.showTimeBindingSource;
            this.showTimeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.showTimeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.showTimeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.showTimeBindingNavigatorSaveItem});
            this.showTimeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.showTimeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.showTimeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.showTimeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.showTimeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.showTimeBindingNavigator.Name = "showTimeBindingNavigator";
            this.showTimeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.showTimeBindingNavigator.Size = new System.Drawing.Size(326, 25);
            this.showTimeBindingNavigator.TabIndex = 2;
            this.showTimeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // showTimeBindingNavigatorSaveItem
            // 
            this.showTimeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showTimeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("showTimeBindingNavigatorSaveItem.Image")));
            this.showTimeBindingNavigatorSaveItem.Name = "showTimeBindingNavigatorSaveItem";
            this.showTimeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.showTimeBindingNavigatorSaveItem.Text = "Save Data";
            this.showTimeBindingNavigatorSaveItem.Click += new System.EventHandler(this.showTimeBindingNavigatorSaveItem_Click);
            // 
            // showTimeDataGridView
            // 
            this.showTimeDataGridView.AutoGenerateColumns = false;
            this.showTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.showTimeDataGridView.DataSource = this.showTimeBindingSource;
            this.showTimeDataGridView.Location = new System.Drawing.Point(12, 28);
            this.showTimeDataGridView.Name = "showTimeDataGridView";
            this.showTimeDataGridView.Size = new System.Drawing.Size(300, 220);
            this.showTimeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ShowTimeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ShowTimeId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn2.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ScreenRoomId";
            this.dataGridViewTextBoxColumn3.HeaderText = "ScreenRoomId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ManagerShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 329);
            this.Controls.Add(this.showTimeDataGridView);
            this.Controls.Add(this.showTimeBindingNavigator);
            this.Controls.Add(this.closeButton);
            this.Name = "ManagerShowTime";
            this.Text = "ManagerShowTime";
            this.Load += new System.EventHandler(this.ManagerShowTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movie_FinalDB_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingNavigator)).EndInit();
            this.showTimeBindingNavigator.ResumeLayout(false);
            this.showTimeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private Movie_FinalDB_ProjectDataSet movie_FinalDB_ProjectDataSet;
        private System.Windows.Forms.BindingSource showTimeBindingSource;
        private Movie_FinalDB_ProjectDataSetTableAdapters.ShowTimeTableAdapter showTimeTableAdapter;
        private Movie_FinalDB_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator showTimeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton showTimeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView showTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}