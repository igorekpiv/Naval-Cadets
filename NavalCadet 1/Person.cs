using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalCadet_1
{
    public class Person
    {
        public static string Fam;
        public static string Im;
        public static string Ot;
        public static int Klas;
       


        public  Person(string fam1, string im1, string ot1, int klas1)
        {
            Fam = fam1;
            Im = im1;
            Ot = ot1;
            Klas = klas1;
        }

        public Person()
        {
        }

        public void CreateNavalCadet()
        {
                   Person person = new Person();

            Console.Write("\n\tВведите фамилию             :  ");
            string Fam = Console.ReadLine();
            Console.Write("\n\tВведите имя                 :  ");
            string Im = Console.ReadLine();
            Console.Write("\n\tВведите отчество            :  ");
            string Ot = Console.ReadLine();
           // int Klas;
            for (; ; )
            {
                //Console.Clear();
                try
                {
                    Console.Write("\n\tВведите номер Вашего класса :  ");
                    Klas = Int32.Parse(Console.ReadLine());
                    if ((Klas > 230) && (Klas < 235))
                    {
                       //  Console.WriteLine($"\n\tВаш ответ принят. Ваш класс : {Klas}\n"); 
                       //  Console.ReadKey();
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
        }
           
        public void Begining()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DateTime now = DateTime.Now;
            Console.Write("\n\n\n\t                         ************************************\n");
            Console.Write("\t******************************************************************************************\n");
            Console.WriteLine($"\t\t            Добрый день, " + Im + "  " + Ot + "  " + Klas +" - класс.\n\t\t\t\tНачало работы : " + now.ToString("t") + "  " + now.ToString("D"));
            Console.Write("\t******************************************************************************************\n");
            Console.Write("\t                         ************************************\n");
            Console.WriteLine("\n");
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\n\n\t                         ************************************\n");
            Console.Write("\t******************************************************************************************\n");
            Console.Write("\t    Вас приветствует кафедра минно-торпедного и ракетного противолодочного вооружения !\n");
            Console.Write("             Данная программа помощет Вам при проведении расчетов курсового проектирования.\n");
            Console.Write("\t******************************************************************************************\n");
            Console.Write("\t                         ************************************\n");
            Console.WriteLine();
        }
    }
}


