﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_3
{
    interface IConvertible
    {
        string ConvertToCSharp(string source);
        string ConvertToVB(string source);
    }
}
