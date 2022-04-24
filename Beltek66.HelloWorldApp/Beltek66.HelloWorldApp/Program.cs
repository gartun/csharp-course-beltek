using System;
using System.Linq;



namespace Beltek66.HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Switch Case Example
            //Console.WriteLine("İşlem seçiniz\n1-Havale İşlemleri\n2-Eft\n3-Şifre İşlemleri\n4-Operatör\n");
            //string decision = Console.ReadLine();

            //switch(decision)
            //{
            //    case "1":
            //        Console.WriteLine("Havale");
            //        break;
            //    case "2":
            //        Console.WriteLine("Eft");
            //        break;
            //    case "3":
            //        Console.WriteLine("Şifre işlemleri");
            //        break;
            //    default:
            //        Console.WriteLine("Operatöre bağlan");
            //        break;
            //}
            #endregion

           
            
            Console.WriteLine("asallığı sorgulanacak sayı:");
            byte num = byte.Parse(Console.ReadLine());
            //Console.WriteLine("kuvvet:");
            //byte pow = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Tek (t)/çift (ç) ?");
            //string decision = Console.ReadLine();

            //if(secNum < firstNum)
            //{
            //    byte smallNum = secNum;
            //    secNum = firstNum;
            //    firstNum = smallNum;

            //}


            byte counter = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                    break;
                }    
            }
            Console.WriteLine(counter == 0 ? $"{num} sayısı asaldır" : $"{num} sayısı asal değildir");




            //int sum = 0;

            //Console.WriteLine("\nSonuç:");

            //for (; firstNum < secNum; ++firstNum)
            //{
            //    sum += firstNum;
            //}

            //Console.WriteLine(sum);

            Console.ReadLine();
        }
        
        static string runIt()
        {
            return "hello from runIt";
        }
    }
}
