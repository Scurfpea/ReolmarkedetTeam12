using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedetTeam12
{
    public class SalesRackRenter
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public int TelephoneNumber { get; set; }


        public SalesRackRenter(string name, string email, int telephoneNumber)
        {
            this.Name = name;
            this.Email = email;
            this.TelephoneNumber = telephoneNumber;
        }
        //public static string BookAStorage(SalesRackRenter salesRackRenter, int startDate, int numberOfWeeks)
        //{
        //    foreach (SalesRack salesRack in Controller.SalesRackList)
        //    {
        //        if (salesRack.AvailabilityStatus == true)
        //        {
        //            salesRack.AvailabilityStatus = false;
        //            return $"Den ønskede tid er ledig, booking er godkendt! Du har reol {salesRack.SalesRackId}, skal møde op d. {startDate} og prisen for {numberOfWeeks} er {350 * numberOfWeeks}";
        //        }
        //    }
        //    return "Der er i øjeblikket ingen ledige reoler";
        //}
    }
}
