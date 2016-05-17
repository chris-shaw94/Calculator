using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            while (true)
                try
                {
                    {
                        Console.WriteLine("Choose a function: Add- A, Subtract- S, Divide- D, Multiply- M, Percentage- %, Quit- Q");
                        string choice = Console.ReadLine();
                        string upperchoice = choice.ToUpper();
                        if (upperchoice == "Q")
                        {
                            break;
                        }
                        if (upperchoice == "A")
                        {
                            Console.WriteLine("Enter first value");
                            double x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second value");
                            double y = double.Parse(Console.ReadLine());
                            Console.WriteLine(Calc.add(x, y));
                        }
                        else if (upperchoice == "S")
                        {
                            Console.WriteLine("Enter first value");
                            double x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second value");
                            double y = double.Parse(Console.ReadLine());
                            Console.WriteLine(Calc.sub(x, y));
                        }
                        else if (upperchoice == "D")
                        {
                            Console.WriteLine("Enter first value");
                            double x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second value");
                            double y = double.Parse(Console.ReadLine());
                            Console.WriteLine(Calc.div(x, y));
                        }
                        else if (upperchoice == "M")
                        {
                            Console.WriteLine("Enter first value");
                            double x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second value");
                            double y = double.Parse(Console.ReadLine());
                            Console.WriteLine(Calc.mul(x, y));
                        }

                        else if (upperchoice == "%")
                        {
                            Console.WriteLine("Enter percentage wanted");
                            double x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Out of...");
                            double y = double.Parse(Console.ReadLine());
                            Console.WriteLine(Calc.perc(x, y));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}
