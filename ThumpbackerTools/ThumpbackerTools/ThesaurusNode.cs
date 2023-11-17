using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code created by Anthony Cicinell
namespace ThumpbackerTools.Collections
{
    /// <summary>
    /// This is the Node class for the Thesaurus
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Value"></typeparam>
    public class ThesaurusNode<Key, Value>
    {
        public Key key;
        public List<Value> values;

        /// <summary>
        /// Non-Default Constructor
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public ThesaurusNode(Key key, Value value)
        {
            //Create the key
            this.key = key;
            //Create a new value list
            values = new List<Value>();
            //Add the value to the list
            values.Add(value);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ThesaurusNode()
        {

        }
    }
}
