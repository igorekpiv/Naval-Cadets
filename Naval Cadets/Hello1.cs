using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naval_Cadets
{
    class Hello1
    {
        /// <summary>
        /// Приветствие при проведении расчетов курсового проектирования.
        /// </summary>
        public void Show()
        {

            Console.Write("\n\t                         ************************************\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t******************************************************************************************\n");
            Console.Write("\t    Вас приветствует кафедра минно-торпедного и ракетного противолодочного вооружения !\n");
            Console.Write("             Данная программа помощет Вам при проведении расчетов курсового проектирования.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t******************************************************************************************\n");
            Console.Write("\t                         ************************************\n");
            Console.WriteLine();
        }
    }
}
