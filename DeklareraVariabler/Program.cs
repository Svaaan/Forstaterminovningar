internal class Program
{
    private static void Main(string[] args)
    {
        //Deklarera och tilldela värden till variabler
        int age = 10;
        float price = 10.2f;
        string name = "daniel";
        string lastName = "Svan";
        char letter = 'z';
        bool isTrue = true;
        string answer = string.Empty;
        bool input;

        //Skriv ut samtliga värden
        System.Console.WriteLine(name + ", " + age + ", " + price + ", " + name + ", " + letter + ", " + isTrue);

        System.Console.WriteLine("Hur gammal är du?");
        answer = Console.ReadLine();
        int age1 = 0;
        bool success = int.TryParse(answer, out age1);
        System.Console.WriteLine("Vad kostar 1Liter mjölk?");
        answer = Console.ReadLine();
        float price1 = 0;
        success = float.TryParse(answer, out price1);
        System.Console.WriteLine("Vad heter du?");
        string name1 = Console.ReadLine();
        System.Console.WriteLine("vilken är din favorit bokstav?");
        char letter1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter a bool: ");
        answer = Console.ReadLine();

        if (bool.TryParse(answer, out input))
        {
            System.Console.WriteLine("Korrekt: " + input);
            // The input was successfully parsed as a boolean value.
            // You can use the 'input' variable here.");
        }
        else
        {
            System.Console.WriteLine("Gick ej igenom");
            // The input could not be parsed as a boolean value.
            // You can prompt the user to try again or use a default value.
        }




        System.Console.WriteLine("Dina svar: " + age1 + ", " + price1 + ", " + name1 + ", " + letter1 + ", " + input);
    }

}