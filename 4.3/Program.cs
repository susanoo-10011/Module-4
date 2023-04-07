using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Введите свое имя");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам:");

            foreach (var i in name) 
            {
                Console.Write(i + " ");
            }
            Console.WriteLine($"  Последняя буква вашего имени: {name[name.Length - 1]}");*/

            /*Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();

            for(int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine(); */

            /*int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int k = 0; k < array.GetLength(0); k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();*/

            /*var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            int sum;
                sum = arr[0];

            for (int i = 1;i < arr.Length; i++)
            {
                sum += + arr[i];
            }
            Console.WriteLine(sum);*/

            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
