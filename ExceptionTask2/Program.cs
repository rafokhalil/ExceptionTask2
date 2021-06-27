using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ExceptionTask2
{
    class Program
    {

        class Card
        {
            public string PAN { get; set; }
            public string PIN { get; set; }
            public string CVC { get; set; }

            public DateTime ExpireDate { get; set; }

            public decimal Balance { get; set; }

            public void ShowCard()
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($" PAN :{PAN}");
                Console.WriteLine($"PIN : {PIN}");
                Console.WriteLine($"Expired Date: {ExpireDate}");
                Console.WriteLine($"Balance : {Balance}");

            }

        }

        class User
        {
            public string Name { get; set; }
            public string Surname { get; set; }


            public Card CreditCard { get; set; }
        }


        static void Run()
        {
            DateTime datetime = DateTime.Now;
            Random random = new Random();

            Card CreditCard1 = new Card
            {
                PAN = "5103234567899076",
                PIN = "3366",
                CVC = "140",
                ExpireDate = new DateTime(2021, 10, 30),
                Balance = random.Next(1000, 2000),
            };

            Card CreditCard2 = new Card
            {
                PAN = "510312345678",
                PIN = "1234",
                CVC = "456",
                ExpireDate = new DateTime(2022, 9, 30),
                Balance = random.Next(3000, 5000),
            };

            Card CreditCard3 = new Card
            {
                PAN = "510387654321",
                PIN = "9145",
                CVC = "789",
                ExpireDate = new DateTime(2019, 12, 30),
                Balance = random.Next(500, 900),
            };



            Card CreditCard4 = new Card
            {
                PAN = "515423456789",
                PIN = "7632",
                CVC = "156",
                ExpireDate = new DateTime(2025, 1, 30),
                Balance = random.Next(5000, 7000),
            };


            Card CreditCard5 = new Card
            {
                PAN = "510323458921",
                PIN = "6431",
                CVC = "936",
                ExpireDate = new DateTime(2019, 12, 30),
                Balance = random.Next(500, 900),
            };

            User user1 = new User
            {
                Name = "Vaqif",
                Surname = "Ismayilzade",
                CreditCard = CreditCard1,
            };


            User user2 = new User
            {
                Name = "Rafael",
                Surname = "Xelilzade",
                CreditCard = CreditCard2,
            };

            User user3 = new User
            {
                Name = "Kenan",
                Surname = "Agayev",
                CreditCard = CreditCard3,
            };

            User user4 = new User
            {
                Name = "Ismayil",
                Surname = "Eliyev",
                CreditCard = CreditCard4,
            };

            User user5 = new User
            {
                Name = "Yasin",
                Surname = "Quliyev",
                CreditCard = CreditCard5,
            };

            User[] users = new User[] { user1, user2, user3, user4, user5 };
            try
            {



            label1:
                Console.WriteLine("Please Enter your PIN:");

                string PIN = Console.ReadLine();

                if (PIN.Length == 4)
                {
                    foreach (var us in users)
                    {
                        if (us.CreditCard.PIN == PIN)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{us.Name}  {us.Surname}  Your Welcome, Please do your choice ");
                            Console.ResetColor();

                        label:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("1.Balance");
                            Console.WriteLine("2.Cash Money ");
                            Console.WriteLine("3.Send Money to onether card");
                            Console.WriteLine("4.Return back");
                            Console.ResetColor();
                            int select = int.Parse(Console.ReadLine());

                            if (select == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"Your Balance :{us.CreditCard.Balance}");
                                Console.WriteLine("If you want to return click  R ");
                                Console.ResetColor();

                                char symbol = char.Parse(Console.ReadLine());

                                if (symbol == 'R' || symbol == 'r')
                                {
                                    Console.Clear();
                                    goto label;
                                }
                            }

                            else if (select == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("1. 10$");
                                Console.WriteLine("2. 20$");
                                Console.WriteLine("3. 50$");
                                Console.WriteLine("4. 100$");
                                Console.WriteLine("5. Other");
                                Console.ResetColor();
                                int select1 = int.Parse(Console.ReadLine());


                                if (select1 == 1)
                                {
                                    if (us.CreditCard.Balance >= 10)
                                    {
                                        us.CreditCard.Balance -= 10;
                                    }
                                    else
                                    {
                                        throw new Exception(" Ohh sorry, You don't have money :(");
                                    }

                                    Console.WriteLine($" 10$ is removed in {datetime} from your card ");

                                }
                                else if (select1 == 2)
                                {
                                    if (us.CreditCard.Balance >= 20)
                                    {
                                        us.CreditCard.Balance -= 20;
                                    }
                                    else
                                    {
                                        throw new Exception(" Ohh sorry, You don't have money :(");
                                    }
                                    Console.WriteLine($" 20$ is removed in {datetime} from your card ");
                                }
                                else if (select1 == 3)
                                {
                                    if (us.CreditCard.Balance >= 50)
                                    {
                                        us.CreditCard.Balance -= 50;
                                    }
                                    else
                                    {
                                        throw new Exception(" Ohh sorry, You don't have money :(");
                                    }
                                    Console.WriteLine($" 50$ is removed in {datetime} from your card ");
                                }
                                else if (select1 == 4)
                                {
                                    if (us.CreditCard.Balance >= 100)
                                    {
                                        us.CreditCard.Balance -= 100;
                                    }
                                    else
                                    {
                                        throw new Exception(" Ohh sorry, You don't have money :(");
                                    }
                                    Console.WriteLine($" 100$ is removed in {datetime} from your card ");
                                }
                                else if (select1 == 5)
                                {
                                    Console.Write("Inlcude your money :");
                                    int includedMoney = int.Parse(Console.ReadLine());

                                    if (us.CreditCard.Balance >= includedMoney)
                                    {
                                        us.CreditCard.Balance -= includedMoney;
                                    }
                                    else
                                    {
                                        throw new Exception(" Ohh sorry, You don't have money :(");
                                    }

                                    Console.WriteLine($" {includedMoney}$ is removed in {datetime} from your card ");
                                }
                                else
                                {
                                    throw new InvalidOperationException("You input wrong key");
                                }

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("If you want to return click  R ");
                                Console.ResetColor();

                                char symbol1 = char.Parse(Console.ReadLine());

                                if (symbol1 == 'R' || symbol1 == 'r')
                                {
                                    Console.Clear();
                                    goto label;
                                }


                            }

                            else if (select == 3)
                            {
                                Console.Clear();
                                Console.WriteLine("Please Enter PIN:");
                                string PIN1 = Console.ReadLine();

                                foreach (var a in users)
                                {
                                    if (PIN1.Length == 4)
                                    {
                                        if (a.CreditCard.PIN == PIN1)
                                        {

                                            Console.WriteLine("How much money do you want to transfer");
                                            int TransferMoney = int.Parse(Console.ReadLine());
                                            a.CreditCard.Balance = a.CreditCard.Balance + TransferMoney;
                                            us.CreditCard.Balance = us.CreditCard.Balance - TransferMoney;
                                            Console.WriteLine($" Your money  is transfered in {datetime} from your card ");

                                            Console.ForegroundColor = ConsoleColor.Magenta;
                                            Console.WriteLine("If you want to return click  R ");
                                            Console.ResetColor();

                                            char symbol2 = char.Parse(Console.ReadLine());

                                            if (symbol2 == 'R' || symbol2 == 'r')
                                            {
                                                Console.Clear();
                                                goto label1;
                                            }

                                        }
                                    }
                                    else if (PIN.Length > 4 || PIN.Length < 4)
                                    {
                                        throw new ArgumentOutOfRangeException("PIN code is written outside the boundaries");
                                    }
                                }
                                throw new Exception("Can not found this PIN !!! ");
                            }




                            else if (select == 4)
                            {
                                Console.Clear();
                                goto label1;
                            }
                            else
                            {
                                throw new InvalidOperationException("You input wrong");
                            }
                        }
                    }

                }

                else if (PIN.Length > 4 || PIN.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("PIN code is written outside the boundaries");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Run();
        }


    }
}