using System;
using System.Collections.Generic;
using System.Linq;
namespace _165_DirectionReductions
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] a = new string[] {"NORTH", "WEST", "SOUTH", "EAST"};
            Console.WriteLine(string.Join(" ",dirReduc(a)));
        }

        public static string[] dirReduc(String[] arr) 
        {
            Stack<string> entryLog = new Stack<string>();
           
            foreach(var direction in arr)
            {   
                if(IsReverseDirection(entryLog,direction)) entryLog.Pop();
                else entryLog.Push(direction);
            }
            return entryLog.Reverse().ToArray();
        }

        public static bool IsReverseDirection(Stack <string> entryLog,string direction)
        {   
             string AtLastStack = string.Empty;
             AtLastStack = entryLog.Count>0 ? entryLog.Peek() : string.Empty;

             switch(direction)
                {
                   case "NORTH" : return (AtLastStack == "SOUTH") ? true : false;  
                   case "SOUTH" : return (AtLastStack == "NORTH") ? true : false; 
                   case "EAST"  : return (AtLastStack == "WEST" ) ? true : false;
                   case "WEST"  : return (AtLastStack == "EAST" ) ? true : false; 
                }
                return false;
        }
    }
}
