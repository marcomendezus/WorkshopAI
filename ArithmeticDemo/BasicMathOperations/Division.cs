using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticDemo.BasicMathOperations
{
    public class Division
    {
        public static double DivisionOperation(int a, int b)
        {
            if (b != 0){return (double)a / b;}else{Console.WriteLine("Error: Division by zero");return double.NaN;}
        }
    }
}
