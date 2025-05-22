using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            WorkingWithArray laboratorna10 = new WorkingWithArray();
            laboratorna10.printIntMatrix();
            laboratorna10.summRowsWhereIsNegativeElement();
            laboratorna10.searchSaddlePoint();
            //Console.ReadKey();

        }
    }
}
