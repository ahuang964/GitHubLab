using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_3
{
    class ProgramHelper: ICodeChecker
    {
        #region IConvertible

        public string ConvertToCSharp(string source)
        {
            string result = source+" turned in to C#.";
            return result;
        }

        public string ConvertToVB(string source)
        {
            string result = source+" turned into VB.";
            return result;
        }

        bool ICodeChecker.CodeCheckSyntax(string source, string language)
        {
            if (!string.IsNullOrEmpty(source))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
