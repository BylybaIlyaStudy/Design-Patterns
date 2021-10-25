using System;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            new PrinterOne().Print();
            new PrinterTwo().Print();
        }
    }
}
