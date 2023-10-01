using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedetTeam12
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int SalesRackId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public int Weeks { get; set; }

        public Booking(int salesRackId, DateTime startDate, DateTime endDate)
        {
            BookingId = Controller.BookingList.Count + 1;
            SalesRackId = salesRackId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
