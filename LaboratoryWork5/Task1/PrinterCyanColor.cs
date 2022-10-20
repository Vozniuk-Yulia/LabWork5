using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class PrinterCyanColor : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
