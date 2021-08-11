using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class LinkedList
    {
        //fields
        private Node first;
        private Node last;
        private int count;

        //constructors
        public LinkedList()
        {
            this.count = 0;
        }

        ~LinkedList() { }

        //properties
        public int Count { get => count; }
        internal Node First { get => first; }
        internal Node Last { get => last; }

        //method

        /// <summary>
        /// Add First with node
        /// </summary>
        /// <param name="node"></param>
        public void AddFirst(Node node)
        {
            if (this.count == 0)
            {
                this.first = node;
                this.last = node;
            }
            else
            {
                node.next = this.first;
                this.first = node;
            }
            this.count++;
        }

        /// <summary>
        /// Add First with value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddFirst(int value)
        {
            Node node = new Node(value);
            AddFirst(node);
            return node;
        }

        /// <summary>
        /// Add Last with node
        /// </summary>
        /// <param name="node"></param>
        public void AddLast(Node node)
        {
            if (this.count == 0)
            {
                this.last = node;
                this.first = node;
            }
            else
            {
                this.last.next = node;
                this.last = node;
            }
            this.count++;
        }

        /// <summary>
        /// Add Last with value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddLast(int value)
        {
            Node node = new Node(value);
            AddLast(node);
            return node;
        }

        /// <summary>
        /// Add After with node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="newNode"></param>
        public void AddAfter(Node node, Node newNode)
        {
            if (HasNode(node))
            {
                newNode.next = node.next;
                node.next = newNode;
                this.count++;

            }
        }

        /// <summary>
        /// Add After with value
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node AddAfter(Node node, int value)
        {
            Node newNode = null;
            
                if (HasNode(node))
                {
                    newNode = new Node(value);
                    AddAfter(node, newNode);
                }
            
            return newNode;
        }

        /// <summary>
        /// Clear
        /// </summary>
        public void Clear()
        {
            this.first = null;
            this.last = null;
            this.count = 0;
        }

        /// <summary>
        /// Remove after
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool RemoveAfter(Node node)
        {
            bool result = false;
            if (HasNode(node) && this.count > 1)
            {
                node.next = node.next.next;
                this.count--;
                if (node.next == null)
                {
                    this.last = node;
                }
                result = true;
            }
            return result;
        }

        /// <summary>
        /// Search with key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node Find(int key)
        {
            Node node = null;
            for (Node i = this.first; i != null; i = i.next)
            {
                if (i.Value == key)
                {
                    node = i;
                    break;
                }
            }
            return node;
        }

        /// <summary>
        /// Find Last with key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node FindLast(int key)
        {
            Node node = null;
            for (Node i = this.first; i != null; i = i.next)
            {
                if (i.Value == key)
                {
                    node = i;
                }
            }
            return node;
        }

        /// <summary>
        /// Bubble Sort
        /// </summary>
        public void BubbleSort()
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                for (Node j = this.first; j.next != null; j = j.next)
                {
                    if (j.Value < j.next.Value)
                    {
                        Swap(ref j, ref j.next);
                    }
                }
            }
        }

        /// <summary>
        /// Swap
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Swap(ref Node node1, ref Node node2)
        {
            int value = node1.Value;
            node1.Value = node2.Value;
            node2.Value = value;
        }

        /// <summary>
        /// Has Node
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool HasNode(Node node)
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                if (i == node)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
