using System;

namespace MyJournal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            Console.WriteLine(myJournal.JournalMessage);

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1) Unlock");
                Console.WriteLine("2) Create entry");
                Console.WriteLine("3) Read entry");
                Console.WriteLine("4) Lock");
                Console.WriteLine("5) Quit");
                Console.WriteLine("-----------------------------------------\n");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter journal password");
                            string password = Console.ReadLine();
                            if(myJournal.UnlockJournal(password))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You opened the journal");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incorrect password!");
                            }
                            break;
                        }
                    case 2:
                        {
                            if(myJournal.Entry == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You must unlock journal first");
                            }
                            else
                            {
                                Console.WriteLine("Enter the journal text");
                                string journalMessage = Console.ReadLine();

                                myJournal.Entry.Text = journalMessage;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (myJournal.Entry == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You must unlock journal first");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(myJournal.Entry.Text);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Last edit " + myJournal.Entry.LastEditTime.ToShortDateString()
                                                              + " " + myJournal.Entry.LastEditTime.ToLongTimeString());
                            }
                            break;
                        }
                    case 4:
                        {
                            myJournal.LockJournal();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }

                }
                Console.ResetColor();
            } while (choice != 5);
        }
    }
}
