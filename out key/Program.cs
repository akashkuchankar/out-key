using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_key
{
    internal class Program
    {
        static void Calculation(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = a + b;
            sub = a - b;
            mul = a * b;
        }
        static void Main(string[] args)
        {
            int a = 45, b = 23, sum, sub, mul;
            Calculation(a, b, out sum, out sub, out mul);
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
        }

    }
}
