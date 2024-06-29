using System.Collections;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();
            bool loggedIn = true;
            Console.WriteLine("Welcome!");
            while (loggedIn == true)
            {
                Console.WriteLine("What would you like to do today?");
                Console.Write("1 - Deposit |");
                Console.Write(" 2 - Withdraw |");
                Console.Write(" 3 - Get Balance |");
                Console.WriteLine(" 4 - Log Out");
                _ = int.TryParse(Console.ReadLine(), out int userInput);

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("How much would you like to deposit?");
                        double.TryParse(Console.ReadLine(), out double deposit);
                        account1.Deposit(deposit);
                        Console.WriteLine($"You have deposited ${deposit}");
                        Console.WriteLine("Press any key to return");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("How much would you like to withdraw?");
                        double.TryParse(Console.ReadLine(), out double withdraw);
                        account1.Withdraw(withdraw);
                        double balance = account1.GetBalance();
                        if (withdraw <= balance) 
                        {
                            Console.WriteLine($"You have withdrawn ${withdraw}");
                        }
                        Console.WriteLine("Press any key to return");
                        Console.ReadLine();
                        break;
                
                    case 3:
                        Console.WriteLine($"Your balance is: ${account1.GetBalance()}");
                        Console.WriteLine("Press any key to return");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        loggedIn = false;
                        break;

                    default:
                        Console.WriteLine("That is not a valid input.");
                        Console.WriteLine("Press any key to return");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
