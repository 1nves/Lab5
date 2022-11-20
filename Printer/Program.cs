using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
           ColorPrinter printer = new ColorPrinter();
           printer.Print("Some text");
        }
    }
}
