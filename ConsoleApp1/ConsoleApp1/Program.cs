using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Ev evim = new Ev();
            evim.alan = 120;
            evim.odasayisi = 3;
            evim.katno = 2;
            evim.semt = "beşevler";

            Ev evim2 = new Ev();
            evim2.alan = 100;
            evim2.odasayisi = 2;
            evim2.katno = 3;
            evim2.semt = "Bahçelievler";

            Ev evim3 = new Ev();
            evim3.alan = 200;
            evim3.katno = 1;
            evim3.semt = "kızılay";
            evim3.odasayisi = 5;

            Ev evim4 = new Ev { semt = "Sıhhiye", alan = 150, katno = 5,odasayisi= 4 };    
            
            Console.WriteLine(Evyazdir(evim4));


        }

        static string Evyazdir(Ev ev)
        {
            return $"oda sayısı: {ev.odasayisi}\nkat no: {ev.katno}\nalan: {ev.alan}\nsemt: {ev.semt}";
        }
    }

    class Ev
    {
        public int odasayisi;
        public int katno;
        public string semt;
        public double alan;

    }
}// fieldlar (alan) classlar içerisinde değer tutan yapılardır.
 // classlar kullanıcı tarafından tanımlanan veri tipidir. referans tipi
 //
