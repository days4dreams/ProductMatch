using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class Sage1000 : SageProduct
    {
        public Sage1000(string productName, bool productIsOnline, bool productIsInternational, string productPrice) : base (productName, productIsOnline, productIsInternational, productPrice)
        {
        }

        public string sage1000Price = "£49.00 per month";
        public string sage1000Name = "Sage 1000";
        public string sage1000Feature = "Supports up to 200 users";
        // properties of the Sage1000 class

        public string productPrice
        {
            get { return this.sage1000Price; }
            set { this.sage1000Price = value; }
        }
        //we use the string productPrice globally in the Product class. Here we set it for Sage 100 as
        //equal to sage100Price

        public string productName
        {
            get { return this.sage1000Name; }
            set { this.sage1000Name = value; }
        }
        //we use the string productName globally in the Product class. Here we set it for Sage 100 as
        //equal to sage100Name

        public string productFeatures
        {
            get { return this.sage1000Feature; }
            set { this.sage1000Feature = value; }
        }
        //we use the string productFeatures globally in the Product class. Here we set it for Sage 100 as
        //equal to sage100Feature



        /*end properties*/


        public override void outputProductDetails()
        {
            string info = "Sage 1000 is designed for large businesses who trade in multiple countires!";
            string summary = "\n Product Summary\n Product Name: " + this.productName + "\n Monthly Cost: " + this.productPrice + "\n Product Features: " + this.productFeatures;
            Console.WriteLine(info + summary);
        }
        // methods of the outputProductDetails
        // using override keyword to set the outputProductDetails functions actions for Sage 1000 (which primarily
        // exists in the Sage Product class, from which this inherits).
    }
}
