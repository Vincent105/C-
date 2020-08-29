using System;
using System.Runtime.InteropServices.ComTypes;

namespace chapter03
{
    class Program
    {
        static void Main0303(string[] args)
        {
            //case 1
            (string country01, string capita01, double gdpPerCapita01) = ("Taiwan", "Taipei", 226.50);
            System.Console.WriteLine($@"The richest country is {country01},{capita01}:{gdpPerCapita01}");

            //case 2
            string country02, capita02;
            double gdpPerCapita02;

            (country02, capita02, gdpPerCapita02) = ("Taiwan", "Taipei", 226.50);
            System.Console.WriteLine($@"The richest country is {country02},{capita02}:{gdpPerCapita02}");

            //case 3
            (var country03, var capita03, var gdpPerCapita03) = ("Taiwan", "Taipei", 226.50);
            System.Console.WriteLine($@"The richest country is {country03},{capita03}:{gdpPerCapita03}");

            //case 4
            var(country04, capita04, gdpPerCapita04) = ("Taiwan", "Taipei", 226.50);
            System.Console.WriteLine($@"The richest country is {country04},{capita04}:{gdpPerCapita04}");

            //case 5
            (string country05, string capita05, double gdpPerCapita05) countryInfo1 = ("Taiwan", "Taipei", 226.50);
            System.Console.WriteLine($@"The richest country is {countryInfo1.country05},{countryInfo1.capita05}:{countryInfo1.gdpPerCapita05}");

            //case 6
            var countryInfo2 = (country06: "Taiwan", capita06: "Taipei", gdpPerCapita06: 226.50);
            System.Console.WriteLine($@"The richest country is {countryInfo2.country06},{countryInfo2.capita06}:{countryInfo2.gdpPerCapita06}");

            //case 7
            var countryInfo3 = ("Taiwan","Taipei",226.50);
            System.Console.WriteLine($@"The richest country is {countryInfo3.Item1},{countryInfo3.Item2}:{countryInfo3.Item3}");

            //case 8 
            var countryInfo4 = (country07: "Taiwan", capita07: "Taipei", gdpPerCapita07: 226.50);
            System.Console.WriteLine($@"The richest country is {countryInfo4.Item1},{countryInfo4.Item2}:{countryInfo4.Item3}");

            //case 9 
            var tuple = (1, 2, 3, 4, 5);
            (_, _, _, _, var fifth) = tuple;

            //case 10
            string country10 = "Taiwan", capita10 = "Taipei";
            double gdpPerCapita10 = 226.50;
            var countryInfo05 = (country10, capita10, gdpPerCapita10);
            System.Console.WriteLine($@"The richest country is {countryInfo05.country10},{countryInfo05.capita10}:{countryInfo05.gdpPerCapita10}");

        }
    }
}
