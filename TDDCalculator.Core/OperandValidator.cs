﻿using System;
using System.Collections.Generic;
using System.Text;
using TDDCalculator.Core.Abstractions;

namespace TDDCalculator.Core
{
    public class OperandValidator
    {
        public bool ValidateDivisor(decimal divisor)
        {
            if (divisor == 0)
            {
                return false;
            }

            return true;
        }
    }
}
