namespace FinalOOP2Project
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.listView = new System.Windows.Forms.ListView();
            this.movieNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actorColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.screenRoomColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.screenRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buyButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenRoomBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.SystemColors.Info;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieNameColumnHeader,
            this.GenreColumnHeader,
            this.actorColumnHeader,
            this.yearColumnHeader,
            this.screenRoomColumnHeader,
            this.showTimeColumnHeader});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 30);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 237);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // movieNameColumnHeader
            // 
            this.movieNameColumnHeader.Text = "MovieName";
            this.movieNameColumnHeader.Width = 155;
            // 
            // GenreColumnHeader
            // 
            this.GenreColumnHeader.Text = "Genre";
            this.GenreColumnHeader.Width = 134;
            // 
            // actorColumnHeader
            // 
            this.actorColumnHeader.Text = "Actors";
            this.actorColumnHeader.Width = 119;
            // 
            // yearColumnHeader
            // 
            this.yearColumnHeader.Text = "Year";
            this.yearColumnHeader.Width = 113;
            // 
            // screenRoomColumnHeader
            // 
            this.screenRoomColumnHeader.Text = "Screen Room";
            this.screenRoomColumnHeader.Width = 123;
            // 
            // showTimeColumnHeader
            // 
            this.showTimeColumnHeader.Text = "Show Time";
            this.showTimeColumnHeader.Width = 159;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            // 
            // screenRoomBindingSource
            // 
           // this.screenRoomBindingSource.DataMember = "FK__ScreenRoo__Movie__04E4BC85";
            this.screenRoomBindingSource.DataSource = this.moviesBindingSource;
            // 
            // moviesBindingSource1
            // 
           // this.moviesBindingSource1.DataMember = "Movies";
            // 
            // buyButton
            // 
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.IndianRed;
            this.buyButton.Location = new System.Drawing.Point(123, 353);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(182, 53);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "Buy a ticket";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.IndianRed;
            this.logoutButton.Location = new System.Drawing.Point(572, 353);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(182, 53);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ClientFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.listView);
            this.Name = "ClientFormcs";
            this.Text = "ClientFormcs";
            this.Load += new System.EventHandler(this.ClientFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenRoomBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader movieNameColumnHeader;
        private System.Windows.Forms.ColumnHeader GenreColumnHeader;
        private System.Windows.Forms.ColumnHeader actorColumnHeader;
        private System.Windows.Forms.ColumnHeader yearColumnHeader;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private System.Windows.Forms.BindingSource screenRoomBindingSource;
       // private System.Windows.Forms.BindingSource moviesBindingSource1;
        private System.Windows.Forms.ColumnHeader screenRoomColumnHeader;
        private System.Windows.Forms.ColumnHeader showTimeColumnHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button logoutButton;
    }
}