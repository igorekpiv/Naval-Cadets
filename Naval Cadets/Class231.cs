using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naval_Cadets
{
    class Class231
    {
        public string Fam { get; }                                    
        public string Im { get; }
        public string Ot { get; }
        public int Klas { get; }

        public Class231(string fam1, string im1, string ot1, int klas1)
        {
            Fam = fam1;
            Im = im1;
            Ot = ot1;
            Klas = klas1;
        }
        /// <summary>
        /// Приветствие.
        /// </summary>
        public void Begining()
        {        
              DateTime now = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n\t  Добрый день,  {Im}  {Ot}, {Klas} - класс.\tНачало работы : " + now.ToString("t") + "  " + now.ToString("D"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }
        /// <summary>
        /// Приступим к лабораторной работе.
        /// </summary>
        public void Show()
        {
            Console.Write("\t  И так, Вы, готовы ?  Тогда, давайте приступим к лабораторной работе.\n");
            Console.ReadKey();
        }
    }
} 

