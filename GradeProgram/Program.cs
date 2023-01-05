internal class Program
{
    private static void Main(string[] args)
    {
        // Create an array to hold the float values
        bool success;
        string answer = string.Empty;
        float slutPoang = 0;

        System.Console.WriteLine("Ange dina poäng:");
        System.Console.WriteLine("Format (50 60 70 80 90)");
        answer = Console.ReadLine();

        string[] s = answer.Split(' ');
        // string[] array = new string[answer.Length];
        float[] points = new float[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            points[i] = float.Parse(s[i]);
        }

        foreach (float p in points)
        {
            slutPoang += p ;
        }
        slutPoang /= 5;
        
        if (slutPoang < 50)
        {
            System.Console.WriteLine("Betyg: F");
        }
        else if (slutPoang >= 50 && slutPoang < 60)
        {
            System.Console.WriteLine("Betyg: E");
        }
        else if (slutPoang >= 60 && slutPoang < 70)
        {
            System.Console.WriteLine("Betyg: D");
        }
        else if (slutPoang >= 70 && slutPoang < 80)
        {
            System.Console.WriteLine("Betyg: C");
        }
        else if (slutPoang >= 80 && slutPoang < 90)
        {
            System.Console.WriteLine("Betyg: B");
        }
        else if(slutPoang >= 90 && slutPoang == 100)
        {
            System.Console.WriteLine("Betyg: A");
        }
        System.Console.WriteLine("Ditt slutbetyg: " + slutPoang);
    
            
        
        
    }
}