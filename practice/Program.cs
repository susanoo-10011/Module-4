using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string surname, string login, int loginLength, bool HasPet, double age, string[] favcolors) User;
            for (int user = 0; user < 3; user++)
            {
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.surname = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.login = Console.ReadLine();
                User.loginLength = User.login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                string res = Console.ReadLine();
                if (res == "Да")
                    User.HasPet = true;
                else
                    User.HasPet = false;

                Console.WriteLine("Введите возраст пользователя");
                User.age = Convert.ToDouble(Console.ReadLine());


                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета:");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
