using System;
using System.Collections.Generic;
using System.Text;

namespace TrieImplementation
{
    /// <summary>
    /// Trie is an ordered tree data structure that is used to store a dynamic set or associative array where the keys are usually strings(chars in this case)
    /// http://en.wikipedia.org/wiki/Trie
    /// This is a modified version of the Trie which supports searching for a Substring.
    /// </summary>
    public class Trie
    {
        #region Fields
        
        private Dictionary<char, List<TrieNode>> nodes;
        private bool ignoreCase;
        private List<string> removedWords;
        
        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes the trie with IgnoreCase set to true
        /// </summary>
        public Trie()
            : this(true)
        {
        }
        
        /// <summary>
        /// Initializes the trie and specifies whether the search will be case sensitive
        /// </summary>
        /// <param name="ignoreCase"></param>
        public Trie(bool ignoreCase)
        {
            this.ignoreCase = ignoreCase;
            this.InitializeTrie(ignoreCase);
        }
        
        #endregion
        
        #region Initialization
        
        

        /// <summary>
        /// Initializes the nodes collection and the Root node
        /// </summary>
        /// <param name="ignoreCase"></param>
        protected virtual void InitializeTrie(bool ignoreCase)
        {
            this.nodes = new Dictionary<char, List<TrieNode>>(new CharComparer(ignoreCase));
            this.Root = new TrieNode(TrieNode.EmptyValue, TrieNode.NoParent, false);
            this.removedWords = new List<string>();
        }
        
        #endregion
        
        #region Properties
        /// <summary>
        /// The first Node in the Trie
        /// </summary>
        public TrieNode Root { get; private set; }
        
        /// <summary>
        /// Gets all nodes in the Trie. They are accessed by a Char
        /// </summary>
        public Dictionary<char, List<TrieNode>> Nodes
        {
            get { return this.nodes; }
        }

        public List<string> RemovedWords
        {
            get { return this.removedWords; }
        }

        /// <summary>
        /// Gets the value which indicates whether the the Trie will search with IgnoreCase.
        /// Can be set only in the Constructor during initialization
        /// </summary>
        public bool IgnoreCase
        {
            get
            {
                return this.ignoreCase;
            }
        }
        #endregion
        
        #region Insertion
        
        /// <summary>
        /// Inserts a word in the Trie
        /// </summary>
        /// <param name="word"></param>
        public void Insert(string word)
        {
            this.InsertCore(this.Root, 0, word);
        }
        
        /// <summary>
        /// Inserts all words from a collection
        /// </summary>
        /// <param name="words"></param>
        public void InsertRange(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                this.Insert(word);
            }
        }
        
        /// <summary>
        /// Adds a node to the master collection of all nodes
        /// </summary>
        protected virtual void AddNodeToCollection(char currentChar, TrieNode node)
        {
            if (!this.nodes.ContainsKey(currentChar))
            {
                this.nodes[currentChar] = new List<TrieNode>();
            }
            
            this.nodes[currentChar].Add(node);
        }
        
        /// <summary>
        /// The main method which Inserts a a word in the Trie
        /// </summary>
        private void InsertCore(TrieNode currentNode, int positionInWord, string word)
        {
            if (positionInWord >= word.Length)
            {
                return;
            }
            
            char currentChar = word[positionInWord];
            TrieNode node = null;
            if (!currentNode.Children.ContainsKey(currentChar))
            {
                bool isWord = positionInWord == word.Length - 1 ? true : false;
                node = new TrieNode(currentChar, currentNode, isWord, ignoreCase);
                this.AddNodeToCollection(currentChar, node);
                currentNode.AddChild(node);
            }
            else
            {
                node = currentNode.Children[currentChar];
            }
            
            this.InsertCore(node, ++positionInWord, word);
        }
        
        #endregion
        
        #region Contains
        
        /// <summary>
        /// Checks if a word is inside the Trie
        /// </summary>
        /// <param name="word">Word to check</param>
        /// <returns>Whether the word was found</returns>
        public bool Contains(string word)
        {
            return this.ContainsCore(this.Root, 0, word);
        }
        
        /// <summary>
        /// The main method which checks whether a word is contained inside the Trie
        /// </summary>
        /// <param name="currentNode"></param>
        /// <param name="currentPositionInWord"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        protected virtual bool ContainsCore(TrieNode currentNode, int currentPositionInWord, string word)
        {
            if (currentPositionInWord >= word.Length)
            {
                return true;
            }
            
            char currentChar = word[currentPositionInWord];
            bool containsKey = currentNode.Children.ContainsKey(currentChar);
            if (containsKey)
            {
                return this.ContainsCore(currentNode.Children[currentChar], ++currentPositionInWord, word);
            }
            
            return false;
        }
        
        #endregion
        
        #region Search
        
        /// <summary>
        /// Searches for word inside the Trie with a StartsWith SearchType
        /// </summary>
        /// <returns>All found words starting with Word</returns>
        public ICollection<string> Search(string word)
        {
            return this.Search(word, SearchType.StartsWith);
        }
        
        /// <summary>
        /// Searches for word inside the Trie with the specified SearchType
        /// </summary>
        /// <param name="word"></param>
        /// <param name="searchType"></param>
        /// <returns>All words meeting the criteria</returns>
        public ICollection<string> Search(string word, SearchType searchType)
        {
            if (word == null)
            {
                throw new ArgumentException("The word must not be null");
            }
            else if (word == string.Empty)
            {
                return this.FindAllWords();
            }

            ICollection<string> results = new HashList<string>(500, StringComparer.InvariantCultureIgnoreCase);
            if (searchType == SearchType.StartsWith)
            {
                this.PrefixSearchCore(this.Root, 0, new StringBuilder(word), results);
            }
            else if (searchType == SearchType.Contains)
            {
                this.SubstringSearchCore(word, results);
            }

            foreach (string removedWord in this.removedWords)
            {
                results.Remove(removedWord);
            }

            return results;
        }

        /// <summary>
        /// Finds all words currently in the Trie
        /// </summary>
        /// <returns></returns>
        public ICollection<string> FindAllWords()
        {
            List<string> words = new List<string>();
            this.DfsForAllWords(this.Root, new StringBuilder(string.Empty), words);
            return words;
        }
        
        /// <summary>
        /// The main method which Searches for substring inside the Trie
        /// </summary>
        /// <param name="word">Word to search</param>
        /// <param name="results"></param>
        private void SubstringSearchCore(string word, ICollection<string> results)
        {
            int currentPositionInWord = 0;
            if (this.nodes.ContainsKey(word[currentPositionInWord]))
            {
                List<TrieNode> startNodes = this.nodes[word[currentPositionInWord++]];
                
                for (int i = 0; i < startNodes.Count; i++)
                {
                    TrieNode currentStartNode = startNodes[i];
                    bool contains = false;
                    while (currentPositionInWord < word.Length)
                    {
                        if (currentStartNode.Children.ContainsKey(word[currentPositionInWord]))
                        {
                            currentStartNode = currentStartNode.Children[word[currentPositionInWord]];
                            contains = true;
                        }
                        else
                        {
                            contains = false;
                            break;
                        }
                    
                        currentPositionInWord++;
                    }
                
                    if (contains || word.Length == 1)
                    {
                        this.BuildResultsFromSubstring(currentStartNode, results);
                    }
                
                    currentPositionInWord = 1;
                }
            }
        }
        
        /// <summary>
        /// Builds the resulted words from a one word. Searches for all descendants which match that word.
        /// The word is being built by the node itself. As it iterates its parents until the end of a word or the root are met.
        /// </summary>
        /// <param name="nodeValue">The node to build results from</param>
        /// <param name="results">Output</param>
        private void BuildResultsFromSubstring(TrieNode nodeValue, ICollection<string> results)
        {
            string builtWord = nodeValue.BuildUpToWord();
            if (nodeValue.Children.Count == 0)
            {
                //if we at the bottom of the tree just add this word as no descendants will be found
                results.Add(builtWord);
            }
            else
            {
                //Using a DepthFirstApproach (http://en.wikipedia.org/wiki/Depth-first_search) finds all descendants of the current node and adds their
                //values to the results.
                this.DfsForAllWords(nodeValue, new StringBuilder(builtWord), results);
            }
        }
        
        /// <summary>
        /// Searches the Trie for words with a StartsWith SearchType. Uses recursion - http://en.wikipedia.org/wiki/Recursion
        /// </summary>
        private void PrefixSearchCore(TrieNode currentNode, int currentPositionInWord, StringBuilder word, ICollection<string> results)
        {
            if (currentPositionInWord >= word.Length)
            {
                this.DfsForAllWords(currentNode, word, results);
                return;
            }
            
            char currentChar = word[currentPositionInWord];
            
            bool containsKey = currentNode.Children.ContainsKey(currentChar);
            if (containsKey)
            {
                if (currentPositionInWord == word.Length - 1)
                {
                    results.Add(word.ToString());
                }
                
                TrieNode child = currentNode.Children[currentChar];
                this.PrefixSearchCore(child, ++currentPositionInWord, word, results);
            }
        }
        
        /// <summary>
        /// Using a DepthFirstApproach (http://en.wikipedia.org/wiki/Depth-first_search) finds all descendants of the current node and adds their
        /// values to the results.
        /// </summary>
        protected virtual void DfsForAllWords(TrieNode currentNode, StringBuilder word, ICollection<string> results)
        {
            TrieNode[] nodesArray = new TrieNode[currentNode.Children.Count];
            currentNode.Children.Values.CopyTo(nodesArray, 0);
            foreach (TrieNode node in nodesArray)
            {
                word.Append(node.Value);
                if (node.IsWord)
                {
                    results.Add(word.ToString());
                }
                
                this.DfsForAllWords(node, word, results);
                word.Length--;
            }
        }

        
        #endregion
    }
}