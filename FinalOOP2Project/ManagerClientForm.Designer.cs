namespace FinalOOP2Project
{
    partial class ManagerClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerClientForm));
            this.managerClientListView = new System.Windows.Forms.ListView();
            this.userNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // managerClientListView
            // 
            this.managerClientListView.BackColor = System.Drawing.SystemColors.Info;
            this.managerClientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userNameColumnHeader,
            this.movieNamecolumnHeader,
            this.ticketNumberColumnHeader});
            this.managerClientListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerClientListView.ForeColor = System.Drawing.Color.Black;
            this.managerClientListView.GridLines = true;
            this.managerClientListView.HideSelection = false;
            this.managerClientListView.Location = new System.Drawing.Point(58, 37);
            this.managerClientListView.Name = "managerClientListView";
            this.managerClientListView.Size = new System.Drawing.Size(573, 304);
            this.managerClientListView.TabIndex = 0;
            this.managerClientListView.UseCompatibleStateImageBehavior = false;
            this.managerClientListView.View = System.Windows.Forms.View.Details;

            // 
            // userNameColumnHeader
            // 
            this.userNameColumnHeader.Text = "Client Name";
            this.userNameColumnHeader.Width = 144;
            // 
            // movieNamecolumnHeader
            // 
            this.movieNamecolumnHeader.Text = "Movie Name";
            this.movieNamecolumnHeader.Width = 191;
            // 
            // ticketNumberColumnHeader
            // 
            this.ticketNumberColumnHeader.Text = "Ticket Number";
            this.ticketNumberColumnHeader.Width = 145;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(249, 385);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 53);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManagerClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.managerClientListView);
            this.Name = "ManagerClientForm";
            this.Text = "ManagerClientForm";
            this.Load += new System.EventHandler(this.ManagerClientForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView managerClientListView;
        private System.Windows.Forms.ColumnHeader userNameColumnHeader;
        private System.Windows.Forms.ColumnHeader movieNamecolumnHeader;
        private System.Windows.Forms.ColumnHeader ticketNumberColumnHeader;
        private System.Windows.Forms.Button exitButton;
    }
}