using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class Sage1000 : SageProduct
    {
        public Sage1000(string productName, bool productIsOnline, bool productIsInternational) : base (productName, productIsOnline, productIsInternational)
        {
        }
        public string productPrice = "£49.00 per month";
        public string productName = "Sage 1000";
        public string productFeatutes = "Supports up to 200 users";
        // properties of the Sage1000 class

        public override void outputProductDetails()
        {
            string info = "Sage 1000 is designed for large businesses who trade in multiple countires!";
            Console.WriteLine(info);
        }
        // methods of the outputProductDetails
        // using override keyword to set the outputProductDetails functions actions for Sage 1000 (which primarily
        // exists in the Sage Product class, from which this inherits).
    }
}
