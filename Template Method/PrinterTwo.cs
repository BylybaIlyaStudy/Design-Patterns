﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public class PrinterTwo : Printer
    {
        protected override void PrintNumber()
        {
            Console.WriteLine("two");
        }
    }
}