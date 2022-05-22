using System;
using EmlakciLib;

namespace REAgentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev home1 = new Ev();
            home1.size = 200;
            home1.floor = 2;
            home1.numOfRooms = 3;
            home1.nei = "Keçiören";

            Ev home2 = new Ev { size = 150, floor = 2, nei = "Beşevler", numOfRooms = 4 };

            Console.WriteLine(home1.PrintInfo());

            Console.WriteLine(home2.PrintInfo());

        }
    }
}
