using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedLibrary;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your name");
            string name = Console.ReadLine();
            Display disp = new Display();
            disp.welcomeDisplay(name);
            int op = disp.opChoice();
            switch (op)
            {
                case 1:
                    {
                        Addition a = new Addition();
                        a.main();
                    }
                break;
                case 2:
                    {
                        Subtraction s = new Subtraction();
                        s.main();
                    }
                break;
                case 3:
                    {
                        Multiplication
                            m = new Multiplication();
                        m.main();
                    }
                break;
                case 4:
                    {
                        Division d = new Division();
                        d.main();
                    }
                break;
                default:
                    {
                        disp.errorDisplay();
                    }
                break;
            }
            disp.closingMessage(name);
            Console.ReadKey();
        }
    }
}
