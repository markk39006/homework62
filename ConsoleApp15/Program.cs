using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            bool main = true;
            int cash = 1000;
            while (main == true)
            {
                Console.WriteLine("available amount :{0}", cash);
                Console.WriteLine("If you want to withdraw money, press 1");
                Console.WriteLine("If you want to make a deposit, press 2");
                Console.WriteLine("Exit press 3");
                int n = int.Parse(Console.ReadLine());
                if (n != 1 && n != 2 && n != 3)
                {
                    while (check == true)
                    {
                        Console.WriteLine("Please input again ");
                        n = int.Parse(Console.ReadLine());
                        if (n == 1 || n == 2)
                        {
                            check = false;
                        }
                    }
                }
                if (n == 1)
                {
                    bool n1 = true;
                    while (n1 == true)
                    {
                        Console.WriteLine("available amount :{0}", cash);
                        Console.Write("Enter the amount you wish to withdraw. : ");
                        int withdraw = int.Parse(Console.ReadLine());
                        if (withdraw > cash || withdraw < 0)
                        {
                            bool checkwithdraw = true;
                            while (checkwithdraw == true)
                            {
                                Console.Write("Please Enter the amount you wish to withdraw again : ");
                                withdraw = int.Parse(Console.ReadLine());
                                if (withdraw > 0 && withdraw < cash)
                                {
                                    checkwithdraw = false;
                                }
                            }
                        }
                        cash = cash - withdraw;
                        Console.WriteLine("available amount :{0}", cash);
                        Console.WriteLine("************************");
                        n1 = false;
                    }

                }
                if (n == 2)
                {
                    bool n2 = true;
                    while (n2 == true)
                    {
                        Console.WriteLine("available amount :{0}", cash);
                        Console.WriteLine("Enter the amount you wish to deposit : ");
                        int deposit = int.Parse(Console.ReadLine());
                        if (deposit < 0)
                        {
                            bool checkdeposit = true;
                            while (checkdeposit == true)
                            {
                                Console.Write("Please enter the amount you wish to deposit again : ");
                                deposit = int.Parse(Console.ReadLine());
                                if (deposit > 0)
                                {
                                    checkdeposit = false;
                                }
                            }
                        }
                        cash = deposit + cash;
                        Console.WriteLine("available amount :{0}", cash);
                        Console.WriteLine("************************");
                        n2 = false;
                    }
                }
                if (n == 3)
                {
                    main = false;
                }
            }
        }
    }
}
