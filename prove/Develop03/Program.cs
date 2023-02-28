using System;
using WordSystem;
using ScriptureSystem;

class Program
{
    static void Main(string[] args)
    {

        string input = "";
        Word word = new Word();
        Scripture scripture = new Scripture(word);
        word.splitPassage = scripture.passage;

        while (input != "quit" && scripture.hiddenWords != scripture.passage.Length)
        {
            word.DisplayWords();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }
            else
            {
                scripture.HideWords();
            }
        }
    }
}