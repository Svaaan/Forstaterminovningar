internal class Program
{
    //Adressboken ska styras via menyn
    //Det ska gå att lägga till namn i addressboken
    //Det ska gå att rensa adressboken 'tills' att den blir tom
    //Det ska gå att avsluta program via att trycka Q
    private static void Main(string[] args)
    {
        int adressMenu = 0;
        bool succes;
        Contacts adressBok = new();
        while (true)
        {
            System.Console.WriteLine("Min Adressbok");
            System.Console.WriteLine("[1] Mina kontakter");
            System.Console.WriteLine("[2] Lägg till kontakter");
            System.Console.WriteLine("[3] Ta bort kontakter");
            System.Console.WriteLine("[4] Avsluta program");
            bool isNumber = int.TryParse(Console.ReadLine(), out adressMenu);
            if (!isNumber)
            {
                System.Console.WriteLine("Only number input is valid");
            }
            switch (adressMenu)
            {
                case 1:
                System.Console.WriteLine("Mina kontakter ");
                adressBok.ShowContacts();
                    break;
                case 2:
                System.Console.WriteLine("Lägg till kontakt");
                System.Console.WriteLine("Namn: ");
                string namn = Console.ReadLine();
                System.Console.WriteLine("Efternamn: ");
                string efternamn = Console.ReadLine();
                System.Console.WriteLine("Telefonnummer: ");
                string telefonnumer = Console.ReadLine();
                System.Console.WriteLine("Adress: ");
                string gatuAdress= Console.ReadLine();
                System.Console.WriteLine("Hus nummer: ");
                int husNummer = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Post nummer");
                int postNummer = int.Parse(Console.ReadLine());
                Contacts newContact = new Contacts(namn, efternamn, gatuAdress, husNummer, postNummer, telefonnumer);
                adressBok.AddOneContact(newContact);
                    break;
                case 3:
                System.Console.WriteLine("Ange id på kontakt du vill radera: ");
                int id = int.Parse(Console.ReadLine());
                adressBok.removeContact(id);
                    break;
                case 4:
                Environment.Exit(0);
                    break;
            }
        }
    }
}