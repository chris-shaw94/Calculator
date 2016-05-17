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
            {
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
                            double x = GetValue("Enter first value");
                            double y = GetValue("Enter second value");
                            Console.WriteLine(Calc.add(x, y));
                        }
                        else if (upperchoice == "S")
                        {
                            double x = GetValue("Enter first value");
                            double y = GetValue("Enter second value");
                            Console.WriteLine(Calc.sub(x, y));
                        }
                        else if (upperchoice == "D")
                        {
                            double x = GetValue("Enter first value");
                            double y = GetValue("Enter second value");
                            Console.WriteLine(Calc.div(x, y));
                        }
                        else if (upperchoice == "M")
                        {
                            double x = GetValue("Enter first value");
                            double y = GetValue("Enter second value");
                            Console.WriteLine(Calc.mul(x, y));
                        }

                        else if (upperchoice == "%")
                        {
                            double x = GetValue("Enter percentage wanted");
                            double y = GetValue("Out of...");
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

        public static double GetValue(string message)
        {
            Console.WriteLine(message);
            return double.Parse(Console.ReadLine());
        }
    }
}
