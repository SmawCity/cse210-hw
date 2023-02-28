using System;
using ReferenceSystem;
using WordSystem;

namespace ScriptureSystem;
public class Scripture 
{
    private Reference reference = new Reference();
    private Word word;
    private string[] fullVerse = null;
    public string[] passage;
    public int randomNumber = 0;
    public int hiddenWords = 0;

    public Scripture(Word word1)
    {
        word = word1;
        passage = ProcessPassage();
    }
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
        randomNumber = random.Next(passage.Length);
        return randomNumber;
    }
    public void HideWords() 
    {
        int numToHide = 3;    
        if (passage.Length == hiddenWords)
        {
            return;
        }
        else if (passage.Length - 3 <= hiddenWords)
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
                hiddenWords +=1;
            }
            else
            {
                i = i - 1;
            }
        }
    }
    
    
}