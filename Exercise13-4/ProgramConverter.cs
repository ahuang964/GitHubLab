using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_4
{
    class ProgramConverter: IConvertible
    {
        #region IConvertible
        public string ConvertToCSharp(string source)
        {
            string result = string.Format("ProgramConverter implement IConvertible {0} in C#.", source);
            return result;
        }

        public string ConvertToVB(string source)
        {
            string result = string.Format("ProgramConverter implement IConvertible {0} in VB.", source);
            return result;
        }
        #endregion
    }
}
