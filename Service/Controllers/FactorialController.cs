using Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class FactorialController
    {
        public static void CalculateFactorial(int number)
        {
            FactorialService factorial1 = new FactorialService();

            factorial1.Factorial(FactorialService.CheckNumber, number);
            
        }

        public static void CheckFactorial()
        {
            Console.Write("Write number: ");
            int n = int.Parse(Console.ReadLine());
            CalculateFactorial(n);
        }
    }
}
