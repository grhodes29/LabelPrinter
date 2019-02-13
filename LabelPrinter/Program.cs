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

            // Console.WriteLine("Do you want to send another letter  (yes or no)?");
            Console.WriteLine("How many letters do you want to create (1 to 100 )?");


            // collect their response here 
            string _answer = Console.ReadLine();
            // bool _boolAnswer = (_answer.ToLower().Trim() == "yes" ? true : false);
            int _numberOfLetters;

            bool _IsParsed = int.TryParse(_answer, out _numberOfLetters);

            List<Letter> ListOfLetters = new List<Letter>();

            // convert their response to boolean

            //if (_answer.ToLower().Trim() == "yes")
            //{
            //    _boolAnswer = true;
            //}
            //else
            //{
            //    _boolAnswer = false;
            //}

            int counter = 0;
            while (_IsParsed == true && counter < _numberOfLetters)
            {



                Sender sender = new Sender();
                Recipient recip = new Recipient();
                Letter _newLetter = new Letter(sender, recip);
                ListOfLetters.Add(_newLetter);

                //string _sFullName = "Jesus Christ";
                //string _sAddress = "1109 Willowcreek Lane";
                //string _sState = "MO";
                //string _sCity = "Columbia";
                //string _sZip = "65203";

                // arrange
                //Sender s = new Sender(_sFullName, _sAddress, _sState, _sCity, _sZip);
               

                //string _rFullName = "Bad Devil";
                //string _rAddress = "345 Hotplace Ave.";
                //string _rState = "NV";
                //string _rCity = "Las Vegas";
                //string _rZip = "23442";

                //Recipient r = new Recipient(_rFullName, _rAddress, _rState, _rCity, _rZip);

                Letter.Printer(sender, recip, 4, 12, 140);
                //Letter.Printer();

                // TODO: create a Printer that uses a List<>



                //Console.WriteLine("Do you want to send another letter  (yes or no)?");
                //_answer = Console.ReadLine().Trim().ToLower();
                //_boolAnswer = (_answer == "yes" ? true : false);

                counter++;
            }

            //TODO - need to implement
            //Letter.Printer(s, r, 2, 12, 160); 

            Console.ReadKey();
        }


    }
}
