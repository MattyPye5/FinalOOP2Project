namespace FinalOOP2Project
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Initalizes Main Client Form Class.
    /// </summary>
    public partial class ClientForm : Form
    {
        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// Creates Lists for all required fields in Client Form.
        /// </summary>
        List<string> movieNameList = new List<string>();
        List<string> genreList = new List<string>();
        List<string> actorList = new List<string>();
        List<int> yearList = new List<int>();
        List<int> screenRoomList = new List<int>();
        List<DateTime> showtimeList = new List<DateTime>();

        /// <summary>
        /// Creates Assocations and Initalizes Required Classes.
        /// </summary>
        Screen_Room myRoom = new Screen_Room();
        ListViewItem list = new ListViewItem();
        Movie myMovie = new Movie();
        ShowtimeClass time = new ShowtimeClass();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientForm"/> class.
        /// Creates Instance of Client Form.
        /// </summary>
        public ClientForm()
        {
            // Loads Form.
            InitializeComponent();
        }

        /// <summary>
        /// Loads All required items into ClientForm ListView.
        /// </summary>
        /// <param name="sender">References Load.</param>
        /// <param name="e">Holds Event Data.</param>
        private void ClientFormcs_Load(object sender, EventArgs e)
        {
            // Trys Loading Information
            try
            {
                movieNameList = myMovie.GetMovieName();
                genreList = myMovie.GetGenre();
                actorList = myMovie.GetActor();
                yearList = myMovie.GetDateOfRelease();
                screenRoomList = myRoom.GetRoomNo();
                showtimeList = time.GetShowTime();

                // Trys Filling List
                try
                {
                    for (int i = 0; i <= movieNameList.Count; i++)
                    {
                        ListViewItem listi = new ListViewItem(movieNameList[i]);

                        listi.SubItems.Add(genreList[i]);
                        listi.SubItems.Add(actorList[i]);
                        listi.SubItems.Add(yearList[i].ToString());
                        listi.SubItems.Add(screenRoomList[i].ToString());
                        listi.SubItems.Add(showtimeList[i].ToString());

                        listView.Items.Add(listi);
                    }
                }
                catch (Exception ex)
                {
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// When Item in ListView is Selected Messagebox Will Show.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("The Ticket price is $20. If you want to continue click on Buy ticket.");
        }

        /// <summary>
        ///  Collects Data Selected from ListView And prepares to send it to E-Ticket Form.
        ///  Incrementally Checks If Data, If Ticket is Avaiable or Not,and loads E-Ticket Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void buyButton_Click(object sender, EventArgs e)
        {
            string movieName = string.Empty;
            int ticket = 0;
            int room = 0;
            DateTime movieShowTime = DateTime.Now;

            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Selected)
                {
                    string movie_name = listView.Items[i].Text;

                    var movieid = from Movie in db.Movies
                                  where Movie.MovieName.Equals(movie_name)
                                  select Movie.MovieId;

                    foreach (var str in movieid)
                    {
                        var ticketid = from MovieTicketUser in db.MovieTicketUsers
                                       where MovieTicketUser.MovieId.Equals(str)
                                       select MovieTicketUser.TicketId;
                        var time = from ShowTime in db.ShowTimes
                                where ShowTime.MovieId.Equals(str)
                                select ShowTime.Time;
                        foreach (var date in time)
                        {
                            movieShowTime = (DateTime)date;
                        }

                        foreach (var tic in ticketid)
                        {
                            var availableTicket = from Ticket in db.Tickets
                                                  where Ticket.ticketId.Equals(tic)
                                                  select Ticket.availability;
                            foreach (var available in availableTicket)
                            {
                                if (available.Equals("sold"))
                                {
                                    MessageBox.Show("There is no ticket available for this movie please choose another one.");
                                }
                                else if (available.Equals("available"))
                                {
                                    MessageBox.Show("available ticket", available);
                                    var ticketNo = from Ticket in db.Tickets
                                                   where Ticket.ticketId.Equals(tic)
                                                   select Ticket.E_ticket;
                                    foreach (var no in ticketNo)
                                    {
                                        ticket = no;
                                    }

                                    movieName = movie_name;
                                    var roomNO = from screenRoom in db.ScreenRooms
                                                 where screenRoom.MovieId.Equals(str)
                                                 select screenRoom.RoomNo;

                                    foreach (var roomno in roomNO)
                                    {
                                        room = roomno;
                                    }

                                    E_TickeForm form = new E_TickeForm(movieName, ticket, room,movieShowTime);
                                    form.ShowDialog();
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Closes Form.
        /// </summary>
        /// <param name="sender">References Button Click.</param>
        /// <param name="e">Holds Event Data.</param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
