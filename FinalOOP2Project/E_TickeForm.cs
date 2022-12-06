using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalOOP2Project
{
    public partial class E_TickeForm : Form
    {
       
        
       
        public E_TickeForm(string text,int ticketNo,int roomNo,DateTime movieShowTime)
        {
            InitializeComponent();
            movieOutputLabel.Text = text;
            ticketNoOutputLabel.Text=ticketNo.ToString();
            roomNoOutputlabel.Text=roomNo.ToString();
            timeOutputLabel.Text=movieShowTime.ToString();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
     
            

