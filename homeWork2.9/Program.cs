using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2._9
{
    internal class Program
    {
        private const string Arg0 = "попыток";

        static void Main(string[] args)
        {
            string passwor = "1234";
            string userInput;
            int remainingAttempts = 3;
            for (int i = 0; i < remainingAttempts; i++)
            {
                Console.WriteLine("введите пароль");
                userInput = Console.ReadLine();
                if (userInput == passwor)
                {
                    Console.WriteLine("тайное сообщение");
                    break;
                }
            
            else
            {
                Console.WriteLine("Не верно, у вас осталось " + (remainingAttempts - (i +1)) + " попыток");
            }
        }
    }
}
}
