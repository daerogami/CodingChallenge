using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.PirateSpeak
{
    // This class was copied from http://www.dotnetperls.com/alphabetize-string
    public static class StringTools
    {
        /// <summary>
        /// Alphabetize the characters in the string.
        /// </summary>
        public static string Alphabetize(string s)
        {
            // 1.
            // Convert to char array.
            char[] a = s.ToCharArray();

            // 2.
            // Sort letters.
            Array.Sort(a);

            // 3.
            // Return modified string.
            return new string(a);
        }
    }
}
