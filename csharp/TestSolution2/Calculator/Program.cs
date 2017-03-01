using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Prosty kalkulator konsolowy]");
            SimpleCalc.Run(new SimpleCalc());

        }
    }
}
