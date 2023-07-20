using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic.Models
{
    internal class Calculator
    {
        public int num1;
        public int num2;

        public Calculator(int a, int b)
        {
            num1 = a;
            num2 = b;
        }
        public void Sum(int num)
        {
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                sum+= i;
            }

            sum += num;
            Console.WriteLine("Sum of number:" + sum );
        }
    }
}
