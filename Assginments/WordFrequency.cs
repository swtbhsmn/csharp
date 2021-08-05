using System;
namespace Assginments
{
    class WordFrequency
    {
        public static int CountWordRepetition(string sentence, string word)
        {
            int count = 0;
            int i = 0;


            while ((i = sentence.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }
            return count;
        }
    }
}
