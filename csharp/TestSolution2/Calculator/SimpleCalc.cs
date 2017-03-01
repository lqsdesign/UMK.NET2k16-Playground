using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalc : GameLibrary.Game
    {
       private string Text { get; set; }
       private int Mode { get; set; }
       private string TrimText { get; set; }
       private char Symbol { get; set; }
       private string[] SplitText { get; set; }

        protected override void Update()
        {
            Text = readConsole();
            Mode = textVeryfi(Text);
            Actions(Mode);

        }

        private string readConsole()
        {
            string _readConsole = "";
            Console.Write("> ");
            _readConsole = Console.ReadLine().ToString();

            return _readConsole;
        }

        private int textVeryfi(string _text)
        {
            // 0 = wyjście z programu
            // 1 = policz wynik
            // 2 = error
            TrimText = _text.Trim(' ');
            string[] obliczenia;
            Symbol = 'x';

            if (TrimText == "exit") return 0;

            if (TrimText.Contains('+')) Symbol = '+';
            if (TrimText.Contains('-')) Symbol = '-';
            if (TrimText.Contains('*')) Symbol = '*';
            if (TrimText.Contains('/')) Symbol = '/';

            if (Symbol != 'x')
            {
                obliczenia = checkAndSplitText(TrimText, Symbol);

                if (checkIsLiczba(obliczenia))
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("> Error");
                    return 2;
                }
            }

            return 2;
        }

        private string[] checkAndSplitText(string _text, char _symbol)
        {
            if (_text.Contains(_symbol))
            {
                string[] result = _text.Split(_symbol);
                SplitText = result;
                return result;
            }

            return null;
        }

        private bool checkIsLiczba(string[] _text)
        {
            bool warunek = true;
            double n;
            foreach (string s in _text)
            {
                if (!double.TryParse(s, out n)) warunek = false;
                
            }

            return warunek;
        }

        private void Actions(int _a)
        {
            switch (_a)
            {
                case 0:
                    Exit();
                    break;
                case 2:
                    break;
                case 1:
                    {
                        if (SplitText.Count() > 2)
                        {
                            Console.WriteLine("> Error");
                            break;
                        }

                        double liczba1 = double.Parse(SplitText[0]);
                        double liczba2 = double.Parse(SplitText[1]);

                        if (Symbol == '+')
                        {
                            Console.WriteLine("> Wynik: " + (liczba1 + liczba2));
                            break;
                        }
                        if (Symbol == '-')
                        {
                            Console.WriteLine("> Wynik: " + (liczba1 - liczba2));
                            break;
                        }
                        if (Symbol == '*')
                        {
                            Console.WriteLine("> Wynik: " + string.Format("{0:0.00}", (liczba1 * liczba2)));
                            break;
                        }
                        if (Symbol == '/' && liczba2 != 0)
                        {
                            Console.WriteLine("> Wynik: " + string.Format("{0:0.00}", (liczba1 / liczba2)));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("> Error");
                            break;
                        }

                    }
            }
        }
    }
}
