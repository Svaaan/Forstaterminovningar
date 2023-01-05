internal class Program
{
    private static void Main(string[] args)
    {
        //skriv in antalet kwh förbrukat
        //Skriv in prisområde (luleå: 111,33 öre/kWh, sundsvall 111,33 öre/kWh
        //malmö 305,76 öre/kWh, stockholm 305,76 öre/kWh)
        //skriv in: Kund nummer
        //Skriv ut: användarens kundnummer, total pris, eventuell ransoneringsavgift
        //Ransoneringerins avgift om användning på kWh har överstigit 10 000 
        //Ransoneringsavgiften är all kwh över 10 000 kWh 
        //Kostnaden ökar med 25% för 5000 kWh över 10000 kWh
        //Allt över 15kWh debiteras 50% extra

        float kWhSthlm = 305.76f;
        float kWhMalmo = 305.76f;
        float kWhLulea = 111.33f;
        float kWhSundsvall = 111.33f;
        float kWh = 0;
        string answer = string.Empty;
        int kundnummer = 0;
        float totalPris = 0;
        float ransoneringAvgiftShlm = 1.25f;
        float ransoneringAvgiftShlm2 = 1.50f;
        int num = 6250;
        float ransoneringskWh = 0;
        bool success;



        do
        {
            System.Console.WriteLine("Kwh förbrukade: ");

            success = float.TryParse(Console.ReadLine(), out kWh);

            totalPris = kWh * kWhSthlm;

            if (kWh <= 10000)
            {
                totalPris = kWh * kWhSthlm;
                totalPris /= 100;
            }
            else if (kWh > 10000 && kWh <= 15000)
            {
                ransoneringskWh = (kWh - 10000) * ransoneringAvgiftShlm * kWhSthlm;
                totalPris = +10000 * kWhSthlm + ransoneringskWh;
                totalPris /= 100;

            }
            else if (kWh > 15000)
            {

                ransoneringskWh = kWh - 15000; // 5000
                float test = ransoneringskWh * (ransoneringAvgiftShlm2 * kWhSthlm); //7500
                totalPris = (10000 * kWhSthlm) + (5000 * ransoneringAvgiftShlm * kWhSthlm) + test;
                

                totalPris /= 100;
            }

        } while (!success);

        do
        {
            System.Console.WriteLine("Skriv in ditt prisområde: [1] Stockholm ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                System.Console.WriteLine("Valt område: Stocholm");
                System.Console.WriteLine("kWh pris för område: " + kWhSthlm);
            }
        } while (answer != "1");

        do
        {
            Console.Write("Ange kundnummer(5 siffor): ");
            string inputString = Console.ReadLine();
            success = Int32.TryParse(inputString, out kundnummer);
            if (success)
            {
                if (inputString.Length > 5)
                {
                    success = false;
                    Console.WriteLine("Input must be 5 characters or fewer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        } while (!success);

        do
        {
            System.Console.WriteLine("Uppgifter för kund: " + kundnummer);
            System.Console.WriteLine("Prisområde: Stockholm");
            System.Console.WriteLine("Pris för prisområde stockholm: " + kWhSthlm);
            System.Console.WriteLine("");
            System.Console.WriteLine("Ditt totala pris: " + totalPris / 10 + " kr");

            System.Console.WriteLine("Tryck på q för att avsluta");
            answer = Console.ReadLine();

        } while (answer != "q");
    }
}