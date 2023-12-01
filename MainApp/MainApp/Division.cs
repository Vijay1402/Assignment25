using MySharedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Division
    {
        public void main()
        {
            Console.WriteLine("Enter first operand");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second operand");
            double y = double.Parse(Console.ReadLine());
            Calculations calc = new Calculations();
            Display disp = new Display();
            double result = calc.Divide(x, y);
            disp.resultDisplay(result);
        }
    }
}
