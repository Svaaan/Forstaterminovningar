internal class Program
{


    private static void Main(string[] args)
    {
        int tal = 0;
        int tal2 = 0;
        int sum = 0;
        int[] count = new int[11];
        int rows = 3;
        int columns = 5;
        bool success;
        string answer = string.Empty;

        for (int i = 0; i < count.Length; i++)
        {
            System.Console.WriteLine(i);
            Thread.Sleep(300);
        }
        //ger värdet j 40 och att den måste vara högre eller like med 30
        // j-- är att värdet ska minskas varje gång det loopas
        for (int j = 40; j >= 30; j--)
        {
            System.Console.WriteLine(j);
            Thread.Sleep(250);
        }
        System.Console.WriteLine("Nu har jag kalibrerat färdigt!");
        do
        {

            System.Console.WriteLine("Tal 1:");
            answer = Console.ReadLine();
            success = int.TryParse(answer, out tal);
        }
        while (!success);
        do
        {
            System.Console.WriteLine("Tal 2:");
            answer = Console.ReadLine();
            success = int.TryParse(answer, out tal2);

        } while (!success);

        for (int i = tal; i <= tal2; i++)
        {
            sum += i;
        }
        System.Console.WriteLine(sum);









        // int i representerar x axeln för tabellen
        for (int i = 0; i < rows; i++)
        {   //int j representerar y axeln i tabellen
            for (int j = 0; j < columns; j++)
            {   //Skriver ut symbolen som visar y och x beroende på x och y val.
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}