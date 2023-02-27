using System;
using ScriptureSystem;

namespace WordSystem;
public class Word
{
    static Scripture scripture = new Scripture();
    public string[] passage = scripture.ProcessPassage();
    public bool hidden = false;
    public bool IsHidden(int randomNumber)
    {
        if (passage[randomNumber] == "____")
        {
            hidden = true;
        }
        else
        {
            hidden = false;
        }
        return hidden;
    }
    public void WriteHiddenWord(int randomNumber)
    {
        foreach (char letter in passage[randomNumber])
            {
                if (letter != '.' || letter != '!' || letter != '?' || 
                    letter != ',' || letter != ':' || letter != ';')
                {
                    passage[randomNumber] = "____";
                }
                else
                {
                    passage[randomNumber] += letter;
                }
            }
    }
    public void DisplayWords()
    {
        foreach(var item in passage)
            {
                Console.Write(item.ToString() + " ");
            }
    }
}