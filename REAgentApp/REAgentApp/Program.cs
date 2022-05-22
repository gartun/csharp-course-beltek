using System;
using EmlakciLib;
using TasitLib;

namespace REAgentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ev home1 = new Ev();
            home1.size = 200;
            home1.Floor = 2;
            home1.SetNumOfRooms(3);
            home1.Nei = "Keçiören";

            Ev home2 = new Ev { size = 250, Floor = 2, Nei = "Beşevler" };

            home2.SetNumOfRooms(4);

            Console.WriteLine(home1.PrintInfo());

            Console.WriteLine(home2.PrintInfo());

            Car car1 = new Car("red", "Peugeot 406", 2000);
            Console.WriteLine(car1.PrintInfo());

        }
    }
}
