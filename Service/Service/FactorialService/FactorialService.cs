using Service.Exceptions;
using Service.Helpers;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.FactorialService
{
    public class FactorialService : IfactorialService
    {
        public void Factorial(Predicate<int> function, int number)
        {
            try
            {
                if (function(number))
                {
                    FactorialServiceSupporters.CallFactorial(number);

                    Console.WriteLine(FactorialMessage.CalculationSuccess);
                }
                else
                {
                    throw new FactorialException(FactorialMessage.NumberIsWrong);
                }
            }
            catch (FactorialException message)
            {
                Console.WriteLine(message.Message);

            }
        }
       

    }
}
