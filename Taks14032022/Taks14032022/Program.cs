using System;
using System.Text;

namespace Taks14032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        L1: int number = Convert.ToInt32(Console.ReadLine());
            if (number > 3 || number < 1)
            {
                goto L1;
            }
            switch (number)
            {
                case 1:
                    #region Task2
                    /*2) int tipindən bir array olur içində müsbət və mənfi
                     * ədədlər olur elə bir method yazın ki, bu array-i parametr
                     * olaraq qəbul etsin və qəbul etdiyi array-in əvvəlcədən assign
                     * olunması məcburi olsun daha sonra içindəki
                     * mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın*/
                    Console.Write("Massivdeki elementlerin sayın daxil edin: ");
                    int number_ = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[number_];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Massivdeki {i + 1} elementi daxil edin: ");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.Clear();

                    PozitivReverse(ref arr);
                    Console.WriteLine("Massivdəki bütün ədədlər: ");
                    foreach (var item in arr)
                    {
                        Console.WriteLine(item);
                    }

                    #endregion
                    break;
                case 2:
                    Task();
                    break;
                case 3:
                    ArrayMethod();
                    break;

            }
        }
        static int[] PozitivReverse(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];
                    continue;
                }
            }

            return arr;
        }

        static void Task()
        {
            string name;
            Console.WriteLine(OutTask(out name));

        }
        static string OutTask(out string name)
        {
            name = "Farid";
            if (name == "Farid")
            {
                name = name + " Mammadov";
            }

            return name;
        }
        static void ArrayMethod()
        {
            int[] arrNumber = { 1, 2, 5, 8, -10, 7 };
            string[] arrCars = { "BMW", "Mercedes", "Geely" };

            //sort
            Console.WriteLine("-----Sort----------");
            Array.Sort(arrNumber);
            foreach (var item in arrNumber)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Reverse----------");

            //Reverse
            Array.Reverse(arrNumber);
            foreach (var item in arrNumber)
            {

                Console.WriteLine(item);
            }
            string[] arrCars2 = new string[arrCars.Length];

            //copy
            Console.WriteLine("-----Copy----------");
            Array.Copy(arrCars, 0, arrCars2, 0, arrCars2.Length);
            foreach (var item in arrCars2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----Clear----------");
            Array.Clear(arrCars, 0, arrCars.Length);
            foreach (var item in arrCars)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("-------Resize---------");

            //size to 3
            Array.Resize(ref arrNumber, 3);
            foreach (var item in arrNumber)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("-------Rank---------");

            //Rank 
            Console.WriteLine("Car array: " + arrCars2.Rank);

            Console.WriteLine("-------CopyTo---------");
            arrCars2.CopyTo(arrCars, 0);
            foreach (var item in arrCars)
            {
                Console.WriteLine(item);

            }


        }
       
       
    }
}
