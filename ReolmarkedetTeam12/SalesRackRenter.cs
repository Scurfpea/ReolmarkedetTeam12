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
        public static string BookAStorage(DateTime startDate, int numberOfWeeks)
        {
            foreach (SalesRack salesRack in Controller.SalesRackList)
            {
                salesRack.AvailabilityStatus = true;
            }
            for (int i = 0; i < Controller.BookingList.Count; i++)
            {
                for (int j = 0; j < Controller.SalesRackList.Count; j++)
                {
                    if (Controller.BookingList[i].SalesRackId == Controller.SalesRackList[j].SalesRackId)
                    {
                        if (DateTime.Now < Controller.BookingList[i].EndDate)
                        {
                            Controller.SalesRackList[j].AvailabilityStatus = false;
                        }
                    }
                }
            }
            DateTime DTStartDate = startDate;
            DateTime DTEndDate = DTStartDate.AddDays(numberOfWeeks * 7);
            foreach (SalesRack salesRack in Controller.SalesRackList)
            {
                if (salesRack.AvailabilityStatus == true)
                {
                    Controller.AddToList(new Booking(salesRack.SalesRackId, DTStartDate, DTEndDate));
                    string succesReturnString = $"Den ønskede tid er ledig, booking er godkendt! Du har reol {salesRack.SalesRackId}, skal møde op d. {DTStartDate} og prisen for {numberOfWeeks} er {350 * numberOfWeeks}";
                    return succesReturnString;
                }
            }
            string failureReturnString = "Der er i øjeblikket ingen ledige reoler";
            return failureReturnString;
        }
    }
}
