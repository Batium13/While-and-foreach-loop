using System;

namespace While_and_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1 den başlayarak konsldan girilen sayıya kadar ortalama hesaplayıp
            //konsola yazdıran program.
            Console.Write("Hangi sayıya kadar ortalama almak istiyorsunuz?");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            // a 'dan z'ye tüm harfleri konsola yazdıran program
            char character = 'a';
            while (character<'z')
            {
                 Console.Write(character);
                 character++;
            }
                Console.WriteLine();
            //foreach  

            Console.WriteLine("***** foreach *****");

            string[] arabalar = {"bmw","ford","nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            
        }
    }
}
