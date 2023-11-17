using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code created by Anthony Cicinelli
namespace ThumpbackerTools.Collections
{
    public class Thesaurus<Key, Value>
    {
        private List<ThesaurusNode<Key, Value>> nodes;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Thesaurus()
        {
            nodes = new List<ThesaurusNode<Key, Value>>();
        }

        /// <summary>
        /// Adds a new thesarus value
        /// If a key already exist it adds the value to the key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(Key key, Value value)
        {
            //Search the nodes
            foreach (var node in nodes)
            {
                //If a key is found
                //Add it to the node then return
                if(node.key.Equals(key))
                {
                    node.values.Add(value);
                    return;
                }
            }

            //Add a new node
            nodes.Add(new ThesaurusNode<Key, Value>(key, value));
        }

        /// <summary>
        /// Removes a key and all its values
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RemoveKey(Key key)
        {
            //Search for a key
            foreach (var node in nodes)
            {
                //If a key is found remove it and return true
                if(node.key.Equals(key))
                {
                    return nodes.Remove(node);
                }
            }
            //No key is found
            return false;
        }

        /// <summary>
        /// Clears the Thesaurus
        /// </summary>
        public void Clear()
        {
            nodes.Clear();
        }

        /// <summary>
        /// Removes a value in a specified key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool RemoveValueInKey(Key key, Value value)
        {
            //Search the nodes
            foreach (var node in nodes)
            {
                //If a node is found then remove the value
                if(node.key.Equals(key))
                {
                    return node.values.Remove(value);
                }
            }

            return false;
        }

        /// <summary>
        /// Get a key based on a value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Key GetKeyBasedOnValue(Value value)
        {
            //Search the nodes
            foreach (var node in nodes)
            {
                //Search the values in the node
                foreach (var val in node.values)
                {
                    //If value is found within the node return the key
                    if(val.Equals(value))
                    {
                        return node.key;
                    }
                }
            }

            //Throw an exception if it isn't found
            throw new Exception("Value was not associated with any key");
        }

        /// <summary>
        /// Checks if a key and value exists
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(Key key, Value value)
        {
            //Search the node for the keys
            foreach (var node in nodes)
            {
                //If a key is found then find value
                if(node.key.Equals(key))
                {
                    //Search values
                    foreach (var nodeVal in node.values)
                    {
                        //If value is found then return true
                        if(nodeVal.Equals(value))
                        {
                            return true;
                        }
                    }
                }
            }

            //Return false if not found
            return false;
        }
    }
}
