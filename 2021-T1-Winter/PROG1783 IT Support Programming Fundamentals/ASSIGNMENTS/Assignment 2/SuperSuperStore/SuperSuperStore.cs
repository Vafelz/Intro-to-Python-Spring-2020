﻿using System;
/*
 * AUTHOR:  Duke Do
 * ID NUM:  8632240
 * DATE:    05/04/2021
 * COURSE:  PROG1783: IT Support Programming Fundamentals
 * PROJECT:  Assignment 2: Improved Superstore
 * DESCRIPTION:
 * FIRST TASK:
 * Review your code from the first assignment, correct any issues or missed items
 * 
 * SECOND TASK:
 * Your program should meet the same specifications as in Assignment 1, with the following additions:
 *  1) The available products should be stored in an array of structures
 *      + Up to 6 items and their price
 *  - Pick another 4 items, including sub-type and colour
 *  
 *  2) Limit the customer to a max quantity of 10 per item
 *  
 *  3) If the customer places an order for the same type of item again, have it replace the previous order
 *  
 *  4) Add error checking to resolve/prevent common errors, including program crashes/exceptions
 *  For example:
 *      + Inputs with leading or trailing blank spaces whould work (ie, " 1 " == "1")
 *      + Handle crash/exception for trying int.Parse("Fred")
 *      + Other invalid inputs should be handled without crash
 * 
 *  5) Use an array of structures to store the items available, and another separate array of structures to record shopping cart
 */

namespace SuperSuperStore
{
    class SuperSuperStore
    {
        // Break() method for text readability
        static void Break()
        {
            Console.WriteLine();
        }

        // Sleep() method to "slow program"
        static void Sleep()
        {
            System.Threading.Thread.Sleep(500);
        }

        // SleepBreak() method to "slow program" and format text readability
        static void SleepBreak()
        {
            Console.Write("\n");
            System.Threading.Thread.Sleep(500);
        }

        // Main program method
        static void Main(string[] args)
        {
            // Variables
            int quan1, quan2, i = 0;
            double cost1 = 0, price1, cost2 = 0, price2, discount1 = 1, discount2 = 1;
            string input, savings, sub, tax, total;

            // Items array
            String[] item1 = new string[6];
            String[] item2 = new string[6];

            // Welcome message
            Console.WriteLine("Welcome to the Atlast Store!");

            Break();

            // Inventory information
            Console.WriteLine("This location currently has the following items in stock\n:" +
                "   1 - Helmets        $24.95\n" +
                "   2 - Hockey Sticks   $7.99\n" +
                "   3 - Knee Pads      $19.95");

            Break();

            // ITEM 1
            // ITEM NAME
            Console.WriteLine("What is the 1st item you want to purchase?");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item1[0] = "Helmets";
                    item1[2] = "$24.95";
                    cost1 = 24.95;
                    i++;
                }
                else if (input == "2")
                {
                    item1[0] = "Hockey Sticks";
                    item1[2] = "$7.99";
                    cost1 = 7.99;
                    i++;
                }
                else if (input == "3")
                {
                    item1[0] = "Knee Pads";
                    item1[2] = "$19.95";
                    cost1 = 19.95;
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // TYPE
            Console.WriteLine("Please pick an available option:\n" +
                "   1 - Adult\n" +
                "   2 - Youth");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item1[1] = "Adult";
                    i++;
                }
                else if (input == "2")
                {
                    item1[1] = "Youth";
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // COLOUR
            Console.WriteLine("Please pick an available colour:\n");
            if (item1[0] == "Helmets")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Green");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] += ", Green";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }
            else if (item1[0] == "Hockey Sticks")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Blue\n" +
                    "   3 - Yellow");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] += ", Blue";
                        i++;
                    }
                    else if (input == "3")
                    {
                        item1[1] += ", Yellow";
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }
            else if (item1[0] == "Knee Pads")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Grey");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item1[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item1[1] += ", Grey";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }

            Break();

            // QUANTITY
            Console.WriteLine("How many {0} would you like to purchase?", item1[0].ToLower());
            item1[3] = Console.ReadLine();

            // DISCOUNTS
            do
            {
                quan1 = int.Parse(item1[3]);
                if (quan1 >= 5)
                {
                    discount1 = 0.7;
                    item1[4] = "30%";
                    i++;
                }
                else if (quan1 < 5)
                {
                    Break();

                    Console.WriteLine("Are you a student? Y / N");
                    input = Console.ReadLine().ToLower();
                    do
                    {
                        if (input == "y")
                        {
                            discount1 = 0.93;
                            item1[4] = "7%";
                            i++;
                        }
                        else if (input == "n")
                        {
                            Break();

                            Console.WriteLine("Are you a senior? Y / N");
                            input = Console.ReadLine().ToLower();
                            do
                            {
                                if (input == "y")
                                {
                                    discount1 = 0.93;
                                    item1[4] = "7%";
                                    i++;
                                }
                                else if (input == "n")
                                {
                                    i++;
                                }
                                else
                                {
                                    Break();

                                    Console.WriteLine("Please enter Y or N.");
                                    input = Console.ReadLine().ToLower();
                                }
                            } while (i == 0);

                            i++;
                        }
                        else
                        {
                            Break();

                            Console.WriteLine("Please enter Y or N.");
                            input = Console.ReadLine().ToLower();
                        }
                    } while (i == 0);
                }
                else
                {
                    Break();

                    Console.WriteLine("Please select quantity by number (e.g. 5)");
                    item1[3] = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // ITEM 2
            // ITEM NAME
            Console.WriteLine("What is the 2nd item you want to purchase?");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item2[0] = "Helmets";
                    item2[2] = "$24.95";
                    cost2 = 24.95;
                    i++;
                }
                else if (input == "2")
                {
                    item2[0] = "Hockey Sticks";
                    item2[2] = "$7.99";
                    cost2 = 7.99;
                    i++;
                }
                else if (input == "3")
                {
                    item2[0] = "Knee Pads";
                    item2[2] = "$19.95";
                    cost2 = 19.95;
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // TYPE
            Console.WriteLine("Please pick an available option:\n" +
                "   1 - Adult\n" +
                "   2 - Youth");
            input = Console.ReadLine();
            do
            {
                if (input == "1")
                {
                    item2[1] = "Adult";
                    i++;
                }
                else if (input == "2")
                {
                    item2[1] = "Youth";
                    i++;
                }
                else
                {
                    Break();

                    Console.WriteLine("Please choose one of the available options by number.");
                    input = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // COLOUR
            Console.WriteLine("Please pick an available colour:\n");
            if (item2[0] == "Helmets")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Green");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] += ", Green";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }
            else if (item2[0] == "Hockey Sticks")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Blue\n" +
                    "   3 - Yellow");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] += ", Blue";
                        i++;
                    }
                    else if (input == "3")
                    {
                        item2[1] += ", Yellow";
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }
            else if (item2[0] == "Knee Pads")
            {
                Console.WriteLine("   1 - Black\n" +
                    "   2 - Grey");
                input = Console.ReadLine();
                do
                {
                    if (input == "1")
                    {
                        item2[1] += ", Black";
                        i++;
                    }
                    else if (input == "2")
                    {
                        item2[1] += ", Grey";
                        i++;
                    }
                    else
                    {
                        Break();

                        Console.WriteLine("Please choose one of the available options by number.");
                        input = Console.ReadLine();
                    }
                } while (i == 0);
            }

            Break();

            // QUANTITY
            Console.WriteLine("How many {0} would you like to purchase?", item2[0].ToLower());
            item2[3] = Console.ReadLine();

            // DISCOUNTS
            do
            {
                quan2 = int.Parse(item2[3]);
                if (quan2 >= 5)
                {
                    discount2 = 0.7;
                    item2[4] = "30%";
                    i++;
                }
                else if (quan2 < 5)
                {
                    Break();

                    Console.WriteLine("Are you a student? Y / N");
                    input = Console.ReadLine().ToLower();
                    do
                    {
                        if (input == "y")
                        {
                            discount2 = 0.93;
                            item2[4] = "7%";
                            i++;
                        }
                        else if (input == "n")
                        {
                            Break();

                            Console.WriteLine("Are you a senior? Y / N");
                            input = Console.ReadLine().ToLower();
                            do
                            {
                                if (input == "y")
                                {
                                    discount2 = 0.93;
                                    item2[4] = "7%";
                                    i++;
                                }
                                else if (input == "n")
                                {
                                    i++;
                                }
                                else
                                {
                                    Break();

                                    Console.WriteLine("Please enter Y or N.");
                                    input = Console.ReadLine().ToLower();
                                }
                            } while (i == 0);

                            i++;
                        }
                        else
                        {
                            Break();

                            Console.WriteLine("Please enter Y or N.");
                            input = Console.ReadLine().ToLower();
                        }
                    } while (i == 0);
                }
                else
                {
                    Break();

                    Console.WriteLine("Please select quantity by number (e.g. 5)");
                    item2[3] = Console.ReadLine();
                }
            } while (i == 0);

            Break();

            // CALCULATIONS
            // PRICE
            price1 = cost1 * quan1 * discount1;
            item1[5] = "$" + price1.ToString("0.##");
            price2 = cost2 * quan2 * discount2;
            item2[5] = "$" + price2.ToString("0.##");

            // SAVINGS
            savings = (price1 * (1 - discount1) + price2 * (1 - discount2)).ToString("0.##");

            // SUB-TOTAL
            sub = "$" + (price1 + price2).ToString("0.##");

            // TAX
            tax = "$" + ((price1 + price2) * 0.13).ToString("0.##");

            // GRAND TOTAL
            total = "$" + ((price1 + price2) * 0.13 + price1 + price2).ToString("0.##");

            // OUTPUT
            Console.WriteLine("Item Type       Details         Cost per   Qnty   Discount     Total");
            Console.WriteLine("-------------   -------------   --------   ----   --------   -------");
            Console.WriteLine("{0, -13}   {1, -13}   {2, 8}   {3, 4}   {4, 8}   {5, 7}", item1[0], item1[1], item1[2], item1[3], item1[4], item1[5]);
            Console.WriteLine("{0, -13}   {1, -13}   {2, 8}   {3, 4}   {4, 8}   {5, 7}", item2[0], item2[1], item2[2], item2[3], item2[4], item2[5]);
            Console.WriteLine();
            if (discount1 != 1 || discount2 != 1)
            {
                Console.WriteLine("                                               Total Savings: {0, 7}\n", savings);
            }
            Console.WriteLine("                                                   Sub-Total: {0, 7}", sub);
            Console.WriteLine("                                                         Tax: {0, 7}", tax);
            Console.WriteLine("                                                 Grand Total: {0, 7}", total);
        }
    }
}