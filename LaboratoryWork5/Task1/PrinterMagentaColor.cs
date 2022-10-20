using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class PrinterMagentaColor : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            base.Print(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
