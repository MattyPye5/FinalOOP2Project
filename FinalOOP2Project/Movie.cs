using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOP2Project
{
    internal class Movie
    {
        private List<int> movieIdList = new List<int>();
        private List<string> movieNameList = new List<string>();
        private List<string> genreList = new List<string>();
        private List<int> yearList = new List<int>();
        private List<string> actorList = new List<string>();
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        private string movieName;
        private int movieId;
        private string genre;
        private DateTime dateOfRelease;
        private string actor;
        private bool isSelected = false;

        public Movie() { }
        public string MovieName { get; set; }
        public int MovieId { get; }
        public string Genre { get; set; }

        public DateTime DateOfRelease { get; set; }
        public string Actor { get; set; }
        public List<int> MovieIdList { get;set; }
        public List<string> MovieNameList { get; set; }
        public List<string> GenreList { get; set; }
        public List<int> YearList { get; set; }
        public List<string> ActorList { get; set; }
       // public
        public void GetMovieId()
        {
            foreach (Movies item in db.Movies)
            {
                movieIdList.Add(item.MovieId);
            }

        }

        public List<string> GetMovieName()
        {

            foreach (Movies item in db.Movies)
            {
                this.movieNameList.Add(item.MovieName);
                 //MessageBox.Show(item.MovieName);
            }

            return movieNameList;
        }
        public List<string> GetActor()
        {

            foreach (Movies item in db.Movies)
            {
                actorList.Add(item.Actors);
                // MessageBox.Show(item.Genre);
            }
            return actorList;
        }
        public List<int> GetDateOfRelease()
        {
            foreach (Movies item in db.Movies)
            {
                yearList.Add((item.DateOfRelease));
                // MessageBox.Show(item.Genre);
            }
            return yearList;
        }
        public List<string> GetGenre()
        {

            foreach (Movies item in db.Movies)
            {
                genreList.Add(item.Genre);
                //  MessageBox.Show(item.Genre);
            }
            return genreList;
        }
    }
}
    

