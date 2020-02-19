using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalCadet_1
{
    class Program
    {



        static void Main(string[] args)
        {
            {
               // Hello hello = new Hello();
               // hello.Show();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\tВведите фамилию             :  ");
                Console.ForegroundColor = ConsoleColor.Green;
                string Fam = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\tВведите имя                 :  ");
                Console.ForegroundColor = ConsoleColor.Green;
                string Im = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\tВведите отчество            :  ");
                Console.ForegroundColor = ConsoleColor.Green;
                string Ot = Console.ReadLine();
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

                if (Klas == 231)
                {
                    Class231 class231 = new Class231(Fam, Im, Ot, Klas);
                    class231.Begining();
                    Console.ReadKey();
                    class231.Show();
                    Print print = new Print(Fam, Im, Ot, Klas);
                    print.SaveToFiles();
                    Console.ReadKey();
                }

                if (Klas == 232)
                {
                    Class232 class232 = new Class232(Fam, Im, Ot, Klas);
                    class232.Begining();
                    Console.ReadKey();
                    class232.Show();
                    Print print = new Print(Fam, Im, Ot, Klas);
                    print.SaveToFiles();
                    Console.ReadKey();
                }

                if (Klas == 233)
                {
                    Class233 class233 = new Class233(Fam, Im, Ot, Klas);
                    class233.Begining();
                    Console.ReadKey();
                    class233.Show();
                    Print print = new Print(Fam, Im, Ot, Klas);
                    print.SaveToFiles();
                    Console.ReadKey();
                }

                if (Klas == 234)
                {
                    Class234 class234 = new Class234(Fam, Im, Ot, Klas);
                    class234.Begining();
                    Console.ReadKey();
                    class234.Show();
                    Print print = new Print(Fam, Im, Ot, Klas);
                    print.SaveToFiles();
                    Console.ReadKey();
                }

            }
            Person person = new Person();//                Class231 class231 = new Class231(Fam, Im, Ot, Klas);
            person.CreateNavalCadet();
            Console.ReadKey();
            Console.Write("  " + Fam + "  " + Im + "  " + Ot + "  " + Klas);
            Console.ReadKey();
            person.Begining();          //  Не выводятся Im,Ot,Klas  ?????????????????????
            person.Show();
            Console.WriteLine(Klas);    //  ????????????????????????????????
            Console.ReadKey();
        }
    }
}
