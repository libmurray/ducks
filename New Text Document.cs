using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to create a new duck name.");

        while (true)
        {
            Console.ReadLine();
            string duckName = GenerateDuckName();
            Console.WriteLine("The name of your new duck is: " + duckName);
        }
    }
      
    static string GenerateDuckName()
    {
        string[] adjectives = { "Funny", "Quirky", "Cute", "Witty", "Adorable", "Amazing", "Stupid" };
        string[] nouns = { "Quack", "Waddle", "Feather", "Paddle", "Dabble" };

        Random rnd = new Random();
        string adjective = adjectives[rnd.Next(adjectives.Length)];
        string noun = nouns[rnd.Next(nouns.Length)];

        return adjective + " " + noun;
    }
}
