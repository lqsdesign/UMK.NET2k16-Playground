using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoECT.Model;
using PoECT.ViewModel;

namespace PoECT.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonViewModel testJson = new JsonViewModel();

            Console.WriteLine(testJson.StringJson);
            Console.ReadKey();
        }
    }
}
