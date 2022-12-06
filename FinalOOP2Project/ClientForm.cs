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
    public partial class ClientForm : Form
    {
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
        List<string> movieNameList = new List<string>();
        List<string> genreList = new List<string>();
        List<string> actorList = new List<string>();
        List<int> yearList = new List<int>();
        List<int> screenRoomList = new List<int>();
        List<DateTime> showtimeList = new List<DateTime>();
        Screen_Room myRoom = new Screen_Room();
        ListViewItem list = new ListViewItem();
        Movie myMovie = new Movie();
        ShowtimeClass time=new ShowtimeClass();

        // Client_Ticket ticket=new Client_Ticket();

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientFormcs_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
            try
            {
                movieNameList = myMovie.GetMovieName();
                genreList = myMovie.GetGenre();
                actorList = myMovie.GetActor();
                yearList = myMovie.GetDateOfRelease();
                screenRoomList = myRoom.GetRoomNo();
                showtimeList=time.GetShowTime();
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
                catch (Exception ex) { }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("The Ticket price is $20. If you want to continue click on Buy ticket.");
        }
        private void buyButton_Click(object sender, EventArgs e)
        {
            string movieName="";
            int ticket = 0;
            int room=0;
            DateTime movieShowTime = DateTime.Now;


            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Selected)
                {
                    // MessageBox.Show(listView.Items[i].Text);

                    string movie_name = listView.Items[i].Text;

                    var movieid = from Movie in db.Movies
                                  where Movie.MovieName.Equals(movie_name)
                                  select Movie.MovieId;


                    foreach (var str in movieid)
                    {
                        MessageBox.Show("movieId:" + str);
                        var ticketid = from MovieTicketUser in db.MovieTicketUsers
                                       where MovieTicketUser.MovieId.Equals(str)
                                       select MovieTicketUser.TicketId;
                       var time=from ShowTime in db.ShowTimes
                                where ShowTime.MovieId.Equals(str)
                                select ShowTime.Time;
                        foreach(var date in time)
                        {
                            MessageBox.Show("date" + date);
                            movieShowTime = (DateTime)date;
                        }
                                

                        foreach (var tic in ticketid)
                        {
                            MessageBox.Show("ticketId:" + tic);
                            var availableTicket = from Ticket in db.Tickets
                                                  where Ticket.ticketId.Equals(tic) 
                                                  select Ticket.availability;
                            foreach(var available in availableTicket )
                            {
                                if (available.Equals("sold"))
                                {
                                    MessageBox.Show("There is no ticket available for this movie please choose another one.");
                                }
                                else if (available.Equals("available"))
                                {
                                    MessageBox.Show("available", available);
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

