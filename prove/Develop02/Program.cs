using System;

public class Program
{
    public static void Main(string[] args)
    {
        int option = 0;
        Journal journal = new Journal();
        while (option != 5){
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                string journalPrompt = Journal.dailyPrompt;
                Console.WriteLine($"Prompt: {journalPrompt}");
                journal.Write();
            }
            else if (option == 2)
            {
                Entry entry = new Entry();
                entry.DisplayEntries();
            }
            else if (option == 3)
            {
                Console.Write("What file do you want to load? ");
                journal.filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (option == 4)
            {
                Console.Write("What file do you want to save to? ");
                journal.filename = Console.ReadLine();
                journal.SaveFile();
            }
            }
        }
        

    
}