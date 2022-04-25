using System;




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

            #region Factorial example
            //byte[] numArray = { 0, 1, 2, 3, 4, 5 };
            //foreach (var item in numArray)
            //{
            //    Console.WriteLine($"{item} sayısının faktöriyeli: {fact(item)}");
            //}
            //static int fact( int num )
            //{
            //    if (num < 2) return 1;
            //    return num * fact(num - 1);
            //}
            #endregion

            Console.WriteLine("Başlangıç sayısı:");
            byte firstNum = byte.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısı:");
            byte lastNum = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Tek (t)/çift (ç) ?");
            //string decision = Console.ReadLine();

            if (lastNum < firstNum)
            {
                byte smallNum = lastNum;
                lastNum = firstNum;
                firstNum = smallNum;
            }

            for(int i = firstNum; i < lastNum; i++)
            {
                int primeCheckResult = isPrime(i);
                string resultSentence = primeCheckResult == 1 ? "asal değildir" : "asaldır";

                Console.WriteLine($"{i} sayısı {resultSentence}");
                Console.WriteLine(new String('-', 25));
            }
        }

        static int isPrime(int num)
        {
            // Prime numbers start from 2
            if(num < 2)
            {
                return 1;
            }

            byte counter = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    counter++;
                    return 1;
                }
            }
            return 0;
        }

       
    }
}
