using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Exceptions
{
    public class PriceMustBeGreaterThanZeroException:Exception
    {
        public PriceMustBeGreaterThanZeroException(string message):base(message)
        {
            
        }
    }
}
