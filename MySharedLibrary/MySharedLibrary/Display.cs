using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class Display
    {
        public void welcomeDisplay(string name)
        {
            Console.WriteLine("Welcome to Calculator, "+name);
        }
        public void resultDisplay(double x)
        {
            Console.WriteLine("The result of the chosen operation is "+x);
        }
        public void errorDisplay()
        {
            Console.WriteLine("Wrong input");
        }
        public void closingMessage(string name)
        {
            Console.WriteLine("Hope you like the application, thank you for using Calculator, "+name);
        }
        public int opChoice()
        {
            Console.WriteLine("Choose the operation\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
