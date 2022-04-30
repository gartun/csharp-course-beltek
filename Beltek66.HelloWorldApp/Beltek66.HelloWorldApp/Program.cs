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

            #region check whether each number in an interval is prime
            //Console.WriteLine("Başlangıç sayısı:");
            //byte firstNum = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Sayısı:");
            //byte lastNum = byte.Parse(Console.ReadLine());
            ////Console.WriteLine("Tek (t)/çift (ç) ?");
            ////string decision = Console.ReadLine();

            //if (lastNum < firstNum)
            //{
            //    byte smallNum = lastNum;
            //    lastNum = firstNum;
            //    firstNum = smallNum;
            //}

            //for(int i = firstNum; i < lastNum; i++)
            //{
            //    int primeCheckResult = isPrime(i);
            //    string resultSentence = primeCheckResult == 1 ? "asal değildir" : "asaldır";

            //    Console.WriteLine($"{i} sayısı {resultSentence}");
            //    Console.WriteLine(new String('-', 25));
            //}
            #endregion

            #region while example - sum the numbers that users input until they type "t"
            //int sum = 0;

            //string decision = "";
            //while(decision.ToLower() != "t")
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;

            //    Console.WriteLine("Tamam mı / Devam mı?");
            //    decision = Console.ReadLine();
            //}

            //Console.WriteLine("Sonuç: " + sum);

            #endregion 

            #region while example - guess the number
            //Random rnd = new Random();
            //int num = rnd.Next(10);
            //int lives = 3;
            //Console.WriteLine(num);
            //int guess;

            //do
            //{
            //    Console.WriteLine("Tahmin: ");
            //    --lives;
            //    guess = int.Parse(Console.ReadLine());
            //} while(guess != num && lives != 0);

            
            //Console
            //    .WriteLine(guess != num ? "Hakkınız Bitti..." : "Tebrikler...");
            #endregion

        }

        static int isPrime(int num)
        {
            // Prime numbers start from 2
            if(num < 2)
            {
                return 1;
            }

            
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    
                    return 1;
                }
            }
            return 0;
        }

       
    }
}
