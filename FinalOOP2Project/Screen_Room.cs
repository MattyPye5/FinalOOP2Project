namespace FinalOOP2Project
{
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Screen Room Class.
    /// </summary>
    public class Screen_Room
    {
        /// <summary>
        /// New Instance of Movies.
        /// </summary>
        Movies myMovie = new Movies();

        /// <summary>
        /// Initalizes DataclassDataContext to access LINQ Features.
        /// </summary>
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();

        /// <summary>
        /// Create/Initalize Room List.
        /// </summary>
        private List<int> roomList = new List<int>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Screen_Room"/> class.
        /// Method for ScreenRoom.
        /// </summary>
        public Screen_Room()
        {
        }

        /// <summary>
        /// Creates List that holds room numbers.
        /// </summary>
        /// <returns> roomList. </returns>
        public List<int> GetRoomNo()
        {
            foreach (ScreenRoom item in db.ScreenRooms)
            {
                roomList.Add(item.RoomNo);
            }

            return roomList;
        }
    }
}
