using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Movie() { }
        public string MovieName { get; set; }
        public int MovieId { get; }
        public string Genre { get; set; }

        public DateTime DateOfRelease { get; set; }
        public string Actor { get; set; }
        public List<int> MovieIdList = new List<int>();
        public List<string> MovieNameList = new List<string>();
        public List<string> GenreList = new List<string>();
        public List<int> YearList = new List<int>();
        public List<string> ActorList = new List<string>();
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
                movieNameList.Add(item.MovieName);
                // MessageBox.Show(item.MovieName);
            }

            return movieNameList;
        }
        public List<string> GetActor()
        {

            foreach (Movies item in db.Movies)
            {
                ActorList.Add(item.Actors);
                // MessageBox.Show(item.Genre);
            }
            return ActorList;
        }
        public List<int> GetDateOfRelease()
        {
            foreach (Movies item in db.Movies)
            {
                YearList.Add((item.DateOfRelease));
                // MessageBox.Show(item.Genre);
            }
            return YearList;
        }
        public List<string> GetGenre()
        {

            foreach (Movies item in db.Movies)
            {
                GenreList.Add(item.Genre);
                //  MessageBox.Show(item.Genre);
            }
            return GenreList;
        }
    }
}
    

