using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.FactorialService
{
    public class FactorialServiceSupporters
    {
        public static bool CheckNumber(int n)
        {
            if (n > 0)
            {
                return true;
            }
            return false;
        }
        public static void CallFactorial(int num)
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
