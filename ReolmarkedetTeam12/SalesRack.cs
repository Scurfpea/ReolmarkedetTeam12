using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolmarkedetTeam12
{
    public class SalesRack
    {
        public int SalesRackId { get; set; }
        public string Type { get; set; }
        public bool AvailabilityStatus { get; set; }
        //public string? CurrentRenter { get; set; }

        public SalesRack()
        {
            SalesRackId = Controller.SalesRackList.Count + 1;
            Type = "Standard";
            AvailabilityStatus = true;

        }
        public static string SalesRackToAvailable(SalesRack salesRack)
        {
            if (salesRack.AvailabilityStatus == false)
            {
                salesRack.AvailabilityStatus = true;
                //GodsalesRack.CurrentRenter = "";
                return $"{salesRack} status er nu sat som ledig";
            }
            return $"{salesRack} status var ledig, ingen ændring foretaget";
        }
    }
}
