using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_4
{
    class ProgramHelper: ProgramConverter, ICodeChecker
    {
        #region ICodeChecker

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
