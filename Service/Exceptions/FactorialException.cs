using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Exceptions
{
    internal class FactorialException:Exception
    {

        public FactorialException(string message):base(message)
        {

        }
    }
}
