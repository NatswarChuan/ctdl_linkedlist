using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class Node
    {
        //fields
        private int value;
        public Node next;

        //constructors
        public Node(int value)
        {
            this.Value = value;
        }

        ~Node() { }

        //properties
        public int Value { get => value; set => this.value = value; }

    }
}
