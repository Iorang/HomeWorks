﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    public class Cat : Animal
    {
        public override string Name { get; } = "Кошка";

        public override string Say()
        {
            return "Мяу";
        }
    }
}
