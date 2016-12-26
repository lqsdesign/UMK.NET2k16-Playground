using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Przypomnienie
{
    class Program
    {

        static void TestFileReadWrite()
        {
            string path = Path.GetFullPath(".");
            Console.WriteLine(path);
            const string xfile = "test.txt";



            if (File.Exists(xfile))
            {
                Console.WriteLine("Plik istnieje");
                string[] lines = File.ReadAllLines(xfile);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine("{0} - {1}", i + 1, lines[i]);
                }

                File.WriteAllLines("test1.txt", lines);
            }
            else
            {
                Console.Write("Plik nie istnieje");
            }
        }

        static void TestStrams()
        {
            string filename = "test.txt";
            string line;
            using (StreamReader reader = new StreamReader(filename)) //using niszczy obiekt po skonczeniu GC
            {


                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            //reader.Close();

            using (StreamWriter write = new StreamWriter("test2.txt"))
            {
                write.WriteLine(DateTime.Now);
                write.WriteLine();
                write.WriteLine(DateTime.Now.ToShortDateString());
                write.WriteLine();
                write.WriteLine();
                double d = 12.0;
                write.WriteLine("{0}", d);
                write.WriteLine("{0:C}", d);

                CultureInfo ci = CultureInfo.GetCultureInfo("en-US");
                write.WriteLine(string.Format(ci, "{0:C}", d));

            }
        }
        class TestForUsing:IDisposable
        {
            public TestForUsing() { Console.WriteLine("TestForUsing:Konstruktor"); }
            ~TestForUsing() { Console.WriteLine("TestForUsing:Destruktor"); } //destruktor klasy
            public void Dispose()
            {
                Console.WriteLine("TestForUsing:Dispose");
            }

            public void Test() { Console.WriteLine("TestforUsing-tekst"); }
        }
        static void TestUsing()
        {
            using (TestForUsing test = new TestForUsing())
            {
                test.Test();
            }
        }

        static void TestDestruktor()
        {
            TestForUsing test = new TestForUsing();
            test = null;
            GC.Collect();
        }

        static void Main(string[] args)
        {
            //TestStrams();
            //TestUsing();
            TestDestruktor();
            Console.ReadKey();
        }
    }
}
