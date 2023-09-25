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
        public int Weeks { get; set; }

        public Booking(DateTime startDate, int weeks)
        {
            BookingId = Controller.BookingList.Count +1;
            //this.SalesRackId = salesRackId; //not used
            this.StartDate = startDate;
            this.Weeks = weeks;
        }
    }
}
