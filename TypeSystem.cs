using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int getal = 1234;//32 bit
            // getal = getal + 1;
            // long grootGetal=123456;//64 bit
            // grootGetal = getal;

            // getal = grootGetal;//potentieel een probleem
            // getal = (int)grootGetal;//casten,  weet wat je doet

            //// int a = 4294967296;
            // int a = 2147483148;

            // uint aa= 4294967295;//unsigned integer, dus een int zonder tekenbit

            // // Int32 is ExecutionEngineException Common Type system type
            // //int is een alias voor Int32
            // // long is een alias voor Int64
            // //short is een alias voor int 16

            // double d = 123.45;
            //float whatever = 123.45F;//kleiner dan double
            // decimal financialValue = 12345.67M;//M verwijst naar decimal
            byte b = 255;//8 bits unsigned
            sbyte sb = 127;//signed byte

            long groteWaarde = 1_234_567_891_234;//leesbaarheid

            double d = 0.0;
            decimal dec = 0.0M;
            for(var i=0;i<100000;i=i+1)
            {
                dec = dec + 0.00001M;
            }
            Console.WriteLine(dec);

            bool reply = true;//of false

            var ziemaar = "abcd";//compiler zoek zelf uit wat het type moet zijn.
            var x = 1234.56F;

            string age = "23";
            //int leeftijd = (int)age;//Je kunt niet casten van string naar int, long, double enz

            int leeftijd = int.Parse(age);

        }
    }
}
