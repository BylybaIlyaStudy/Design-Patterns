﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command
{
    public interface ICommand
    {
        public Person Receiver { get; set; }

        public void Execute();
    }
}
