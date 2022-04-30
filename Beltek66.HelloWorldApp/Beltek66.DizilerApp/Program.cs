using System;

namespace Beltek66.DizilerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region array example - a simple example abt creating arrays and filling them
            Console.WriteLine("Kaç adet sayı girmek istiyorsunuz?");
            int totalNums = int.Parse(Console.ReadLine());

            int[] arr = new int[totalNums];

            for (int i = 0; i < totalNums; i++)
            {
                Console.WriteLine($"\n{i + 1}. sayıyı giriniz:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nGirdiğiniz sayılar:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            #endregion

            Console.WriteLine("Kaç adet öğrenci bilgisi girilecek");
            int numOfStudents = int.Parse(Console.ReadLine());

            string[,] students = new string[numOfStudents, 4];

            for (int i = 0; i < numOfStudents; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch(j)
                    {
                        case 0:
                            Console.WriteLine("Öğrenci adı:");
                            string name = Console.ReadLine();
                            students[i, j] = name;
                            break;
                        case 1:
                            Console.WriteLine("Öğrenci soyadı:");
                            string surname = Console.ReadLine();
                            students[i, j] = surname;
                            break;
                        case 2:
                            Console.WriteLine("Vize notu:");
                            string midterm = Console.ReadLine();
                            students[i, j] = midterm;
                            break;
                        case 3:
                            Console.WriteLine("Final notu:");
                            string final = Console.ReadLine();
                            students[i, j] = final;
                            break;
                        
                    }   
                    


                }
                
               
            }
        }
    }
}
