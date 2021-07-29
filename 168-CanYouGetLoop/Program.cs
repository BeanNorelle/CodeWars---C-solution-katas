using System;
using System.Collections.Generic;

namespace _168_CanYouGetLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int getLoopSize(LoopDetector.Node startNode)
        {  
            var nodes = new List<LoopDetector.Node>();
            var current = startNode;
            var next= startNode.next;

            while (next != null)
            {
                nodes.Add(current);
                current = next;
                next = current.next;
                current.next = null;
            }

            return nodes.Count - nodes.IndexOf(current);
        }
    }
}
