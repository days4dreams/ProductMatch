using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class SageOne : SageProduct
    {
        public SageOne(string productName, bool productIsOnline, bool productIsInternational, string productPrice) : base(productName, productIsOnline, productIsInternational, productPrice)
        {
        }

        public string sageOnePrice = "£19.00 per month";
        public string sageOneName = "Sage One";
        public string sageOneFeature = "Available in the cloud";


        public string productPrice
        {
            get { return this.sageOnePrice; }
            set { this.sageOnePrice = value; }
        }
        //we use the string productPrice globally in the Product class. Here we set it for Sage One as
        //equal to sageOnePrice

        public string productName
        {
            get { return this.sageOneName; }
            set { this.sageOneName = value; }
        }
        //we use the string productName globally in the Product class. Here we set it for Sage One as
        //equal to sageOneName

        public string productFeatures
        {
            get { return this.sageOneFeature; }
            set { this.sageOneFeature = value; }
        }
        //we use the string productFeatures globally in the Product class. Here we set it for Sage One as
        //equal to sageOneFeature
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
