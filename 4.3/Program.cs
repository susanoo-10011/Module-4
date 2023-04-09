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

            /* //4.3.14
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int[] num in array)
            {
                foreach (int item in num)
                {
                    Console.Write(item + " ");
                }
            }*/

            /* // 4.3.15
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);*/

            /* //4.3.16
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);*/

            /*//4.3.17
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for(int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                }
            }*/

            /* //4.4.2
            var (name, age) = ("Егор", 19);

            Console.WriteLine($"Мое имя: {name}");
            Console.WriteLine($"Мой возраст с цифрами: {age}");

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            Console.ReadKey();*/

            /* //4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Введите возрас питомца");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;*/

        }
    }
}
