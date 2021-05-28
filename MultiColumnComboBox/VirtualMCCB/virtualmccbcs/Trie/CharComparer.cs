using System.Collections.Generic;

namespace TrieImplementation
{
    /// <summary>
    /// Used to compare the names of the TrieNodes.
    /// </summary>
    internal class CharComparer : IEqualityComparer<char>
    {
        private bool ignoreCase;

        /// <summary>
        /// Initializes the comparer
        /// </summary>
        /// <param name="ignoreCase">Sets the value indicating whether the comparisons will 
        /// ignore the casing</param>
        public CharComparer(bool ignoreCase)
        {
            this.ignoreCase = ignoreCase;
        }

        /// <summary>
        /// Compares the names of two TrieNodes. Can be Case sensitive/insensitive
        /// </summary>
        public bool Equals(char x, char y)
        {
            if (this.ignoreCase)
            {
                return char.ToLower(x) == char.ToLower(y);
            }

            return x == y;
        }

        public int GetHashCode(char obj)
        {
            return base.GetHashCode();
        }
    }
}