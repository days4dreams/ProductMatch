using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class SageOne : SageProduct
    {
        public SageOne(string productName, bool productIsOnline, bool productIsInternational) : base(productName, productIsOnline, productIsInternational)
        {
        }

        public string productPrice = "£19.00 per month";
        public string productName = "Sage One";
        public string productFeatutes = "Available in the cloud";

        //public string productFeatures { get; set; }
        // properties of the SageOne class


        public override void outputProductDetails()
        {
            string info = "Sage One, is the ideal solution for small businesses and sole traders!";
            Console.WriteLine(info);
        }
        // methods of the outputProductDetails
        // using override keyword to set the outputProductDetails functions actions for Sage One (which primarily
        // exists in the Sage Product class, from which this inherits).
    }
}
