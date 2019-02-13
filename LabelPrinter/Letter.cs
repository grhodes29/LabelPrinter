namespace LabelPrinter
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// DESCRIPTION: 
    /// COMPANY: Onshore Outsourcing https://www.onshoreoutsourcing.com/
    /// </summary>
    public class Letter
    {
        private Sender sender;
        private Recipient recip;

        public Letter(Sender sender, Recipient recip)
        {
            this.sender = sender;
            this.recip = recip;
        }


        // TODO: OLD remove this , just an example
        ///// <summary>
        ///// DESCRIPTION: this is static print example for class
        ///// </summary>
        //internal static void Printer()
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine("");
        //    Console.WriteLine("            ------------------------------------------------------------------------------------------------------------------------------------------");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |      Giancarlo and Kathy Rhodes                                                                                                        |");
        //    Console.WriteLine("            |      4749 Sweetheart Lane                                                                                                              |");
        //    Console.WriteLine("            |      Columbia, MO 65382                                                                                                                |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                            Onshore Outsourcing                                                         |");
        //    Console.WriteLine("            |                                                            902 N. Missouri Street                                                      |");
        //    Console.WriteLine("            |                                                            Macon, MO 63552                                                             |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            |                                                                                                                                        |");
        //    Console.WriteLine("            ------------------------------------------------------------------------------------------------------------------------------------------");
        //    Console.WriteLine("");
        //    Console.WriteLine("");

        //}


        /// <summary>
        /// DESCRIPTION: 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="r"></param>
        /// <param name="ceilingBuffer"></param>
        /// <param name="leftMartinBuffer"></param>
        /// <param name="lineLength"></param>
        public static void Printer(Sender s, Recipient r, int ceilingBuffer, int leftMartinBuffer, int lineLength)
        {

            // add the header space - ceilingBuffer number of  line
            for (int i = 0; i < ceilingBuffer; i++)
            {
                Console.WriteLine("");
            }

            // build the header
            string _header = "";
            for (int i = 0; i < leftMartinBuffer; i++)
            {
                _header = _header + " ";
            }
            for (int i = 0; i < lineLength; i++)
            {
                _header = _header + "-";
            }
            // print the header
            Console.WriteLine(_header);


            // space between header and sender lines
            AddNoInformatinLine(leftMartinBuffer, lineLength, 2);

            // sender name
            //_line = SenderOrRecipientLine(s, leftMartinBuffer, lineLength);
            Console.WriteLine(SenderOrRecipientLine(s.FullName, leftMartinBuffer, lineLength, true));

            // sender address           
            Console.WriteLine(SenderOrRecipientLine(s.Address, leftMartinBuffer, lineLength, true));

            // sender city, state zip
            string _cityStateZip = s.City + ", " + s.State + " " + s.Zip;
            Console.WriteLine(SenderOrRecipientLine(_cityStateZip, leftMartinBuffer, lineLength, true));


            // need five lines here
            AddNoInformatinLine(leftMartinBuffer, lineLength, 5);

            // recipient name
            Console.WriteLine(SenderOrRecipientLine(r.FullName, leftMartinBuffer, lineLength, false));

            // recipient address
            Console.WriteLine(SenderOrRecipientLine(r.Address, leftMartinBuffer, lineLength, false));

            // recipient city, state zip
            _cityStateZip = s.City + ", " + s.State + " " + s.Zip;
            Console.WriteLine(SenderOrRecipientLine(_cityStateZip, leftMartinBuffer, lineLength, false));


            // add some space before footer
            AddNoInformatinLine(leftMartinBuffer, lineLength, 10);


            // build the footer
            string _footer = "";
            for (int i = 0; i < leftMartinBuffer; i++)
            {
                _footer = _footer + " ";

            }
            for (int i = 0; i < lineLength; i++)
            {
                _footer = _footer + "-";
            }

            // print the footer
            Console.WriteLine(_footer);


            Console.WriteLine();
            Console.WriteLine();

        }


        /// <summary>
        /// DESCRIPTION: 
        /// </summary>
        /// <param name="leftMartinBuffer"></param>
        /// <param name="lineLength"></param>
        /// <param name="numOfLinesToAdd"></param>
        private static void AddNoInformatinLine(int leftMartinBuffer, int lineLength, int numOfLinesToAdd)
        {
            int counter = 0;
            string _line = "";
            while (counter < numOfLinesToAdd)
            {

                _line = "";
                for (int i = 0; i < leftMartinBuffer; i++)
                {
                    _line = _line + " ";
                }
                _line = _line + "|";
                for (int i = 2; i < lineLength; i++)
                {
                    _line = _line + " ";

                }
                _line = _line + "|";

                counter++;
                // print the line
                Console.WriteLine(_line);
            }
        }


        /// <summary>
        /// DESCRIPTION: 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="leftMartinBuffer"></param>
        /// <param name="lineLength"></param>
        /// <param name="isSender"></param>
        /// <returns></returns>
        private static string SenderOrRecipientLine(string s, int leftMartinBuffer, int lineLength, bool isSender)
        {
            string _line = "";
            for (int i = 0; i < leftMartinBuffer; i++)
            {
                _line = _line + " ";
            }

            string _someExtraSpace = "";
            if (isSender)
            {
                _someExtraSpace = "  ";
                _line = _line + "|" + _someExtraSpace + s; // two spaces and then the information
            }
            else {

                _someExtraSpace = "";
                for (int i = 0; i < lineLength / 2; i++)
                {
                    _someExtraSpace = _someExtraSpace + " ";
                }

                _line = _line + "|" + _someExtraSpace + s;

            }

            // in length line we need to account for 2 spaces and length of fullname
            for (int i = _someExtraSpace.Length; i < lineLength - 2 - s.Length; i++)
            {
                _line = _line + " ";
            }
            _line = _line + "|";
            return _line;
        }
    }
}
