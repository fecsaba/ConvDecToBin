using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvDecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot 0-225: ");
            string s = Console.ReadLine();
            Convert cv = new Convert
            {
                Dec = s
            };
            
            Console.WriteLine(cv.Dec);
            Console.ReadKey();
        }
    }
}
