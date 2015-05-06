using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_4
{
    public class CustomCatError : System.ApplicationException
    {
        public CustomCatError(string message)
            : base(message)
        {

        }
    }
}
