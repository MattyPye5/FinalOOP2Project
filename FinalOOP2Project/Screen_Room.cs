using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOP2Project
{
    internal class Screen_Room
    {
        Movies myMovie = new Movies();
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
       
        //ScreenRoomDataContext sdb = new ScreenRoomDataContext();
        private List<int> roomList = new List<int>();
        private List<int> srMovieId = new List<int>();
        public Screen_Room() { }
        private int roomNo;
        private int movieId;
        public int ScreenRoomId { get; set; }
        public int MovieId { get; set; }
        public int RoomNo { get; set; }
        public int TotalSeatNo { get; set; }
        public List<int> RoomIds { get; set; }
        public List<int> SRMovieID { get; set; }

        public List<int> GetRoomNo()
        {

            foreach (ScreenRoom item in db.ScreenRooms)
            {
                MessageBox.Show(item.RoomNo.ToString());
                roomList.Add(item.RoomNo);
            }

            return roomList;
        }
        public List<int> GetMovieId()
        {
            foreach (ScreenRoom item in db.ScreenRooms)
            {
                srMovieId.Add(item.MovieId);
                MessageBox.Show("screenmovieId", item.MovieId.ToString());
            }

            return srMovieId;
        }
        //  public int GetRoomNoForSelectedMovie()
        // {

        //    myMovie.
        //  }
    }
}

   

