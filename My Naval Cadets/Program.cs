using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Naval_Cadets
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello hello = new Hello();
            hello.Show();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\tВведите фамилию             :  ");
            Console.ForegroundColor = ConsoleColor.Green;
            string FirstName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\tВведите имя                 :  ");
            Console.ForegroundColor = ConsoleColor.Green;
            string Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\tВведите отчество            :  ");
            Console.ForegroundColor = ConsoleColor.Green;
            string SecondName = Console.ReadLine();
            int Klas;
            for (; ; )
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\tВведите номер Вашего класса :  ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Klas = Int32.Parse(Console.ReadLine());
                    if ((Klas > 230) || (Klas < 235))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\tЧисло вне допустимого диапазона значений. Повторите ввод.\n");
                        Console.ReadKey();
                    }
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("\n \tВо время выполнения программы произошла ошибка, вероятно, были введены некорректные данные!");
                    //Вывод в консоль информации о причине ошибки
                    Console.WriteLine(" \tПричина ошибки: " + ex.Message);
                    Console.ReadKey();
                    continue;
                }
            }
            User user = new User(Name, FirstName, SecondName, Klas);
            user.Begining();

        }
    }
}
