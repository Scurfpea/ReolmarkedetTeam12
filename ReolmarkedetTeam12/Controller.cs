using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReolmarkedetTeam12
{
    public class Controller
    {
        public static List<SalesRack> SalesRackList = new List<SalesRack>();
        public static List<SalesRackRenter> SalesRackRenterList = new List<SalesRackRenter>();
        public static List<Booking> BookingList = new List<Booking>();
        public void AddToList(SalesRackRenter salesRackRenter)
        {
            SalesRackRenterList.Add(salesRackRenter);
            //Debug.WriteLine($"{salesRackRenter.Name}, {salesRackRenter.Email}, {salesRackRenter.TelephoneNumber}");// salesRackRenter.Name, salesRackRenter.Email, salesRackRenter.TelephoneNumber); //check if it works.
        }
        public static void AddToList(SalesRack salesRack)
        {
            SalesRackList.Add(salesRack);
        }
        
        public static void AddToList(Booking booking)
        {
            BookingList.Add(booking);
            //Debug.WriteLine(@"{0}, {1}, {2}", booking.BookingId, booking.StartDate, booking.Weeks); //check if it works.
        }
    }
}
