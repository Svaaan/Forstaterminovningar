internal class Program
{
    private static void Main(string[] args)
    {
        //Deklarerar x och y som vara hålla talen i multiplikations tabellen
        int x, y;
        string answer = string.Empty;
        bool success;
        int number;
        while (true)
        {
            //Skapar en array "count" som ska hålla integers upp till 10
            //skriver 11 då 0an inkluderas
            int[] count = new int[11];
            //Deklarerar för en int i = 0, ger order att så länge som i är mindre än
            //Längden av element i count så ska i öka med 1. Då ökar den 
            //Tills alla elementen i minnet tar slut
            for (int i = 0; i < count.Length; i++)
            {
                System.Console.WriteLine(i);
            }
            //Kommer att räkna om från 1-10 i en loop om och om igen om jag ej gör en break
            System.Console.WriteLine("Ange ett tal för att få ut multiplikations tabellen: ");
            answer = Console.ReadLine();
            //Y motsvarar vilket tal användaren vill få ut i multiplikationstabellen
            int.TryParse(answer, out y);

            //x används som loop för att loop det y ska gångras med tills
            // den ej går över 10
            for (x = 1; x <= 10; x++)
            {
                //Skriver ut och gångrar 
                Console.Write("{0} X {1} = {2} \n", y, x, y * x);
            }

            System.Console.WriteLine("Enter a number: ");
            answer = Console.ReadLine();
            success = int.TryParse(answer, out number);

            for (int i = 1; i <= number; i++)  // loop igenom numret
            {
                for (int j = 1; j <= i; j++)  // lägger till kolummnerna
                {
                    Console.Write("#");  // 
                }
                Console.WriteLine();  // Fortsätter till nästa rad
            }
            
            Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());  // Read the number of rows from the user

            for (int i = 1; i <= rows; i++)  // Loop through the rows
            {
                for (int j = 1; j <= rows - i; j++)  // Loop through the spaces on the left side
                {
                    Console.Write(" ");  // Print a space
                }
                for (int j = 1; j <= i; j++)  // Loop through the # symbols on the left side
                {
                    Console.Write("#");  // Print a # symbol
                }
                for (int j = 1; j <= i - 1; j++)  // Loop through the # symbols on the right side
                {
                    Console.Write("#");  // Print a # symbol
                }
                for (int j = 1; j <= rows - i; j++)  // Loop through the spaces on the right side
                {
                    Console.Write(" ");  // Print a space
                }
                Console.WriteLine();  // Move to the next line
            } 
            break;
        }
    }
}