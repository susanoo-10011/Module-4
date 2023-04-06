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

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
