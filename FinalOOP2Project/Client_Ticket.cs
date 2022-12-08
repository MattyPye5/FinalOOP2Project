namespace FinalOOP2Project
{
    /// <summary>
    ///  Client Ticket Class.
    /// </summary>
    public class Client_Ticket
    {
        /// <summary>
        ///  Creates new Instance of Client Form.
        /// </summary>
        ClientForm form = new ClientForm();

        /// <summary>
        /// Initializes a new instance of the <see cref="Client_Ticket"/> class.
        /// Method For Client Ticket.
        /// </summary>
        public Client_Ticket()
        {
        }

        /// <summary>
        /// Creates Get/Set Accessors For Client Ticket Id Property.
        /// </summary>
        public int TicketId { get; set; }

        /// <summary>
        /// Creates Get/Set Accessors For E-Ticket Property.
        /// </summary>
        public int ETicket { get; set; }

        /// <summary>
        /// Creates Get Accessors For Ticket Avaibality Property.
        /// </summary>
        public string Availability { get; }

        /// <summary>
        /// Method For number Of Tickets.
        /// </summary>
        public void TicketsNo()
        {
        }
    }
}
