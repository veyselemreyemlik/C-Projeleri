using System;

namespace Ucgen_Cizim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************Düz Üçgen****************");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}
