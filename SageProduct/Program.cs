using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            // From Dave
            // List<SageProduct> products = new List<SageProduct>();
            //products.Add(new SageOne());
            //add sage1000
            //add sage live

            Console.WriteLine("Welcome to Sage Solution Finder");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("I will help you to find the best Sage solution for your business.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n To start, I will ask you a series of questions... \n 1. Please tell me the name of your company.");
            string coName = Console.ReadLine();

            Console.WriteLine("\n 2. How many employees work at " + coName + "?");
            string noOfEmployees = Console.ReadLine();
            double coEmployees = Convert.ToDouble(noOfEmployees);

            Console.WriteLine("\n 3. Are you looking for an online solution? \n Answer (Y) or (N)");
            string answerOnline = Console.ReadLine();
            System.Collections.Generic.List<string> yesAnswers = new System.Collections.Generic.List<string>() { "y", "yes", "(y)"};
            bool coOnline;
            coOnline = yesAnswers.Contains(answerOnline.ToLower());

            Console.WriteLine("\n 4. Finally, does " + coName + " trade internationally? \n Answer (Y) or (N)");
            string answerInt = Console.ReadLine();
            bool coInternational;
            coInternational = yesAnswers.Contains(answerInt.ToLower());


            Company userCompany = new Company(coEmployees, coName, coOnline, coInternational);
            //create a new company -should be from user input

            Console.WriteLine("\n Thank you for the details about " + userCompany.companyName + ", I reccomend:");
            //print company name to screen - should be function within company to produce summary

            string coOutput = userCompany.CalculateProduct(coEmployees, coInternational);
            //call function to calcultae suitable product - should push through inputs

            SageOne sageOne = new SageOne("Sage One", true, false, "£9.99 per month");
            SageLive sageLive = new SageLive("Sage Live", true, true, "£65 per month");
            Sage1000 sage1000 = new Sage1000("Sage 1000", false, true, "£400 per month");

            //From Dave
            //SageProduct chosenProduct = products.Where(p => p.productName == userCompany.productOutput).First();
            //chosenProduct.outputProductDetails();

            if (userCompany.productOutput == "Sage One")
            {
                sageOne.outputProductDetails();
                string outsaid = sageOne.ProductSummary(sageOne.productName, sageOne.productPrice, sageOne.productFeatures);
                Console.WriteLine(outsaid);
                //call the output method from Sage One class
                //call the summary method from Product class
            }
            else if (userCompany.productOutput == "Sage Live")
            {
                sageLive.outputProductDetails();
                string outsaid = sageLive.ProductSummary(sageLive.productName, sageLive.productPrice, sageLive.productFeatures);
                Console.WriteLine(outsaid);
                //call the output method from Sage Live class
                //call the summary method from Product class
            }
            else if (userCompany.productOutput == "Sage 1000")
            {
                sage1000.outputProductDetails();
                string outsaid = sage1000.ProductSummary(sage1000.productName, sage1000.productPrice, sage1000.productFeatures);
                Console.WriteLine(outsaid);
                //call the output method from Sage 1000 class
                //call the summary method from Product class
            }

            /*
            if (coOutput.GetType() == typeof(SageOne)) { 
            sageOne.outputProductDetails();
               }
            else if (coOutput.GetType() == typeof(SageLive)) { 
            sageLive.outputProductDetails();
            }
            else if (coOutput.GetType() == typeof(Sage1000))
            {
                sage1000.outputProductDetails();
            }
             //pass the type of product I have been assigned to the function outputProductDetails
             //use typeof keyword and GetType object method to determine if/else ruling
             //using the override method to superseed the Objects standard method
             */

            Console.ReadKey();
        }
    }
}