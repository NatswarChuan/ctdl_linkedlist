using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("AddFirst");
            list.AddFirst(0);
            Output(list);

            Console.WriteLine("AddLast");
            list.AddLast(1);
            Output(list);

            Console.WriteLine("AddAfter First with value");
            Node node = list.AddAfter(list.First,2);
            Output(list);

            Console.WriteLine("AddAfter First with node");
            list.AddAfter(node, new Node(3));
            Output(list);

            Console.WriteLine($"RemoveAfter: {list.RemoveAfter(node)}");
            Output(list);

            Console.WriteLine($"Find: {list.Find(1).Value}");
            Output(list);

            Console.WriteLine($"FindLast: {list.FindLast(1).Value}");
            Output(list);

            Console.WriteLine("Bubble Sort");
            list.BubbleSort();
            Output(list);

            Console.WriteLine("Clear");
            list.Clear();
            Output(list);
        }

        static void Output(LinkedList list)
        {
            for (Node i = list.First; i != null; i=i.next)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine($"Count: {list.Count}");
        }
    }
}
