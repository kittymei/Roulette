using System;

namespace Roulette
{
    public class Program
    {
        static void Main(string[] args)
        {
            string betChoice;

            int[] num = new int[] {00, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
                                    13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24,
                                    25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36};

            Console.WriteLine("Welcome to the Roulette table!");
            Console.Write("\nPress \"ENTER\" to start");
            Console.ReadLine();
            Console.WriteLine("-----------------------------------------");

            Console.Write("Enter a bet between $1 - $5000: $");
            int bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered $" + bet);
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\t1 = Bin");
            Console.WriteLine("\t2 = Even or Odd");
            Console.WriteLine("\t3 = Red or Black");
            Console.WriteLine("\t4 = Low or High");
            Console.WriteLine("\t5 = Dozen");
            Console.WriteLine("\t6 = Column");
            Console.WriteLine("\t7 = Street Row");
            Console.WriteLine("\t8 = Double Rows");
            Console.WriteLine("\t9 = Split");
            Console.WriteLine("\t10 = Corner");
            Console.Write("Select your bet from above: ");
            betChoice = Convert.ToString(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");

            if (betChoice == "1")
            {
                Console.Write("Enter a bin number between 00-36: ");
                int numYouSelected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have selected bin " + numYouSelected);

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");

                if (numYouSelected == index)
                {
                    Console.WriteLine("Congrats! You won.");
                }
                else
                {
                    Console.WriteLine("You lose. Try again!");
                }
            }

            else if (betChoice == "2")
            {
                Console.WriteLine("\t1 = Odd numbers");
                Console.WriteLine("\t2 = Even numbers");
                Console.Write("Select an option from above: ");
                int OddOrEven = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");

                if (OddOrEven == 1)
                {
                    Console.WriteLine("\nYou selected ODD numbers for your bet");
                    if (index % 2 == 0)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                }
                if (OddOrEven == 2)
                {
                    Console.WriteLine("\nYou selected EVEN numbers for you bet");
                    if (index % 2 == 1)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }

                }
            }

            // need to figure out how to tell the difference between red and black
            else if (betChoice == "3")
            {
                int[] red = new int[] { 1, 3, 5, 7, 12, 14, 16, 18, 19, 21, 23, 25,
                                     27, 30, 32, 34, 36 };
                int[] black = new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24,
                                       26, 28, 29, 31, 33, 35 };
                Console.WriteLine("\t1 = Red numbers");
                Console.WriteLine("\t2 = Black numbers");
                Console.Write("Select an option from above: ");
                int RedOrBlack = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");

                if (RedOrBlack == 1)
                {
                    Console.WriteLine("\nYou have selected RED numbers for your bet");
                    if (index == 0)
                    {

                    }


                }
                if (RedOrBlack == 2)
                {
                    Console.WriteLine("\nYou have selected BLACK numbers for your bet");
                }
            }

            else if (betChoice == "4")
            {
                Console.WriteLine("\t1 = Low numbers");
                Console.WriteLine("\t2 = High numbers");
                Console.Write("Select an option from above: ");
                int LowOrHigh = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");
                Console.WriteLine("-----------------------------------------");

                if (LowOrHigh == 1)
                {
                    Console.WriteLine("You have selected LOW numbers for your bet");

                    if (index <= 18)
                    {
                        Console.WriteLine("\nThe wheel stopped on a LOW number \nCongrats! You won!");
                    }
                    else if (index >= 19)
                    {
                        Console.WriteLine("\nThe wheel stopped on a HIGH number \nSorry you lost. Try Again!");
                    }
                }

                else if (LowOrHigh == 2)
                {
                    Console.WriteLine("You have selected HIGH numbers for your bet");

                    if (index <= 18)
                    {
                        Console.WriteLine("\nThe wheel stopped on a LOW number \nSorry you lost. Try Again!");
                    }
                    else if (index >= 19)
                    {
                        Console.WriteLine("\nThe wheel stopped on a HIGH number \nCongrats! You won!");
                    }
                }
            }

            else if (betChoice == "5")
            {
                Console.WriteLine("\t1 = 1st dozen");
                Console.WriteLine("\t2 = 2nd dozen");
                Console.WriteLine("\t3 = 3rd dozen");
                Console.Write("Select an option from above: ");
                int dozenChoice = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");
                Console.WriteLine("-----------------------------------------");

                if (dozenChoice == 1)
                {
                    Console.WriteLine("You selected the 1ST dozen for your bet");

                    if (0 < index && index <= 12)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 1ST dozen \nCongrats! You won!");
                    }
                    else if (index >= 13 && index <= 24)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 2ND doezen \nSorry you lost.");
                    }
                    else if (index >= 25 && index <= 36)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 3RD doezen \nSorry you lost.");
                    }
                }
                else if (dozenChoice == 2)
                {
                    Console.WriteLine("You selected the 2ND dozen for your bet");

                    if (0 <= index && index <= 12)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 1ST dozen \nSorry you lost.");
                    }
                    else if (13 < index && index <= 24)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 2ND doezen \nCongrats! You won!");
                    }
                    else if (index >= 25 && index <= 36)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 3RD doezen \nSorry you lost.");
                    }

                }
                else if (dozenChoice == 3)
                {
                    Console.WriteLine("You selected the 3RD dozen for your bet");

                    if (0 <= index && index <= 12)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 1ST dozen \nSorry you lost.");
                    }
                    else if (index >= 13 && index <= 24)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 2ND doezen \nSorry you lost.");
                    }
                    else if (25 < index && index <= 36)
                    {
                        Console.WriteLine("\nThe wheel stopped at the 3RD doezen \nCongrats! You won!");
                    }
                }


            }

            else if (betChoice == "6")
            {
                Console.WriteLine("\t1 = 1st Column");
                Console.WriteLine("\t2 = 2nd Column");
                Console.WriteLine("\t3 = 3rd Column");
                Console.Write("Select a column from above: ");
                int columnChoice = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");
                Console.WriteLine("-----------------------------------------");

                if (columnChoice == 1)
                {
                    Console.WriteLine("You selected the 1ST COLUMN as your bet");
                }

                else if (columnChoice == 2)
                {
                    Console.WriteLine("You selected the 2ND COLUMN as your bet");
                }
                else if (columnChoice == 3)
                {
                    Console.WriteLine("You selected the 3RD COLUMN as your bet");
                }
            }

            else if (betChoice == "7")
            {
                Console.WriteLine("\t1 = 1/2/3");
                Console.WriteLine("\t2 = 4/5/6");
                Console.WriteLine("\t3 = 7/8/9");
                Console.WriteLine("\t4 = 10/11/12");
                Console.WriteLine("\t5 = 13/14/15");
                Console.WriteLine("\t6 = 16/17/18");
                Console.WriteLine("\t7 = 19/20/21");
                Console.WriteLine("\t8 = 22/23/24");
                Console.WriteLine("\t9 = 25/26/27");
                Console.WriteLine("\t10 = 28/29/30");
                Console.WriteLine("\t11 = 31/32/33");
                Console.WriteLine("\t12 = 34/35/36");
                Console.Write("Select a row from above: ");
                int rowChoice = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");
                Console.WriteLine("-----------------------------------------");

                if (rowChoice == 1)
                {
                    if (index <= 3)
                    {
                        Console.WriteLine("You selected row 1 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 4)
                    {
                        Console.WriteLine("You selected row 1 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                else if (rowChoice == 2)
                {
                    if (index <= 3)
                    {
                        Console.WriteLine("You selected row 2 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 6)
                    {
                        Console.WriteLine("You selected row 2 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 7)
                    {
                        Console.WriteLine("You selected row 2 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }

                else if (rowChoice == 3)
                {
                    if (index <= 6)
                    {
                        Console.WriteLine("You selected row 3 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 9)
                    {
                        Console.WriteLine("You selected row 3 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 10)
                    {
                        Console.WriteLine("You selected row 3 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }

                else if (rowChoice == 4)
                {
                    if (index <= 9)
                    {
                        Console.WriteLine("You selected row 4 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 12)
                    {
                        Console.WriteLine("You selected row 4 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 13)
                    {
                        Console.WriteLine("You selected row 4 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                
                else if (rowChoice == 5)
                {
                    if (index <= 12)
                    {
                        Console.WriteLine("You selected row 5 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 15)
                    {
                        Console.WriteLine("You selected row 5 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 16)
                    {
                        Console.WriteLine("You selected row 5 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }

                else if (rowChoice == 6)
                {
                    if (index <= 15)
                    {
                        Console.WriteLine("You selected row 6 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 18)
                    {
                        Console.WriteLine("You selected row 6 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 19)
                    {
                        Console.WriteLine("You selected row 6 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                else if (rowChoice == 7)
                {
                    if (index <= 18)
                    {
                        Console.WriteLine("You selected row 7 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 21)
                    {
                        Console.WriteLine("You selected row 7 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 22)
                    {
                        Console.WriteLine("You selected row 7 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                else if (rowChoice == 8)
                {
                    if (index <= 21)
                    {
                        Console.WriteLine("You selected row 8 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 24)
                    {
                        Console.WriteLine("You selected row 8 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 25)
                    {
                        Console.WriteLine("You selected row 8 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                
                else if (rowChoice == 9)
                {
                    if (index <= 24)
                    {
                        Console.WriteLine("You selected row 9 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 27)
                    {
                        Console.WriteLine("You selected row 9 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 28)
                    {
                        Console.WriteLine("You selected row 9 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }

                else if (rowChoice == 10)
                {
                    if (index <= 27)
                    {
                        Console.WriteLine("You selected row 10 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 30)
                    {
                        Console.WriteLine("You selected row 10 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 31)
                    {
                        Console.WriteLine("You selected row 10 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }

                else if (rowChoice == 11)
                {
                    if (index <= 30)
                    {
                        Console.WriteLine("You selected row 11 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 33)
                    {
                        Console.WriteLine("You selected row 11 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 34)
                    {
                        Console.WriteLine("You selected row 11 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
                else if (rowChoice == 12)
                {
                    if (index <= 33)
                    {
                        Console.WriteLine("You selected row 12 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                    else if (index <= 36)
                    {
                        Console.WriteLine("You selected row 12 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                }

            }

            else if (betChoice == "8")
            {
                Console.WriteLine("\t1 = 1/2/3/4/5/6");
                Console.WriteLine("\t2 = 7/8/9/10/11/12");
                Console.WriteLine("\t3 = 13/14/15/16/17/18");
                Console.WriteLine("\t4 = 19/20/21/22/23/24");
                Console.WriteLine("\t5 = 25/26/27/28/29/30");
                Console.WriteLine("\t6 = 31/32/33/34/35/36");
                Console.Write("Select a row from above: ");
                int rowChoice = Convert.ToInt32(Console.ReadLine());

                Random bin = new Random();
                int index = bin.Next(00, 36);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"The wheel stopped at {num[index]}");
                Console.WriteLine("-----------------------------------------");

                if (rowChoice == 1)
                {
                    if (index <= 6)
                    {
                        Console.WriteLine("You selected row 1 as your bet");
                        Console.WriteLine("Congrats you won!");
                    }
                    else if (index >= 7)
                    {
                        Console.WriteLine("You selected row 1 as your bet");
                        Console.WriteLine("Sorry you lost!");
                    }
                }
            }

            // need to figure out split
            else if (betChoice == "9")
            {
                Console.WriteLine("You selected a split bet");
            }

            // need to figuree out corner
            else if (betChoice == "10")
            {
                Console.WriteLine("You selected a corner bet");

            }

        }
    }
}
