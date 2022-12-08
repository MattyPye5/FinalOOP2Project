namespace FinalOOP2Project
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Showtime Class.
    /// </summary>
    public class ShowtimeClass
    {
        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// Creates TimeList.
        /// </summary>
        private List<DateTime> timeList= new List<DateTime>();

        /// <summary>
        /// Fills TimeList From DataBase.
        /// </summary>
        /// <returns> TimeList. </returns>
        public List<DateTime> GetShowTime()
        {

            foreach (ShowTime item in db.ShowTimes)
            {
                timeList.Add((DateTime)item.Time);
            }

            return timeList;
        }
    }
}
