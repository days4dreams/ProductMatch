using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class SageLive : SageProduct
    {
        public SageLive(string productName, bool productIsOnline, bool productIsInternational, string productPrice) : base(productName, productIsOnline, productIsInternational, productPrice)
        {
        }
        public string sageLivePrice = "£2.50 per month";
        public string sageLiveName = "Sage Live";
        public string sageLiveFeature = "Integrates with Salesforce Applications";


        public string productPrice
        {
            get { return this.sageLivePrice; }
            set { this.sageLivePrice = value; }
        }
        //we use the string productPrice globally in the Product class. Here we set it for Sage Live as
        //equal to sageLivePrice

        public string productName
        {
            get { return this.sageLiveName; }
            set { this.sageLiveName = value; }
        }
        //we use the string productName globally in the Product class. Here we set it for Sage Live as
        //equal to sageLiveName

        public string productFeatures
        {
            get { return this.sageLiveFeature; }
            set { this.sageLiveFeature = value; }
        }
        //we use the string productFeatures globally in the Product class. Here we set it for Sage Live as
        //equal to sageLiveFeature

        // properties of the SageLive class

        public override void outputProductDetails()
        {
            string info = "Sage Live is an online solution for small to medium international businesses!";
            string summary = "\n Product Summary\n Product Name: " + this.productName + "\n Monthly Cost: " + this.productPrice + "\n Product Features: " + this.productFeatures;
            Console.WriteLine(info + summary);
        }
        // methods of the outputProductDetails
        // using override keyword to set the outputProductDetails functions actions for Sage Live (which primarily
        // exists in the Sage Product class, from which this inherits).
    }
}
