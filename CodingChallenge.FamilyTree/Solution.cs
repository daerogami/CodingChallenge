using System;
using System.Diagnostics;

namespace CodingChallenge.FamilyTree
{
    /// <summary>
    /// The class contains the methods for solving the challenge
    /// External resources used:
    ///     Finding long month name - http://stackoverflow.com/questions/3184121/get-month-name-from-month-number
    ///     DFS Algorithm - https://en.wikipedia.org/wiki/Tree_traversal
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// This method initates a recursive Depth-First-Search
        /// </summary>
        /// <param name="person">Person node</param>
        /// <param name="descendantName">Requested person</param>
        /// <returns>Person's Birthday property as string. If null, returns Null string object.</returns>
        public string GetBirthMonth(Person person, string descendantName)
        {
            try
            {
                System.Globalization.DateTimeFormatInfo mfi = new System.Globalization.DateTimeFormatInfo();
                // Find person using recursive function
                return mfi.GetMonthName(GetDescendant(person, descendantName).Birthday.Month).ToString();
            }
            // If person is not in list of descendants, GetDescendant will return the empty string
            catch (NullReferenceException e)
            {
                Trace.Write("\n\n" + e.Message + "\n" + e.StackTrace + "\n\n");
                return "";
            }
        }

        /// <summary>
        /// This function is a pre-order, DFS recursive traversal function
        /// </summary>
        /// <param name="person">Current person node</param>
        /// <param name="descendantName">Requested person</param>
        /// <returns>requested descendant</returns>
        public Person GetDescendant(Person person, string descendantName)
        {
            // Always inspect person before calling recursion (this is true when we're on the requested person)
            if (person.Name == descendantName) return person;
            // Cycle thru descendants
            foreach (Person p in person.Descendants) {
                // Call recursion and capture return value
                Person temp = GetDescendant(p, descendantName);
                // Inspect return value (this is true when we have found the requested person and are propagating them up)
                if (temp != null && temp.Name == descendantName) return temp;
            }
            // This will be reached once we reach the end of a branch w/o finding our person on that branch
            // This return value will be skipped over in the above foreach loop, thus allowing our requested person to propagate to the intial call
            return null;
        }
    }
}