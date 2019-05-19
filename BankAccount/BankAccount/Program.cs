using System;

namespace BankAccount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(500);
            BankAccount wallet = new BankAccount(200);
            int point;
            do
            {
                Console.WriteLine("\nMenu options:");
                Console.WriteLine("1) Deposit to bank");
                Console.WriteLine("2) Withdraw from bank");
                Console.WriteLine("3) Display money");
                Console.WriteLine("4) Quit");

                point = int.Parse(Console.ReadLine());

                switch (point)
                {
                    case 1:
                        {
                            transfer(wallet, bankAccount);
                            break;
                        }

                    case 2:
                        {
                            transfer(bankAccount, wallet);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Your balance:");
                            Console.WriteLine("Cash in bank: {0}", bankAccount.Money);
                            Console.WriteLine("Cash in wallet: {0}", wallet.Money);
                            break;
                        }
                    case 4:
                        { break; }
                    default:
                        {
                            Console.WriteLine("Choose another item");
                            break;
                        }
                }
            } while (point != 4);
        }

        public static void transfer(BankAccount from, BankAccount to)
        {
            Console.WriteLine("Enter amount of money:");
            double sum = double.Parse(Console.ReadLine());

            if (from.Withdraw(sum))
            {
                to.Deposit(sum);
            }
            else
            {
                Console.WriteLine("\\nThere isn't enough money!");
            }
        }


        }
        
  }

