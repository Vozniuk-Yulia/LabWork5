using System;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterCyanColor printerCyan = new PrinterCyanColor();
            printerCyan.Print("Everything is good");
            PrinterMagentaColor printerMagenta = new PrinterMagentaColor();
            printerMagenta.Print("One two three");
        }
    }
}