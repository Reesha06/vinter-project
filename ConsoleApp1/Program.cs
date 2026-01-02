
class program
{
    static void Main()
    {
        Console.WriteLine("=== TEXTÄVENTYRET ===");
        Console.WriteLine("\nDu vaknar upp i en mörk skog.");
        Console.WriteLine("Vänster mot floden.");
        Console.WriteLine("Höger mot berget.");
        Console.Write("Vad väljer du?");
        string choice = Console.ReadLine().ToLower();
        if (choice == "vänster")
            River();         
        else if (choice == "höger")
            Mountain();
        else
         Console.WriteLine("Du irrade bort dig i skogen.");

    }
    
    static void River()
    {

        Console.WriteLine("\nDu når floden och ser en gammal bro.");
        Console.Write("vill du gå över bron? (ja/nej) ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "ja")
        {
            Console.WriteLine("Du hittar en silvernyckel!");
        }
        else
        {
            
        }

    }
    




}