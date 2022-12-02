using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalOOP2Project
{
    internal class Client_Ticket
    {
        public Client_Ticket() { }
        public int TicketId { get; set; }
        public int ETicket { get; set; }

        public string Availability { get; }


       /* public string TicketsAvailable()
        {
            MovieTheatreDataClassDataContext db= new MovieTheatreDataClassDataContext();
           



            return IsAvailable;
        }*/


    }
   
}
