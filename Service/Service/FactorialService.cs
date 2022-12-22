using Service.Exceptions;
using Service.Helpers;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class FactorialService : IfactorialService
    {
        public void Factorial(Predicate<int> function, int number)
        {
			try
			{
				if (function(number))
				{
					FactorialService.CalFactorial(number);
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
        public static bool CheckNumber(int n)
        {
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public static void CalFactorial(int num)
		{
            int F = 1;
            for (int i = 1; i <= num; i++)
            {
                F *= i;
            }
			Console.WriteLine(F);
        }
		
    }
}
