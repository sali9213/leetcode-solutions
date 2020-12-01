using System;
namespace LeetCode
{
    public class LongestSentence
    {
        public LongestSentence()
        {
        }

        /// <summary>
        /// Get the longest sentence that occurs in the given text
        /// </summary>
        /// <param name="text"></param>
        /// <returns>The longest sentence</returns>
        public string getLongestSentence(string text)
        {
            // The number of non-space characters in current sentence
            int currCharCount = 0;

            // First character of longest sentence
            int longestSentenceStartIndex = 0;
            // Last character of longest sentence
            int longestSentenceEndIndex = 0;

            // First character of current sentence
            int currSentenceStartIndex = 0;

            // Character count of longest sentence
            int longestCharCount = -1;

            // Iterate through text
            for (int i = 0; i < text.Length; i++)
            {
                // if currCharCount = 0, then we are iterating through a new sentence.
                // So set currSentenceStartIndex
                if (currCharCount == 0)
                {
                    currSentenceStartIndex = i;
                }

                // If current character is .,? or ! this is the end of current sentence
                if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                {
                    // If current sentence is longer than longest sentence, update relevant variables
                    if (currCharCount > longestCharCount)
                    {
                        longestCharCount = currCharCount;
                        longestSentenceStartIndex = currSentenceStartIndex;
                        longestSentenceEndIndex = i;
                    }

                    // reset currCharCount for new sentence
                    currCharCount = 0;
                }
                // Do not count white spaces
                else if (text[i] != ' ')
                {
                    currCharCount++;
                }
            }

            // Calculate sentence length for substring method
            int longestSentenceLength = longestSentenceEndIndex - longestSentenceStartIndex + 1;
            // Return longest sentence
            return text.Substring(longestSentenceStartIndex, longestSentenceLength);
        }
    }
}
