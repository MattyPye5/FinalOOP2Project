namespace FinalOOP2Project
{
    partial class Form1
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
            this.managerLoginOpenLabel = new System.Windows.Forms.Label();
            this.registerOpenLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managerLoginOpenLabel
            // 
            this.managerLoginOpenLabel.AutoSize = true;
            this.managerLoginOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLoginOpenLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.managerLoginOpenLabel.Location = new System.Drawing.Point(105, 387);
            this.managerLoginOpenLabel.Name = "managerLoginOpenLabel";
            this.managerLoginOpenLabel.Size = new System.Drawing.Size(78, 13);
            this.managerLoginOpenLabel.TabIndex = 15;
            this.managerLoginOpenLabel.Text = "Manager Login";
            this.managerLoginOpenLabel.Click += new System.EventHandler(this.managerLoginOpenLabel_Click);
            // 
            // registerOpenLabel
            // 
            this.registerOpenLabel.AutoSize = true;
            this.registerOpenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerOpenLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.registerOpenLabel.Location = new System.Drawing.Point(68, 325);
            this.registerOpenLabel.Name = "registerOpenLabel";
            this.registerOpenLabel.Size = new System.Drawing.Size(158, 13);
            this.registerOpenLabel.TabIndex = 14;
            this.registerOpenLabel.Text = "Not Already A User? Click Here!";
            this.registerOpenLabel.Click += new System.EventHandler(this.registerOpenLabel_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(71, 341);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(154, 43);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(25, 225);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(82, 20);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(20, 133);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 20);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "Username:";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(20, 248);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(269, 35);
            this.passTextBox.TabIndex = 10;
            // 
            // userTextBox
            // 
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(20, 156);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(269, 35);
            this.userTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 450);
            this.Controls.Add(this.managerLoginOpenLabel);
            this.Controls.Add(this.registerOpenLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managerLoginOpenLabel;
        private System.Windows.Forms.Label registerOpenLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label1;
    }
}

