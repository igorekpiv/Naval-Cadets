using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Naval_Cadets
{
    /// <summary>
    /// Создаем класс 231.
    /// </summary>
    class Print : Class231
    {
        public new string Fam;
        public new string Im;
        public new string Ot;
        public new int Klas;
        public Print (string fam1, string im1, string ot1, int klas1) : base(fam1, im1, ot1, klas1)
        {
            Fam = fam1;
            Im = im1;
            Ot = ot1;
            Klas = klas1;
        }
        /// <summary>
        /// Запись в файл "j:\1\ЛР1-" + month + "-" + Klas + "#.txt"
        /// </summary>
        public void SaveToFiles()
        {
            int A0 = 5;
            DateTime now = DateTime.Now;
            string month = now.ToString("MM");
            string filePath = @"j:\1\ЛР1-" + month + "-" + Klas + "#.txt";
            FileStream fileStream = null;
            // проверяем существует ли файл файл 
            if (!File.Exists(filePath))
            // создаем файл 
                fileStream = File.Create(filePath); 
            else
            // открываем файл и в конец будут добавлены данные
                fileStream = File.Open(filePath, FileMode.Append);  
            // получаем поток 
            StreamWriter output = new StreamWriter(fileStream);
            // записываем текст в поток  
            output.WriteLine("   {0:d}\t{1,-15}\t{2,-15}\t{3,-15}\t{4,-40}", now.ToString("dd.MM.yyyy"), Fam, Im, Ot, Klas + " - класс    Начало работы : " + now.ToString("t") + "   Оценка за ЛР1 : " + A0);
            // закрываем поток 
            output.Close();
         
            string inFile = @"j:\1\ЛР1-" + month + "-" + Klas + "#.txt";
            string outFile = @"j:\1\ЛР1-" + month + "-" + Klas + "##.txt";
            var contents = File.ReadAllLines(inFile);
            Array.Sort(contents);
            File.WriteAllLines(outFile, contents);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\t  Результаты лабораторной работы записаны в файл.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }
    }
}
