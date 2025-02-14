using System;
using System.Collections.Generic;
using System.Linq;
// made by W00f
class Program
{
    static void Main(string[] args)
    {
    // create objects for refrance and scripture
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
    // game loop 
        while (true)
        {
        // Refresh Screen
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit.");
            var input = Console.ReadLine();
        // Condition to break game loop -- UserQuit
            if (input.ToLower() == "quit")
                break;
        // use scripture to hide 3 words 
            scripture.HideRandomWords(3);
        // if all words hiden break game loop with exit message -- GameQuit  
            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nAll words are hidden. Good job!");
                break;
            }
        }
    }
}