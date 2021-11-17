using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Quiz
    {
        public string login { get; set; }
        public string password { get; set; }
        public int datebirthday { get; set; }

        public Quiz()
        {
            login = "unknown";
            password = "unknown";
            datebirthday = 0;
        }
        public Quiz(string login, string password, int datebirthday)
        {
            this.login = login;
            this.password = password;
            this.datebirthday = 0;
        }

        static void Main(string[] args)
        {
            Dictionary<string, string> information = new Dictionary<string, string>();
            Quiz quiz = new Quiz();
            Console.WriteLine("Введите логин : ");
            quiz.login = Console.ReadLine();
            Console.WriteLine("Введите пароль :");
            quiz.password = Console.ReadLine();
            information.Add(quiz.login, quiz.password);
        }
    }
}
