using System;

namespace Karakter_Tersten_Yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metin.Length "-1" deme sebebimiz diziler
            //diziler "0". indisden başlamaktır

            Console.Write("Lütfen bir metinleri giriniz : "  );
            string metin1 = Console.ReadLine();
           
            for (int i = metin1.Length - 1; i >= 0; i--)
            {
              Console.Write(metin1[i]);
            }

        }
    }
}
