using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Zadanie1
{
    class Program
    {
        public int width, height;

        static int AskForInt(string message)
        {
            int result = -1;
            string input;
            do
            {
                Console.Write(message + ": ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result));
                     
            return result;
        }
        static char AskForChar(string message, char[] _ch)
        {
            char result = '!';
            do
            {
                Console.Write(message + ": ");
                result = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (!(_ch.Contains(result)));

            return result;
        }

        static void Main(string[] args)
        {
            int width, height;

            char fig;
            if (args.Any())
            {
                fig = char.Parse(args[0]);
                if (fig == 'p')
                {
                    width = int.Parse(args[1]);
                    height = int.Parse(args[2]);
                }
                if (fig == 'k')
                {
                    width = int.Parse(args[1]);
                }
                


            }
            else
            {
                fig = AskForChar("Wybierz figure [p - prostokąt; k - kwadrat]", new[] { 'k', 'p' });
            }

            
            

            Rectangle Figure;

            try
            {
                #region selector
                switch (fig)
                {
                    case 'p':
                        width = AskForInt("Podaj szerokość");
                        height = AskForInt("Podaj wysokość");
                        Figure = new Rectangle(width, height);
                        Figure.Draw();
                        break;

                    case 'k':
                        width = AskForInt("Podaj bok");
                        Figure = new Rectangle(width, width);
                        Figure.Draw();
                        break;
                };
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Prostokąt:");
                Console.WriteLine("  p [szerokość] [wysokość]");
                Console.WriteLine("Prostokąt:");
                Console.WriteLine("  k [długość boku]");
            }
           
            Console.ReadKey();
        }
    }
}
