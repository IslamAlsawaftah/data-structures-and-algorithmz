using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Challenges.hashmap_repeated_word
{
    public class HashmapRepeated
    {
        public string HashmapRepeatedWord(string text)
        {
            // Get the length
            int n = text.Length;
            if (n == 0)
            {
                return "No text provided";
            }
            Dictionary<string, int> record =
              new Dictionary<string, int>();
            // Collecting words
            char[] delim = { ' ', ',', '.', ':' , '\t' };
            string[] word = text.ToLower().Split(delim);
            // Count frequency of given word
            for (int i = 0; i < word.Length; ++i)
            {
                if (record.ContainsKey(word[i]))
                {
                    // Increase frequency
                    record[word[i]] +=  1;
                }
                else
                {
                    // Add new word
                    record.Add(word[i], 1);
                }
            }
            // Find first repeated word
            for (int i = 0; i < word.Length; ++i)
            {
                if (record[word[i]] > 1)
                {
                    // Display first repeated word
                    return word[i];
                }
            }
            return "No Repetetion";
        }
    }
}