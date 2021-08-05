using System;
using System.Linq;
using System.Text;

namespace Assginments
{
    class StopWordRemove
    {
        public static string[] RemoveStopWord(string sentence)
        {
            string[] stopWordsArrary = new string[] {

                "a", "about", "actually", "after", "also", "am", "an",
                "and", "any", "are", "as", "at", "be", "because", "but",
                "by", "could", "do", "each", "either", "en", "for", "from",
                "has", "have", "how","i", "if", "in", "is", "it", "its",
                "just", "of", "or", "so", "some", "such", "that","the", "their",
                "these", "thing", "this", "to", "too", "very", "was", "we",
                "well", "what", "when", "where","who", "will", "with", "you", "your",
                "@","#","$","%","&","*","!",",","'","."
            };



            string[] cleanTextArray = sentence.Split(new char[] { ',', ';','.',' ' });

            for(var i=0;i< cleanTextArray.Length;i++)
            {
                for(var j = 0; j < stopWordsArrary.Length; j++)
                {
                    if(cleanTextArray[i]== stopWordsArrary[j])
                    {
                        cleanTextArray[i] = "";
                    }
                }

            }

            return cleanTextArray;
        }
    }
}
