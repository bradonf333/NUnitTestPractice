﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryCalculatorApp
{
    public class MemoryCalculator
    {
        public int CurrentValue { get; private set; }

        public void Add(int number)
        {
            CurrentValue += number;
        }

        public void Subtract(int number)
        {
            CurrentValue -= number;
        }

        public void Divide(int number)
        {
            CurrentValue = CurrentValue / number;
        }
    }
}
