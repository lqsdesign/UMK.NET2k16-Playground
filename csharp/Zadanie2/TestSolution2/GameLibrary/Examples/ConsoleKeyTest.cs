using System;
using System.Collections.Generic;

namespace GameLibrary.Examples
{
    /// <summary>
    /// Example use of <see cref="ConsoleGame"/>.
    /// </summary>
    public class ConsoleKeyTest : ConsoleGame
    {
        protected override void Update(ConsoleKeyInfo keyInfo)
        {
            Console.WriteLine("Method Update(keyInfo) was called!");
            Console.WriteLine();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Escape:
                    Console.WriteLine("Esc pressed! so call Exit()");
                    Exit();
                    break;

                default:
                    /**
                     * keyInfo - obiekt typu ConsoleKeyInfo zawiera oprócz właści Key
                     * informację o tym czy razem z nim wciśnięte były "klawisze specjalne" (Ctrl, Alt, Shift)
                     * 
                     * To jest prosty przykład na użycie klasy List<>
                     * (nie wiemy ile będzie elementów)
                     */
                    List<string> keyCombo = new List<string>();

                    if (keyInfo.Modifiers > 0) //proste sprawdzenie czy dodatkowy klawisz dostał wciśnięty
                    {
                        /**
                         * własność Modifiers jest typem wyliczeniowym (w prezentacji przykład z dniami tygodnia)
                         */

                        if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Control))
                            keyCombo.Add(ConsoleModifiers.Control.ToString());

                        if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Alt))
                            keyCombo.Add(ConsoleModifiers.Alt.ToString());

                        if (keyInfo.Modifiers.HasFlag(ConsoleModifiers.Shift))
                            keyCombo.Add(ConsoleModifiers.Shift.ToString());

                        /**
                         * -- dla ciekawych --
                         * W typie wyliczeniowym ConsoleModifiers specjalnie dobrano wartości, tzn
                         * Alt = 1, Shift = 2, Control = 4   ( -- kolejne potęgi liczby 2)
                         * Metoda "HasFlag" sprawdza czy dany bit został ustawiony, zamiast niej można by napisać:
                         * if((keyInfo.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
                         */
                    }

                    keyCombo.Add(keyInfo.Key.ToString()); //dodanie faktycznego klawisza do listy

                    // Wyświetlenie kombinacji klawiszy
                    Console.WriteLine("Key {0} pressed!", string.Join(" + ", keyCombo));

                    /**
                     * Najlepiej uruchomić program i spróbować różnych kombinacji np. "Ctrl + Alt + Shift + P", "Alt + ..." i tak dalej
                     */
                    break;
            }
        }

        protected override void Initialize()
        {
            Console.WriteLine("Method Initialize() was called!");
            Console.WriteLine("Press Esc key to exit.");
            base.Initialize();
        }

        protected override void OnExiting()
        {
            Console.WriteLine("Method OnExiting() was called!");
            base.OnExiting();

            Console.WriteLine();
            Console.WriteLine("[Press enter to close]");
            Console.ReadLine();
        }

        #region Overriden only for showcase

        protected override void Update()
        {
            Console.WriteLine();
            Console.WriteLine("Method Update() was called!");
            Console.WriteLine("\t inside ConsoleGame.Update() waiting for keypress");
            base.Update();
        }

        #endregion
    }
}
