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

                        double x = 0;
                        double y = 0;

                        if (upperchoice == "Q")
                        {
                            break;
                        }

                        switch (upperchoice)
                        {
                           case "A":
                                x = GetValue("Enter first value");
                                y = GetValue("Enter second value");
                                Console.WriteLine(Calc.add(x, y));
                                break;
                            case "S":
                                x = GetValue("Enter first value");
                                y = GetValue("Enter second value");
                                Console.WriteLine(Calc.sub(x, y));
                                break;
                            case "D":
                                x = GetValue("Enter first value");
                                y = GetValue("Enter second value");
                                Console.WriteLine(Calc.div(x, y));
                                break;
                            case "M":
                                x = GetValue("Enter first value");
                                y = GetValue("Enter second value");
                                Console.WriteLine(Calc.mul(x, y));
                                break;
                            case "%":
                                x = GetValue("Enter percentage wanted");
                                y = GetValue("Out of...");
                                Console.WriteLine(Calc.perc(x, y));
                                break;
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
