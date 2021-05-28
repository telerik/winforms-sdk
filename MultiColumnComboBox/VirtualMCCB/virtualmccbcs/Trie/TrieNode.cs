using System.Collections.Generic;
using System.Text;

namespace TrieImplementation
{
    public class TrieNode
    {
        private bool ignoreCase;
        #region Constants
        
        public const TrieNode NoParent = null;
        public const char EmptyValue = ' ';
        
        #endregion
        
        #region Constructors
        /// <summary>
        /// Initializes the TrieNode with default values. This constructor must be called, but must not
        /// be public since there are properties and fields that need to be initialized by the User/Trie
        /// </summary>
        protected TrieNode(bool ignoreCase)
        {
            this.ignoreCase = ignoreCase;
            this.InitializeNode();
        }
        
        /// <summary>
        /// Initializes the TrieNode
        /// </summary>
        /// <param name="value">What will be the value of this node. Must be a char from a word or sentence</param>
        /// <param name="parent">The parent node. If parent equals null - this is the Root</param>
        /// <param name="isWord">Defines whether this node marks the ending of a word</param>
        /// <param name="ignoreCase">Optional, Defines whether searching in this node's children will be case sensitive</param>
        public TrieNode(char value, TrieNode parent, bool isWord, bool ignoreCase = true)
            : this(ignoreCase)
        {
            this.Value = value;
            this.ParentNode = parent;
            this.IsWord = isWord;
        }
        
        #endregion
        
        #region Initialization
        /// <summary>
        /// Initializes the main properties
        /// </summary>
        protected virtual void InitializeNode()
        {
            this.Children = new Dictionary<char, TrieNode>(new CharComparer(this.ignoreCase));
        }
        
        #endregion
        
        #region Properties
        /// <summary>
        /// Gets the Value of the node
        /// </summary>
        public char Value { get; protected set; }
        
        /// <summary>
        /// Gets the value which tells whether the node marks the ending of a word.
        /// </summary>
        public bool IsWord { get; private set; }
        
        /// <summary>
        /// Gets the parent. If the parent is null then this is the root
        /// </summary>
        public TrieNode ParentNode { get; protected set; }
        
        /// <summary>
        /// Gets the amount of direct children this node has.
        /// </summary>
        public int ChildrenCount
        {
            get { return this.Children.Keys.Count; }
        }
        
        /// <summary>
        /// Gets the direct children of this node
        /// </summary>
        public Dictionary<char, TrieNode> Children { get; private set; }
        
        #endregion
        
        #region PublicMethods
        
        /// <summary>
        /// Adds a node to the children collection of this node
        /// </summary>
        /// <param name="node"></param>
        public void AddChild(TrieNode node)
        {
            if (!this.Children.ContainsKey(node.Value))
            {
                this.Children.Add(node.Value, node);
            }
        }

        /// <summary>
        /// Builds the word from this node-up. If this node is a part of the word "Nature" and
        /// its value equals 'e' then the returned string will "Nature"
        /// </summary>
        /// <returns></returns>
        public string BuildUpToWord()
        {
            StringBuilder sb = new StringBuilder();
            TrieNode currentNode = this;
            while (currentNode != null || (currentNode != null && currentNode.IsWord))
            {
                if (currentNode.ParentNode != null)
                {
                    sb.Insert(0, currentNode.Value);
                    currentNode = currentNode.ParentNode;
                }
                else
                {
                    break;
                }
                
            }

            return sb.ToString();
        }
    
        #endregion
    }
}