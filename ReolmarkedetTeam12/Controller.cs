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
        //public static List<SalesRack> SalesRackList = new List<SalesRack>();
        public static List<SalesRackRenter> SalesRackRenterList = new List<SalesRackRenter>();
        public void AddToList(SalesRackRenter salesRackRenter)
        {
            SalesRackRenterList.Add(salesRackRenter);
            Debug.WriteLine(@"{0}, {1}, {2}", salesRackRenter.Name, salesRackRenter.Email, salesRackRenter.TelephoneNumber); //check if it works.
        }
        //public static void AddToList(SalesRack salesRack)
        //{
        //    SalesRackList.Add(salesRack);
        //}
    }
}
