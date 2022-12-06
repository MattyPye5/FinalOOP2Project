using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOOP2Project
{
    class ShowtimeClass
    {
        MovieTheatreDataClassDataContext db = new MovieTheatreDataClassDataContext();
        private List<DateTime> timeList= new List<DateTime>();

        public List<DateTime> GetShowTime()
        {

            foreach (ShowTime item in db.ShowTimes)
            {
                MessageBox.Show(item.Time.ToString());
                timeList.Add((DateTime)item.Time);
            }

            return timeList;
        }
    }
}
