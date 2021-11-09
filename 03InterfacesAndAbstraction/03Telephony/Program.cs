using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine()
                .Split()
                .ToArray();
            string[] inputSites = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var number in inputNumbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        ICallable smartPhone = new Smartphone();

                        PrintCall(number, smartPhone);
                    }
                    else if (number.Length == 7)
                    {
                        ICallable stationPhone = new StationaryPhone();
                        PrintCall(number, stationPhone);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.Message);

                }
            }

            foreach (var site in inputSites)
            {
                try
                {
                    IBrowsable url = new Smartphone();
                    PrintBrowse(site, url);
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
           
        }

        private static void PrintBrowse(string currentSite, IBrowsable site)
        {
            Console.WriteLine(site.Browse(currentSite));
        }

        private static void PrintCall(string number, ICallable phone)
        {
            Console.WriteLine(phone.Call(number));
        }
    }
}
