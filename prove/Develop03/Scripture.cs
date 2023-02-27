using System;
using ReferenceSystem;
using WordSystem;

namespace ScriptureSystem;
public class Scripture 
{
    static Reference reference = new Reference();
    static Word word = new Word();
    private string[] fullVerse = null;
    public int randomNumber = 0;
    private int hiddenWords = 0;

    public string[] ProcessPassage()
    {
        string fullPassage = "";
        if (reference.verseReference2 != null)
        {
            fullPassage = (reference.verseReference + "; " + reference.verseReference2);
        }
        else
        {
            fullPassage = reference.verseReference;
        }
        fullVerse = fullPassage.Split(" ");
        return fullVerse;
    }
    public int GetRandomWord()
    {
        Random random = new Random();
        randomNumber = random.Next(word.passage.Length);
        return randomNumber;
    }
    public void HideWords() 
    {
        int numToHide = 3;    
        if (word.passage.Length == hiddenWords)
        {
            return;
        }
        else if (word.passage.Length - 3 <= hiddenWords)
        {
            numToHide = fullVerse.Length - hiddenWords;
        }
            
        for (int i = 0; i < numToHide; i++)
        {
            randomNumber = GetRandomWord();
            word.hidden = word.IsHidden(randomNumber);
            if (word.hidden == false)
            {
                word.WriteHiddenWord(randomNumber);
            }
            else
            {
                hiddenWords += 1;
            }
        }
    }
    
    
}