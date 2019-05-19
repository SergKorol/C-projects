using System;

namespace TipCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tipper tipper = new Tipper();

            for (; ; )
            {
                Console.WriteLine("Amount of bill?");

                tipper.Amount = double.Parse(Console.ReadLine());

                Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
                char operation = Console.ReadLine().ToUpper()[0];

                if (operation == 'D')
                {
                    Console.WriteLine("Number of visitors?");

                    int visitors = int.Parse(Console.ReadLine());
                    double amount = tipper.Divvy(visitors);

                    Console.WriteLine("Each visitor owes {0}", amount);
                }
                else if(operation == 'Q')
                {
                    break;
                }
                else 
                {
                    double result = 0.0;

                    switch (operation)
                    {
                        case 'B':
                            result = tipper.CalculateTip(10.0);
                            break;
                        case 'O':
                            result = tipper.CalculateTip();
                            break;
                        case 'G':
                            result = tipper.CalculateTip(20.0);
                            break;
                    }

                    Console.WriteLine("Calculated bill {0}, tip {1} = {2}",
                        tipper.Amount, result, tipper.Amount + result);
                }




            }


        }
    }
}
