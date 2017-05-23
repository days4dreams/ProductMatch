using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class Company
    {
        public string companyName = string.Empty;
        public double companySize = 0;
        public bool companyIsOnline = true;
        public bool companyIsInternational = true;
        public string productOutput = string.Empty;
        public string companyNotice = string.Empty;

        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        //this is another property, CompanyName. It will be set by input

        public double CompanySize
        {
            get { return this.companySize; }
            set { this.companySize = value; }
        }
        //this is a another property, CompanySize. It will be set by input

        public bool CompanyOnline
        {
            get { return this.companyIsOnline; }
            set { this.companyIsOnline = value; }
        }
        //this is a another property, CompanyOnline.

        public bool CompanyInternational
        {
            get { return this.companyIsInternational; }
            set { this.companyIsInternational = value; }
        }
        //this is a another property, CompanyInternational
        /* end properties */

        /* start constructors */
        public Company(double companySize, string companyName, bool companyIsOnline, bool companyIsInternational)
        {
            this.companyName = companyName;
            this.companySize = companySize;
            this.companyIsOnline = companyIsOnline;
            this.companyIsInternational = companyIsInternational;
        }
        //this is a constructor, for the Company object. It requires a Name, Size and statuses to be input.
        /* end constructors */

        /* start functions */
        public string CalculateProduct(double companySize, bool companyIsInternational)
        {
            if (companySize >= 21)
            {
                productOutput = "Sage 1000";
                Console.WriteLine(productOutput);
                return productOutput;
            }
            else if (companySize == 0)
            {
                productOutput = "Sage One";
                Console.WriteLine(productOutput);
                return productOutput;
            }

            else if (companySize <= 20 && companyIsInternational == true)
            {
                productOutput = "Sage Live";
                Console.WriteLine(productOutput);
                return productOutput;
            }

            else if (companySize <= 20 && companyIsInternational == false)
            {
                productOutput = "Sage One";
                Console.WriteLine(productOutput);
                return productOutput;
            }
            else
            {
                productOutput = "Sage Live";
                Console.WriteLine(productOutput);
                return productOutput;
            }

            //this is a function. when we call it in the program, it takes the companySize and International Status and calculates the most suitable product 
            //See use of void for the distinction of a function

        }
    }
}
