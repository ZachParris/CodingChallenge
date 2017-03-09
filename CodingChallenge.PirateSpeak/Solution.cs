using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    public class Solution
    {
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<string> word_match = new List<string>();

            foreach(string p_word in dictionary)
            {
                List<char> new_jumble = jumble.ToList();

                foreach(char letter in p_word)
                {
                    if (new_jumble.Contains(letter))
                    {
                        new_jumble.Remove(letter);
                    }

                    if (new_jumble.Count == 0)
                    {
                        word_match.Add(p_word);
                    }
                }
            }
            return word_match.ToArray();
        }
    }
}