using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabelPrinter;

namespace UnitTestLablePrinter
{
    [TestClass]
    public class UnitTestLetter
    {
        [TestMethod]
        public void Avanced_Printer()
        {
            // arrange
            Sender s = new Sender();
            s.FullName = "Jesus Christ";
            s.Address = "1109 Willowcreek Lane";
            s.State = "MO";
            s.City = "Columbia";
            s.Zip = "65203";



            Recipient r = new Recipient();
            r.FullName = "Bad Devil";
            r.Address = "345 Hotplace Ave.";
            r.State = "NV";
            r.City = "Las Vegas";
            r.Zip = "23442";

            // act
            Letter.Printer(s, r, 5, 12, 140);

            // assert



        }
    }
}
