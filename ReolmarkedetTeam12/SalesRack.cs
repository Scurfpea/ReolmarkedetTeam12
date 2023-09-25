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

        public SalesRack(int salesRackId, string type, bool availabilityStatus)
        {
            this.SalesRackId = salesRackId;
            this.Type = type;
            this.AvailabilityStatus = availabilityStatus;
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
