internal class Program
{
    private static void Main(string[] args)
    {
        float balance = 0;
        float withdrawal = 0;
        float deposit = 0;
        bool menu = true;
        int menuOptions = 0;
        string answer = string.Empty;

        while (menu)
        {
            System.Console.WriteLine("Banksimulator");
            System.Console.WriteLine("[1] Check balance");
            System.Console.WriteLine("[2] Deposit");
            System.Console.WriteLine("[3] Withdrawal");

            answer = Console.ReadLine();

            bool isNumber = int.TryParse(answer, out menuOptions);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }

            switch (menuOptions)
            {
                case 1:

                    do
                    {
                        System.Console.WriteLine("Tryck på q för att återgå till menyn");


                        System.Console.WriteLine("Saldo: " + balance);
                        answer = Console.ReadLine();

                    } while (answer != "q");


                    break;

                case 2:

                    System.Console.WriteLine("How much would you like to deposit? ");

                    answer = Console.ReadLine();
                    bool success = float.TryParse(answer, out deposit);

                    if (deposit <= 0)
                    {
                        System.Console.WriteLine("Insättning kan ej var 0 eller mindre");
                    }
                    else
                    {

                        System.Console.WriteLine("Du har lagt in: " + deposit);
                        balance += deposit;

                    }

                    break;

                case 3:

                    System.Console.WriteLine("Hur mycket vill du ta ut: ");
                    answer = Console.ReadLine();
                    success = float.TryParse(answer, out withdrawal);
                    balance -= withdrawal;
                    do
                    {
                        Console.Clear();

                        if (withdrawal <= balance)
                        {

                            System.Console.WriteLine("Giltigt uttag");
                            System.Console.WriteLine("Totalt uttag: " + withdrawal);

                            System.Console.WriteLine("Tryck på q för komma till menyn");
                            answer = Console.ReadLine();

                        }
                        else
                        {
                            System.Console.WriteLine("Ogiltigt uttag");
                            answer = Console.ReadLine();
                        }

                    }
                    while (answer != "q");



                    break;
            }

        }
    }
}