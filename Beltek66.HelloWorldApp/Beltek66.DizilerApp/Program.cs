using System;

namespace Beltek66.DizilerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array example - a simple example abt creating arrays and filling them
            //Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
            //int totalNums = int.Parse(Console.ReadLine());

            //int[] arr = new int[totalNums];

            //for (int i = 0; i < totalNums; i++)
            //{
            //    Console.WriteLine($"\n{i + 1}. sayıyı giriniz:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nGirdiğiniz sayılar:");
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region exam notes 
            //Console.WriteLine("Kaç adet öğrenci bilgisi girilecek");
            //int numOfStudents = int.Parse(Console.ReadLine());

            //string[,] students = new string[numOfStudents + 1, 5];
            //students[0, 0] = "Adı";
            //students[0, 1] = "Soyadı";
            //students[0, 2] = "Vize";
            //students[0, 3] = "Final";
            //students[0, 4] = "Ortalama";

            //for (int i = 1; i < students.GetLength(0); i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        switch (j)
            //        {
            //            case 0:
            //                Console.WriteLine($"{i}. Öğrenci adı:");
            //                students[i, j] = Console.ReadLine();
            //                break;
            //            case 1:
            //                Console.WriteLine($"{i}. Öğrenci soyadı:");
            //                students[i, j] = Console.ReadLine();
            //                break;
            //            case 2:
            //                Console.WriteLine($"{i}. Vize notu:");
            //                students[i, j] = Console.ReadLine();
            //                break;
            //            case 3:
            //                Console.WriteLine($"{i}. Final notu:");
            //                students[i, j] = Console.ReadLine();
            //                break;
            //            case 4:
            //                students[i, j] = Convert.ToString( (Convert.ToDouble(students[i, 2]) * 40 / 100) + (Convert.ToDouble(students[i, 3]) * 60 / 100) );
            //                break;
            //            default:    break;
            //        }

                    

            //    }


            //}

            //for(int i = 0; i < students.GetLength(0); i++)
            //{
            //    for(int j = 0; j < 5; j++)
            //    {
            //        Console.Write(students[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

        }
    }
}
