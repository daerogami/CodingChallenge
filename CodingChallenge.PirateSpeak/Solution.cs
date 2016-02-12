using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.PirateSpeak
{
    /// <summary>
    /// The class contains the methods for solving the challenge
    /// External resources used:
    ///     Alphabetizing Strings: http://www.dotnetperls.com/alphabetize-string
    /// </summary>
    /// <remarks>
    /// I feel like my implementation is more of an exploitation of the problem space than a solution.
    /// Ideally, a "proper" solution would use a more efficient technique such as string masking or regex
    /// </remarks>
    public class Solution
    {
        /// <summary>
        /// This method finds dictionary entries that match jumble
        /// </summary>
        /// <param name="jumble">string of characters to match</param>
        /// <param name="dictionary">list of words for jumble to test against</param>
        /// <returns></returns>
        public string[] GetPossibleWords(string jumble, string[] dictionary)
        {
            List<string> matches = new List<string>();
            foreach(string s in dictionary)
            {
                if(StringTools.Alphabetize(jumble)== StringTools.Alphabetize(s))
                {
                    matches.Add(s);
                }
            }
            return matches.ToArray();
        }
    }
}