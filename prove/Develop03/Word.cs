using System;
using ScriptureSystem;

namespace WordSystem;
public class Word
{    
    public bool hidden = false;
    public string[] splitPassage;
    
    public bool IsHidden(int word)
    {
        if (splitPassage[word] == "____")
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
        foreach (char letter in splitPassage[randomNumber])
            {
                if (letter != '.' || letter != '!' || letter != '?' || 
                    letter != ',' || letter != ':' || letter != ';')
                {
                    splitPassage[randomNumber] = "____";
                }
                else
                {
                    splitPassage[randomNumber] += letter;
                }
            }
    }
    public void DisplayWords()
    {
        foreach(var item in splitPassage)
            {
                Console.Write(item.ToString() + " ");
            }
    }
}