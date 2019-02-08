namespace LabelPrinter
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// DESCRIPTION: Program class for console project type
    /// COMPANY: Onshore Outsourcing https://www.onshoreoutsourcing.com/
    /// </summary>
    class Program
    {

        /// <summary>
        ///  DESCRIPTION: main program entry point method -DO NOT TOUCH !!!!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // get sender information
            Dictionary<string, string> _senderDict = new Dictionary<string, string>();
            Dictionary<string, string> _recipientDict = new Dictionary<string, string>();
            string _key, _value;

            //Console.WriteLine("What is the sender's Full Name?");
            //_key = "FullName";
            //_value = Console.ReadLine();
            //_senderDict.Add(_key, _value);

            //Console.WriteLine("What is the sender's Address");
            //_key = "Address";
            //_value = Console.ReadLine();
            //_senderDict.Add(_key, _value);


            //Console.WriteLine("What is the sender's City");
            //_key = "City";
            //_value = Console.ReadLine();
            //_senderDict.Add(_key, _value);


            //Console.WriteLine("What is the sender's State");
            //_key = "State";
            //_value = Console.ReadLine();
            //_senderDict.Add(_key, _value);

            //Console.WriteLine("What is the sender's Zip");
            //_key = "Zip";
            //_value = Console.ReadLine();
            //_senderDict.Add(_key, _value);


            //Sender s = new Sender(_senderDict);
            Sender s = new Sender();

            Console.WriteLine("What is the recipient's Full Name?");
            _key = "FullName";
            _value = Console.ReadLine();
            _recipientDict.Add(_key, _value);

            Console.WriteLine("What is the recipient's Address");
            _key = "Address";
            _value = Console.ReadLine();
            _recipientDict.Add(_key, _value);


            Console.WriteLine("What is the recipient's City");
            _key = "City";
            _value = Console.ReadLine();
            _recipientDict.Add(_key, _value);


            Console.WriteLine("What is the recipient's State");
            _key = "State";
            _value = Console.ReadLine();
            _recipientDict.Add(_key, _value);

            Console.WriteLine("What is the recipient's Zip");
            _key = "Zip";
            _value = Console.ReadLine();
            _recipientDict.Add(_key, _value);


            Recipient r = new Recipient(_recipientDict);


            //Letter.Printer();

            //TODO - need to implement
            Letter.Printer(s, r, 2, 12, 160); 

            Console.ReadKey();
        }


    }
}
