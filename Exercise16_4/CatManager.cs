using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_4
{
    class CatManager
    {
        public List<Cat> cats;

        public void LookForBadAge()
        {
            try
            {
                foreach (Cat cat in cats)
                {
                    if (cat.Age <= 0)
                    {
                        throw new CustomCatError("Alert: this cat has a negative age!");
                    }
                }
            }
            catch (CustomCatError e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
