using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class ColorPrinter : Printer
    {
        Random random = new Random();
        public override void Print(string value)
        {
            Console.ForegroundColor = (ConsoleColor)random.Next(0,20);
            Console.BackgroundColor = (ConsoleColor)random.Next(0, 20);
            base.Print(value);
            base.Print($"Value type={value.GetType()}");
            Console.ReadLine();
        }
    }
}
