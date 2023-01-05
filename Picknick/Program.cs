internal class Program
{
    private static void Main(string[] args)
    {
        // Att gör choices.ToLower konvertar input till liten bokstav
        // Det gör att det ej blir skifteskänsligt. Dock blir att det all en liten bokstav
        Console.WriteLine("Är det fint väder idag? j/n?");
        string choices = Console.ReadLine();

        if (choices.ToLower() == "j")
        {
            Console.WriteLine("Ska vi gå på picknick?");
        }
        else if (choices.ToLower() == "n")
        {
            Console.WriteLine("Vi stannar inne och läser en bok");
        }
        else if (choices.ToLower()  != "j" || choices.ToLower() != "n")
        {
            Console.WriteLine("JAG FÖRSTÅR INTE!!");
        }
    }
}