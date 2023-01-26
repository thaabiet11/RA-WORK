// Your names must be commented here
internal class Program
{
    private static void Main(string[] args)
    {
        string choose;
        int pIn;
        double nBalance, nBalance2, balance, nPin, deposit, withdraw;
        balance = 4500; Console.WriteLine("Please enter your Pin: ");
        pIn = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();
        if (pIn == 1398)
        {
            Console.WriteLine("Welcome, \n" + "Which Of the following Action Would You like to do?: ");
            Console.WriteLine("\n 1.Deposit:\n\n 2.Withdraw: \n\n 3.View Balance: \n\n 4.Change Pin: \n");
            choose = Console.ReadLine();
            if (choose == "Deposit")
            {
                Console.WriteLine("Current Balance: \nR" + balance); Console.WriteLine("How much would you like to Deposit:");
                deposit = Convert.ToDouble(Console.ReadLine()); nBalance = (balance + deposit); Console.WriteLine("New Balance: \nR" + nBalance);
                Console.ReadKey();
            }
            else if (choose == "Withdraw")
            {
                Console.WriteLine("Current Balance: \nR" + balance); Console.WriteLine("How much would you like to Withdraw:");
                withdraw = Convert.ToDouble(Console.ReadLine()); nBalance2 = (balance - withdraw); Console.WriteLine("New Balance: \nR" + nBalance2);
                Console.ReadKey();
            }
            else if (choose == "View Balance")
            {
                Console.WriteLine(" Your Current Balance is: \nR" + balance);
                Console.ReadKey();
            }
            else if (choose == "Change Pin")
            {
                Console.WriteLine("Please enter your Pin: ");
                nPin = Convert.ToDouble(Console.ReadLine()); Console.WriteLine(" Your New Pin is: \n" + nPin); Console.ReadKey();
            }
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Incorrect Pin ");
            Console.ReadKey();
        }
    }
}
    
