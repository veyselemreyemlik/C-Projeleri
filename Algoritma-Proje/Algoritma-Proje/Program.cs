using System;

namespace Algoritma_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input : Selam,4
            // Output : Sela
            // Girilen sayi değerinden itibaren diğer indeksler Remove metodu ile silinir.

            Console.Write("Bir Kelime Giriniz :");
            string yazi  = Console.ReadLine();

            Console.Write("Bir Sayı Giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            
            string sonYazi = yazi + "," +sayi.ToString();
            Console.WriteLine("Yazı + Sayı : "+ " " +sonYazi);

            yazi = yazi.Remove(sayi);
            Console.WriteLine(yazi);

        }
    }
}
