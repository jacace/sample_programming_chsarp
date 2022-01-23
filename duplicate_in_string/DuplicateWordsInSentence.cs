

using System;
using System.Collections.Generic;
using System.Text;

public class DuplicateWordsInSentence
{
    public void Run()
    {

        //separators:{" ", ",", "." (start of end)}
        //case sensitive 
        string sentence = "This is a, sample test of this  test";
        Dictionary<string, int> duplicates = FindDuplicates(sentence);
        DisplayDuplicates(duplicates);
    }

    private void DisplayDuplicates(Dictionary<string, int> duplicates)
    {
        foreach (KeyValuePair<string, int> obj in duplicates)
        {
            if (obj.Value > 1)
            {
                Console.WriteLine("Duplicate word: " + obj.Key + ", found: " + obj.Value.ToString() + " times");
            }
        }
    }

    private Dictionary<string, int> FindDuplicates(string sentence)
    {
        HashSet<char> separators = new HashSet<char>();
        separators.Add(' ');
        separators.Add(',');
        separators.Add('.');

        StringBuilder sb = new StringBuilder();
        string word;
        Dictionary<string, int> duplicates = new Dictionary<string, int>();
        bool needsToBeAdded;

        for (int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];
            if (!separators.Contains(c))
            {
                sb.Append(c);
                needsToBeAdded = false;
            }
            else
            {
                needsToBeAdded = true;
            }

            if (i == sentence.Length - 1)
            {
                needsToBeAdded = true;
            }

            if (needsToBeAdded)
            {
                word = sb.ToString().ToUpper();
                if (duplicates.ContainsKey(word))
                {
                    duplicates[word]++;
                }
                else
                {
                    duplicates.Add(word, 1);
                }
                sb.Clear();
            }
        }

        return duplicates;
    }

}