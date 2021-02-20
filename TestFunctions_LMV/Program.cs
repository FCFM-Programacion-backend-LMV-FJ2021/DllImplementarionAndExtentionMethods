using MyFunctionsDWB_LMV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFunctions_LMV
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 23;
            decimal y = 41;

            Functions fn = new Functions();
            var sum = fn.Sum(x, y);
            var mult = fn.Mult(x, y);
            var div = fn.Div(x, y);
            var resta = fn.Resta(x, y);

            Console.WriteLine("La suma es: " + sum);
            Console.WriteLine("La multiplicación es: " + mult);
            Console.WriteLine("La división es: " + div);
            Console.WriteLine("La resta es: " + resta);

            Console.ReadLine();

        }
    }
}
