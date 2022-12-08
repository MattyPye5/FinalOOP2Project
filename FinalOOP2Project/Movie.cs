namespace FinalOOP2Project
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Movie Class.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Creating Lists accoiated with Movie Properties
        /// </summary>
        private List<int> movieIdList = new List<int>();
        private List<string> movieNameList = new List<string>();
        private List<string> genreList = new List<string>();
        private List<int> yearList = new List<int>();
        private List<string> actorList = new List<string>();

        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// Initializes a new instance of the <see cref="Movie"/> class.
        /// Movie Method
        /// </summary>
        public Movie()
        {
        }

        /// <summary>
        /// Intalize get/set for MovieName Property.
        /// </summary>
        public string MovieName { get; set; }

        /// <summary>
        /// Intalize get/set for MovieId Property.
        /// </summary>
        public int MovieId { get; }

        /// <summary>
        /// Intalize get/set for Genre Property.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Intalize get/set for MDateOfRelease Property.
        /// </summary>
        public DateTime DateOfRelease { get; set; }

        /// <summary>
        /// Intalize get/set for Actor Property.
        /// </summary>
        public string Actor { get; set; }

        /// <summary>
        /// Intalize get/set for MovieIdList List.
        /// </summary>
        public List<int> MovieIdList { get;set; }

        /// <summary>
        /// Intalize get/set for MovieNameList List.
        /// </summary>
        public List<string> MovieNameList { get; set; }

        /// <summary>
        /// Intalize get/set for GnereList List.
        /// </summary>
        public List<string> GenreList { get; set; }

        /// <summary>
        /// Intalize get/set for YearList List.
        /// </summary>
        public List<int> YearList { get; set; }

        /// <summary>
        /// Intalize get/set for ActorList List.
        /// </summary>
        public List<string> ActorList { get; set; }

        /// <summary>
        /// Adds Movies to MoiveList
        /// </summary>
        public void GetMovieId()
        {
            foreach (Movies item in db.Movies)
            {
                movieIdList.Add(item.MovieId);
            }

        }

        /// <summary>
        /// Creates MovieNameList.
        /// </summary>
        /// <returns> MovieNameList. </returns>

        public List<string> GetMovieName()
        {

            foreach (Movies item in db.Movies)
            {
                this.movieNameList.Add(item.MovieName);
            }

            return movieNameList;
        }

        /// <summary>
        /// Creates Actor List.
        /// </summary>
        /// <returns> ActorList. </returns>

        public List<string> GetActor()
        {
            foreach (Movies item in db.Movies)
            {
                actorList.Add(item.Actors);
            }

            return actorList;
        }

        /// <summary>
        /// Creates Year List.
        /// </summary>
        /// <returns> YearList. </returns>

        public List<int> GetDateOfRelease()
        {
            foreach (Movies item in db.Movies)
            {
                yearList.Add((item.DateOfRelease));
            }

            return yearList;
        }

        /// <summary>
        /// Creates Genre List.
        /// </summary>
        /// <returns> genreList. </returns>
        public List<string> GetGenre()
        {
            foreach (Movies item in db.Movies)
            {
                genreList.Add(item.Genre);
            }

            return genreList;
        }
    }
}
