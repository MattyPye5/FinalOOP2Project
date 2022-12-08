namespace FinalOOP2Project
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// Unfinished Code Here to show attempts at progress.

    public partial class ManagerClientForm : Form
    {
    //    MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
    //     UserClass myClass= new UserClass();
    //    Movie myMovie = new Movie();
    //      E_TickeForm form = new E_TickeForm("", 0,0,DateTime.Now);
    //    public List<string> userNameList = new List<string>();
    //      public List<string> movieNameList = new List<string>();
    //    public List<int> ticketNoList = new List<int>();

        /// <summary>
        /// Creates ManagerClientForm
        /// </summary>
        public ManagerClientForm()
        {
            // Builds Form.
            InitializeComponent();
        }

        //    private void backButton_Click(object sender, EventArgs e)
        //    {
        //        ManagerForm form = new ManagerForm();
        //        form.ShowDialog();
        //    }

        /// <summary>
        ///  Exits Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds event data</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void ManagerClientForm_Load(object sender, EventArgs e)
        {

    //         ticketNoList.Add(int.Parse(form.ticketNoOutputLabel.Text));
    //        try
    //        {
    //            for (int i = 0; i <= userNameList.Count; i++)
    //            {
    //                ListViewItem listi = new ListViewItem(form.userNameList[i].ToString());

    //                 listi.SubItems.Add(form.movieNameList[i].ToString());
    //                 listi.SubItems.Add(form.ticketNoList[i].ToString());
    //                managerClientListView.Items.Add(listi);

    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //        }
        }
    }
}
