

class Program
{
    static List<string> inventory = new List<string>();
    static bool gameRunning = true;

    static void Main()
    {
        Console.WriteLine("=== TEXTÄVENTYRET ===");

        while (gameRunning)
        {
            StartScene();
            Console.WriteLine("\nVill du spela igen? (ja/nej)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "ja")
                gameRunning = false;
        }
    }

    static void StartScene()
    {
        Console.WriteLine("\nDu vaknar upp i en mörk skog...");
        Console.WriteLine("Vänster mot floden.");
        Console.WriteLine("Höger mot berget.");
        Console.Write("Vad väljer du? ");

        string choice = Console.ReadLine().ToLower();

        if (choice == "vänster")
            RiverScene();
        else if (choice == "höger")
            MountainScene();
        else
            Death("Du irrade bort dig i skogen.");
    }

    static void RiverScene()
    {
        Console.WriteLine("\nDu når floden och ser en gammal bro.");
        Console.Write("Gå över bron? (ja/nej): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "ja")
        {
            Console.WriteLine("Du hittar en silvernyckel!");
            inventory.Add("Silvernyckel");
            Ending(true);
        }
        else
        {
            Ending(false);
        }
    }

    static void MountainScene()
    {
        Console.WriteLine("\nDu når berget och ser en grotta.");
        Console.Write("Gå in i grottan? (ja/nej): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "ja")
        {
            Console.WriteLine("Väktaren säger: Sök sanningen i floden.");
            RiverScene();
        }
        else
        {
            Death("Stigen försvann bakom dig.");
        }
    }

    static void Ending(bool brave)
    {
        Console.WriteLine("\n--- SLUTET ---");

        if (brave && inventory.Contains("Silvernyckel"))
        {
            Console.WriteLine("Du valde båda vägarna och fann friheten.");
            Console.WriteLine("VINST!");
        }
        else
        {
            Console.WriteLine("Du överlevde, men saknade modet.");
        }
    }

    static void Death(string reason)
    {
        Console.WriteLine("\nDU DOG!");
        Console.WriteLine(reason);
    }
}
