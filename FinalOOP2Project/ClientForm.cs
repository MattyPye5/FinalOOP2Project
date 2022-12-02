using FinalOOP2Project.Movie_FinalDB_ProjectDataSetTableAdapters;
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
        List<string> showtimeList = new List<string>();
        Screen_Room myRoom = new Screen_Room();
        ListViewItem list = new ListViewItem();
        Movie myMovie = new Movie();
       
        List<Movie> moviesList = new List<Movie>();
        List<string> movieList = new List<string>();
        List<Movies> myList = new List<Movies>();
        List<List<string>> myMovieList = new List<List<string>>();
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientFormcs_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            try
            {
                movieNameList = myMovie.GetMovieName();
                genreList = myMovie.GetGenre();
                actorList = myMovie.GetActor();
                yearList = myMovie.GetDateOfRelease();
                screenRoomList=myRoom.GetRoomNo();
                try
                {
                    for (int i = 0; i <= movieNameList.Count; i++)
                    {
                        ListViewItem listi = new ListViewItem(movieNameList[i]);

                        listi.SubItems.Add(genreList[i]);
                        listi.SubItems.Add(actorList[i]);
                        listi.SubItems.Add(yearList[i].ToString());
                        listi.SubItems.Add(screenRoomList[i].ToString());

                        listView.Items.Add(listi);


                    }
                }catch(Exception ex) { }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (listView.Items[i].Selected)
                {
                    MessageBox.Show(listView.Items[i].Text);
                    string movie_name = listView.Items[i].Text;
                    MessageBox.Show(movie_name);
                    var movieId = from Movie in db.Movies
                                  where Movie.MovieName==movie_name
                                  select Movie.MovieId;
                   
                    foreach (var item in movieId)
                    {
                        MessageBox.Show(item.ToString());
                        var myTicketId = from Movie in db.MovieTicketUsers
                                       where Movie.MovieId == item
                                       select Movie.TicketId;

                        foreach (var id in myTicketId)
                        {
                            MessageBox.Show(id.ToString());
                            var ticketNo = from Movie in db.Tickets
                                           where Movie.ticketId == id
                                           select Movie.E_ticket;

                            foreach (var no in ticketNo)
                            {
                                MessageBox.Show(no.ToString());
                            }
                        }
                    }

                   
                }

            }
           
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            E_TickeForm form = new E_TickeForm();
            form.ShowDialog();
        }
    }
}
