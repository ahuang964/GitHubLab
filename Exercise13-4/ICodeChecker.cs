﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_4
{
    interface ICodeChecker: IConvertible
    {
        bool CodeCheckSyntax(string source, string language);
    }
}
