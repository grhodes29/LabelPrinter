namespace LabelPrinter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// DESCRIPTION: used in the who will receive the package or letter
    /// COMPANY: Onshore Outsourcing https://www.onshoreoutsourcing.com/
    /// </summary>
    public class Recipient
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        /// <summary>
        /// DESCRIPTION: constructor with no arguments 
        /// </summary>
        public Recipient()
        {
            CollectInfo();
        }

        public Recipient(string inFullName, string inAddress, string inCity, string inState, string inZip)
        {

            this.FullName = inFullName;
            this.Address = inAddress;
            this.State = inCity;
            this.City = inState;
            this.Zip = inZip;

        }

        public void CollectInfo()
        {
            Console.WriteLine("What is the recipient's Full Name?");
            FullName = Console.ReadLine();

            Console.WriteLine("What is the recipient's Address");
            Address = Console.ReadLine();

            Console.WriteLine("What is the recipient's City");
            City = Console.ReadLine();

            Console.WriteLine("What is the recipient's State");
            State = Console.ReadLine();

            Console.WriteLine("What is the recipient's Zip");
            Zip = Console.ReadLine();
        }


        /// <summary>
        /// DESCRIPTION: constructor that takes a dictonary and builds the oject with all it's properties filled.
        /// </summary>
        /// <param name="data"></param>
        public Recipient(Dictionary<string, string> data) {

            foreach (var item in data)
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

      

    }
}
