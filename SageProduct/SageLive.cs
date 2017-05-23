using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class SageLive : SageProduct
    {
        public SageLive(string productName, bool productIsOnline, bool productIsInternational) : base(productName, productIsOnline, productIsInternational)
        {
        }
        public string productPrice = "£2.50 per month";
        public string productName = "Sage Live";
        public string productFeatutes = "Integrates with Salesforce Applications";

        // properties of the SageOne class

        public override void outputProductDetails()
        {
            string info = "Sage Live is an online solution for small to medium international businesses!";
            Console.WriteLine(info);
        }
        // methods of the outputProductDetails
        // using override keyword to set the outputProductDetails functions actions for Sage Live (which primarily
        // exists in the Sage Product class, from which this inherits).
    }
}
