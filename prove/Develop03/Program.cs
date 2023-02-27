using System;
using WordSystem;
using ScriptureSystem;

class Program
{
    static void Main(string[] args)
    {

        string input = "";
        Scripture scripture = new Scripture();
        Word word = new Word();
        while (input != "quit")
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