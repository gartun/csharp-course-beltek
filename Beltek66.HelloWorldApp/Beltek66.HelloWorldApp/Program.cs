using System;
using System.Linq;

//tr90 0001 2009 1940 0006 0000 71
//Yıldırım Beyazıt Üniversitesi Döner Sermaye İşletmesi
//Ticaret Uzman Yardımcısı başvurusu / Gökhan Artun / 19796785664

namespace Beltek66.HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Ahmet";
            const double PI = 3.14159;
            int sayi = 5;
            byte num = 3;

            Console.WriteLine($"PI number is taken as {PI}");
            
            string[] cities = { "Ankara", "İstanbul" };
            int[] notes = { 23, 12, 45, 78, 34 };

            for (int i = 0; i < 10; i++) 
            {
                if ( i % 2 == 0 )
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //Console.WriteLine(notes.Max());
            //Console.WriteLine(notes.Min());
            //Console.WriteLine(notes.Sum());

            Console.ReadLine();
        }
        
        static string runIt()
        {
            return "hello from runIt";
        }
    }
}
