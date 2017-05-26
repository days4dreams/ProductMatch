using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class SageProduct
    {
        public string productName = "Sage Product";
        public double productSize = 0;
        public string productPrice = "";
        public string productFeatures = string.Empty;
        public string productSum = string.Empty;
        //public string[] productOption = { "Sage One", "Sage Live", "Sage 1000" };
        public bool productIsOnline = true;
        public bool productIsInternational = true;
        //here we declare variables that are shared by the constructors, properties, and child classes


        /* start properties */
        public string ProductTitle
        {
            get { return this.productName; }
        }
        //this the declaration of a property, ProductTitle. It has no set function; all titles are final.

        public string ProductFeature
        {
            get { return this.productFeatures; }
            set { this.productFeatures = value; }
        }
        //this the declaration of a property, ProductFeature. It is set in each product class


        public double ProductEmployee
        {
            get { return this.productSize; }
        }
        //this the declaration of a property, ProductEmployee. It has no set function; all sizes are final.

        public string ProductPrice
        {
            get { return this.productPrice; }
        }
        //this the declaration of a property, ProductPrice. It has no set function; all sizes are final.

        public bool ProductOnline
        {
            get { return this.productIsOnline; }
        }
        //this is a another property, ProductOnline.

        public bool ProductInternational
        {
            get { return this.productIsInternational; }
        }
        //this is a another property, ProductInternational.
        
        /* end properties */

        /* start constructors */
        public SageProduct(string productName, bool productIsOnline, bool productIsInternational, string productPrice)
        {
            this.productName = productName;
            this.productIsOnline = productIsOnline;
            this.productIsInternational = productIsInternational;
            this.productPrice = productPrice;
        }
        //this is a constructor, for the Product object. It requires a Name, Size and statuses to be input.
        /* end constructors */

        public string ProductSummary(string productName, string productPrice, string productFeatures)
        {
            return "\n Product Summary\n Product Name: " + this.productName + "\n Monthly Cost: " + this.productPrice + "\n Product Features: " + this.productFeatures;
            //Console.WriteLine("\n Monthly Cost: ");
            //Console.WriteLine(this.productPrice);
            //Console.WriteLine("\n Product Features: " + this.productFeatures);

           // return productSum;

        }
        //this function produces a summary of the the product
        /* end functions */

        public virtual void outputProductDetails()
        {
            Console.WriteLine("Hello, World");
        }
        // using keyword virtual to allow the override of a the function in sub-classes, EG Sage One
    }
}
