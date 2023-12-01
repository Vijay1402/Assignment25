using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Addition
    {
        
        public void main()
        {
            Console.WriteLine("Enter first operand");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second operand");
            double y = double.Parse(Console.ReadLine());
            Calculations calc = new Calculations();
            Display disp = new Display();
            double result = calc.Add(x,y);
            disp.resultDisplay(result);
        }

    }
}
