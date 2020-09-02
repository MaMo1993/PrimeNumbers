using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int mod = 0, numberofInts = 0, primeInt = 1, anyInt = 1;
            Console.Write("Firt 100 Prime Numbers:" + Environment.NewLine) ;
            while (numberofInts < 100)
            {
                anyInt = 1;
                mod = 0;
                while (anyInt <= primeInt)
                {
                    if (primeInt % anyInt == 0)
                        mod++;
                    anyInt++;
                }

                if (mod == 2)
                {
                    Console.Write(primeInt);
                    Console.Write(" " + Environment.NewLine);
                    numberofInts++;
                }
                primeInt++;
            }
        }
    }
}
