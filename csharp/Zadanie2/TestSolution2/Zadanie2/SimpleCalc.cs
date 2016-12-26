using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class SimpleCalc : GameLibrary.Game
    {
        protected override void Update()
        {
            String message = Console.ReadLine();
            Console.Write("> ");
            if (message == "exit")
            {
                Exit();
            }

            string [] temp = message.Split(' ');
            if (temp.Length > 3)
            {
                switch (temp[1])
                {
                    case "+":
                        Dodawanie(temp);
                        break;
                    case "-":
                        Odejmowanie(temp);
                        break;
                    case "*":
                        Mnozenie(temp);
                        break;
                    case "/":
                        Dzielenie(temp);
                        break;
                    default:
                        Console.WriteLine("Błąd wyrażenia");
                        break;
                }
            }

        }

        static void Dodawanie(string[] _line)
        {
            try
            {
                Console.WriteLine($"Result: {int.Parse(_line[0]) + int.Parse(_line[2])}");
            }
            catch
            {
                Console.WriteLine("> Wyrażenie zawiera błąd składniowy");
            }
            
        }
        static void Odejmowanie(string[] _line)
        {
            try
            {
                Console.WriteLine($"> Result: {int.Parse(_line[0]) - int.Parse(_line[2])}");
            }
            catch
            {
                Console.WriteLine("Wyrażenie zawiera błąd składniowy");
            }

        }

        static void Mnozenie(string[] _line)
        {
            try
            {
                Console.WriteLine($"> Result: {int.Parse(_line[0]) * int.Parse(_line[2])}");
            }
            catch
            {
                Console.WriteLine("Wyrażenie zawiera błąd składniowy");
            }

        }

        static void Dzielenie(string[] _line)
        {
            try
            {
                Console.WriteLine($"> Result: {int.Parse(_line[0]) / int.Parse(_line[2])}");
            }
            catch
            {
                Console.WriteLine("Wyrażenie zawiera błąd składniowy");
            }

        }

    }
}
