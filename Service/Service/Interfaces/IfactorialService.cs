using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IfactorialService
    {
        public void Factorial(Predicate<int> function, int number);
    }
}
