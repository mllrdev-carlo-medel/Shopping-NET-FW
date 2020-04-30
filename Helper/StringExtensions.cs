﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart_Console.Helper
{
    public static class StringExtensions
    {
        public static int ToInt(this string input, int defaultValue = 0)
        {
            return int.TryParse(input, out int value) ? value : defaultValue;
        }
    }
}
