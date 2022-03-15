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

            #region Task2
            /*2) int tipindən bir array olur içində müsbət və mənfi
             * ədədlər olur elə bir method yazın ki, bu array-i parametr
             * olaraq qəbul etsin və qəbul etdiyi array-in əvvəlcədən assign
             * olunması məcburi olsun daha sonra içindəki
             * mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın*/
            Console.Write("Massivdeki elementlerin sayın daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[number];
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
    }
}
