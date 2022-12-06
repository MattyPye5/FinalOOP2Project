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
      
        public Screen_Room() { }
        
       
        public List<int> GetRoomNo()
        {

            foreach (ScreenRoom item in db.ScreenRooms)
            {
                MessageBox.Show(item.RoomNo.ToString());
                roomList.Add(item.RoomNo);
            }

            return roomList;
        }
        
      
    }
}

   

