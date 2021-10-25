using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class Printer
    {
        public void Print()
        {
            Console.Write("Printer ");
            PrintNumber();
        }

        protected abstract void PrintNumber();
    }
}
