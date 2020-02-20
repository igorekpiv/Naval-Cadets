using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Naval_Cadets
{
    class User
    {
        #region
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Фамилия.
        /// </summary>
        public string FirstName { get; }
        /// <summary>
        /// Отчество.
        /// </summary>
        public string SecondName { get; }
        /// <summary>
        /// Класс.
        /// </summary>
        public int Klas { get; }

        #endregion
        public User(string name,
                    string firstname,
                    string secondname,
                    int klas)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentNullException("Фамилия пользователя не может быть пустым или null.", nameof(firstname));
            }
            if (string.IsNullOrWhiteSpace(secondname))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(secondname));
            }
            if ((klas < 230) && (klas > 235))
            {
            throw new ArgumentNullException("Класс не может быть меньше 231 или больше 234.", nameof(klas));
            }
            #endregion
            Name = name;
            FirstName = firstname;
            SecondName = secondname;
            Klas = klas;
        }
        public override string ToString()
        {
            return Name;
        }
      //  public string ShotName 
      //  {
      //      get
      //      {
      //          return $"{FirstName}{Name.Substring(0, 1)}.{SecondName.Substring(0, 1)}.";
      //      }
      //  }
        /// <summary>
        /// Приветствие.
        /// </summary>
        public void Begining()
        {
            DateTime now = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n\n\t  Добрый день,  {Name}  {SecondName}, {Klas} - класс.\tНачало работы : " + now.ToString("t") + "  " + now.ToString("D"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }
    }
}
