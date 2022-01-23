using System;
using System.Collections.Generic;

public class DuplicateCharsInString
{

    public void Run()
    {
        string sentence = "this is a sample string";
        Dictionary<char, int> charCount = CountChars(sentence);
        Display(charCount);
    }

    private void Display(Dictionary<char, int> charCount)
    {
        foreach (KeyValuePair<char, int> obj in charCount)
        {
            if (obj.Value > 1)
            {
                Console.WriteLine("Duplicate: " + obj.Key + ", found: " + obj.Value.ToString() + " times");
            }
        }
    }

    private Dictionary<char, int> CountChars(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount.Add(c, 1);
            }
        }
        return charCount;
    }

}