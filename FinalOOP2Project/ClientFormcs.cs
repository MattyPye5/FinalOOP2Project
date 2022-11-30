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
    public partial class ClientFormcs : Form
    {
        public ClientFormcs()
        {

            List<string> movieNameList = new List<string>();
            List<string> genreList = new List<string>();
            List<string> actorList = new List<string>();
            List<int> yearList = new List<int>();
            List<string> screenRoomList = new List<string>();
            List<string> showtimeList = new List<string>();
            Screen_Room myRoom = new Screen_Room();
            ListViewItem list = new ListViewItem();
            Movie myMovie = new Movie();
            MoviesTableAdapter movies = new MoviesTableAdapter();
            //List<Movie> moviesList = new List<Movie>();
            List<string> movieList = new List<string>();
            List<Movies> myList = new List<Movies>();
            List<List<string>> myMovieList = new List<List<string>>();
            public ClientForm()
            {
                InitializeComponent();

                // MessageBox.Show("Hello");
                // List<string> movie = myMovie.GetMovieName();
                // foreach (string movieName in movie)
                {
                    //     MessageBox.Show("MovieName",movieName);
                }
            }


            private void ClientForm_Load(object sender, EventArgs e)
            {



                // TODO: This line of code loads data into the 'movieTheatreDataSet.ScreenRoom' table. You can move, or remove it, as needed.
                this.screenRoomTableAdapter.Fill(this.movieTheatreDataSet.ScreenRoom);
                // TODO: This line of code loads data into the 'movieTheatreDataSet.Movies' table. You can move, or remove it, as needed.
                // this.moviesTableAdapter.Fill(this.movieTheatreDataSet.Movies);
                // MessageBox.Show(clientMoviesListViewItem.Columns.Count.ToString());
                try
                {
                    movieNameList = myMovie.GetMovieName();
                    genreList = myMovie.GetGenre();
                    actorList = myMovie.GetActor();
                    yearList = myMovie.GetDateOfRelease();
                    for (int i = 0; i < movieNameList.Count; i++)
                    {

                        ListViewItem listi = new ListViewItem(movieNameList[i]);
                        listi.SubItems.Add(genreList[i]);
                        listi.SubItems.Add(actorList[i]);
                        listi.SubItems.Add(yearList[i].ToString());

                        listView.Items.Add((listi));


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

            private void listView_SelectedIndexChanged(object sender, EventArgs e)
            {
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    if (listView.Items[i].Selected)
                    {
                        MessageBox.Show(listView.Items[i].ToString());
                        // MessageBox.Show("Hello");
                        // int roomNoi=  myRoom.GetRoomNo();
                        //  int screenMovieIdi=  myRoom.GetMovieId();
                        //  int movieMovieIdi=myMovie.GetMovieId();
                        // if(screenMovieIdi==movieMovieIdi)
                        {
                            //   MessageBox.Show("RoomNo",roomNoi.ToString());
                        }
                        //MessageBox.Show(roomNo);
                    }
                }
            }
        }
    }
}
    }
}
