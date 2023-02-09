using System.IO;

public class Journal
{
    public string filename = "journal.txt";
    public static string dailyPrompt = PromptGenerator();
    public string fullEntry = "didn't work";
    public static string PromptGenerator()
    {
        Random random = new Random();
        int randomNumber = random.Next(1,6);
        string Prompt1 = "Who was the most interesting person I interacted with today?";
        string Prompt2 = "What was the best part of my day?";
        string Prompt3 = "How did I see the hand of the Lord in my life today?";
        string Prompt4 = "What was the strongest emotion I felt today?";
        string Prompt5 = "How did you serve somebody else today?";
        string Prompt6 = "If I had one thing I could do over today, what would it be?";
        string Prompt7 = "What did you do for fun today?";
        string prompt = "";
        
        if (randomNumber == 1)
        {
            prompt = Prompt1;
        }
        else if (randomNumber == 2)
        {
            prompt = Prompt2;
        }
        else if (randomNumber == 3)
        {
            prompt = Prompt3;
        }
        else if (randomNumber == 4)
        {
            prompt = Prompt4;
        }
        else if (randomNumber == 5)
        {
            prompt = Prompt5;
        }
        else if (randomNumber == 6)
        {
            prompt = Prompt6;
        }
        else if (randomNumber == 7)
        {
            prompt = Prompt7;
        }

        return prompt;
    }
    public void Write(){
        string journalEntry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        this.fullEntry = ($"Prompt: {dailyPrompt}\n{journalEntry} ({dateText})");
    }
    public void LoadFile() {
        Console.Write("What file would you like to load? ");
        filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
        }
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(fullEntry);
        }
    }
}