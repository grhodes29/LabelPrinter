namespace LabelPrinter
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// DESCRIPTION: add description
    /// COMPANY: Onshore Outsourcing https://www.onshoreoutsourcing.com/
    /// </summary>
    public class Sender
    {
        

        public string FullName {get; set;}
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

       

        /// <summary>
        /// DESCRIPTIOIN: constructor that get gets the basic information
        /// </summary>
        public Sender() {

            CollectInfo();
        }


        /// <summary>
        /// DESCRIPTION: constructor that takes a dictonary and builds the oject with all it's properties filled.
        /// </summary>
        /// <param name="inData"></param>
        public Sender(Dictionary<string, string> inData)
        {

            foreach (var item in inData)
            {
                if (item.Key == "FirstName")
                {
                    this.FullName = item.Value;
                }
                else if (item.Key == "Address")
                {
                    this.Address = item.Value;
                }
                else if (item.Key == "City")
                {

                    this.City = item.Value;
                }
                else if (item.Key == "State")
                {

                    this.State = item.Value;
                }
                else if (item.Key == "Zip")
                {
                    this.Zip = item.Value;
                }
            }

        }



        public Sender(string sFullName, string sAddress, string sState, string sCity, string sZip)
        {
            this.FullName = sFullName;
            this.Address = sAddress;
            this.State = sState;
            this.City = sCity;
            this.Zip = sZip;
        }



        /// <summary>
        /// DESCRIPTION: get the information using this method
        /// </summary>
        private void CollectInfo()
        {

            Console.WriteLine("What is the sender's Full Name?");
            this.FullName = Console.ReadLine();

            Console.WriteLine("What is the sender's Address");
            this.Address = Console.ReadLine();

            Console.WriteLine("What is the sender's City");
            this.City = Console.ReadLine();

            Console.WriteLine("What is the sender's State");
            this.State = Console.ReadLine();

            Console.WriteLine("What is the sender's Zip");
            this.Zip = Console.ReadLine();


        }


    }
}
