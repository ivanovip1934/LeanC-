using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lean_using
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"c:\programs\lean_using.txt")) {
                sw.WriteLine("Как победить Капитана Великолепного");
                sw.WriteLine("Еще один гениальный секретный план");
                sw.WriteLine("от Жулика");
            }
            using (StreamReader sr = new StreamReader(@"c:\programs\lean_using.txt")) {
                string line;
                while (!sr.EndOfStream){
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
