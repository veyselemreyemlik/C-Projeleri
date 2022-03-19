using System;
using System.Collections.Generic;

namespace Fibonacci_PatikaProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>() { 0, 1 };
            int n = 0;
            float fiboToplam = 0;
            float fiboOrt = 0;

            try
            {
                Console.WriteLine("Lütfen Fibonacci Serisinin Derinliğini Belirtiniz :");
                n = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            while (n > fibonacci.Count)
            {
                fibonacci.Add(fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);
            }

            foreach (var i in fibonacci)
            {
                fiboToplam += i;
            }

            fiboOrt = fiboToplam / fibonacci.Count;
            Console.WriteLine("Ortalama =>" + " " + fiboToplam);

        }
    }
}
