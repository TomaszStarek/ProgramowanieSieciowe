

using System;
using System.Diagnostics.CodeAnalysis;


namespace hello
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj liczbe");
            string liczba = Console.ReadLine();

            int x = 8;
            int a = 0;
            int m = 0;
            int b = 0;


            foreach (int var in liczba)
            {
                for (int i = 0; i < 8; i++)
                {
                    x = (var >> i) & 1;
                    a = a ^ x;
                }
                
            }

            
           
            Console.WriteLine("suma: ");
            Console.WriteLine(a);

            //Console.ReadLine();
            
            Console.WriteLine("Press any key to exit.");
            
            
        }
    }
}