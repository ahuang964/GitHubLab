using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_2
{
    class ProgramHelper: IConvertible
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

        #endregion

    }
}
