using ConsoleApp.Challenges.hashtable;
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
            Hashtable record = new Hashtable(1024); 

            // Collecting words
            char[] delimiterChars = { ' ', ',', '.', ':' , '\t' };
            string[] str = text.ToLower().Split(delimiterChars);
            // frequency of given word

            for (int i = 0; i < str.Length; i++)
            {
                if (record.Get(str[i]) == null)
                {
                    record.Set(str[i], "1");
                }
                else
                    return str[i];
            }
            return "No Repetetion";
        }
    }
}