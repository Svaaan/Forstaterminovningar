internal class Program
{
    private static void Main(string[] args)
    {
        string answer = string.Empty;
        int lol = 0;
        int value = 0;
        int encryptionValue = 0;
        int heltal = 0;
        // H, e, j = 104, 101, 106


        while (true)
        {
            System.Console.WriteLine("[1] Convert values");
            System.Console.WriteLine("[2] Caesar encryption");
            answer = Console.ReadLine();

            bool isNumber = int.TryParse(answer, out lol);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }
            switch (lol)
            {
                case 1:
                    //Sparar användar input
                    Console.WriteLine("Skriv en mening: ");
                    answer = Console.ReadLine();

                    //Hämtar varje enskild bokstav i meningen
                    foreach (char c in answer)
                    {
                        //Skriver ut varje char
                        System.Console.WriteLine(c);

                    }
                    //går igenom char och skriver dess int värde
                    foreach (char c in answer)
                    {
                        value = Convert.ToInt32(c);
                        Console.WriteLine(value);
                    }

                    //Varje enskilt värde binary läggs i en lista
                    List<string> binaryValues = new List<string>();
                    //Går igenom och skriver ut det binära värdet
                    foreach (char c in answer)
                    {
                        //Skickar in värden till listan
                        string binary = Convert.ToString(c, 2);
                        binaryValues.Add(binary);
                    }

                    //Skapar en sträng till varje item i listan som skapar ett mellanslag
                    string binaryString = string.Join(" ", binaryValues);
                    //Skriver ut alla items i listan med ett mellanslag
                    Console.WriteLine(binaryString);
                    break;
                case 2:

                    System.Console.WriteLine("Skrive en mening: ");
                    answer = Console.ReadLine();

                    foreach (char c in answer)
                    {
                        //Skriver ut varje char
                        System.Console.WriteLine(c);

                    }
                    bool success = false;
                    do
                    {
                        System.Console.WriteLine("Ange ett heltal: ");

                        success = int.TryParse(Console.ReadLine(), out heltal);

                    } while (!success);

                    foreach (char c in answer)
                    {
                        value = Convert.ToInt32(c);
            
                        encryptionValue = value + heltal;
                        Convert.ToChar(encryptionValue);

                        System.Console.WriteLine(Convert.ToChar(encryptionValue));
                    }

                    break;

            }
        }
    }
}