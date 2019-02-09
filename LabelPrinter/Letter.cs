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
    internal class Letter
    {

        

        /// <summary>
        /// DESCRIPTION: this is static print example for class
        /// </summary>
        internal static void Printer()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("            ------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |      Giancarlo and Kathy Rhodes                                                                                                        |");
            Console.WriteLine("            |      4749 Sweetheart Lane                                                                                                              |");
            Console.WriteLine("            |      Columbia, MO 65382                                                                                                                |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                            Onshore Outsourcing                                                         |");
            Console.WriteLine("            |                                                            902 N. Missouri Street                                                      |");
            Console.WriteLine("            |                                                            Macon, MO 63552                                                             |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            |                                                                                                                                        |");
            Console.WriteLine("            ------------------------------------------------------------------------------------------------------------------------------------------");
          
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="r"></param>
        /// <param name="ceilingBuffer"></param>
        /// <param name="leftMartinBuffer"></param>
        /// <param name="lineLength"></param>
        internal static void Printer(Sender s, Recipient r, int ceilingBuffer, int leftMartinBuffer, int lineLength)
        {

            // add the header space
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
                _header =_header + "-";
            }
            // print the header
            Console.WriteLine(_header);



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

        }
    }
}
