using System;

namespace _119_SprayingTree
{
    class Program
    {
        static void Main(string[] args)
        {   
            string w = "Monday";
            int n = 10;
            int c = 2;
            Console.WriteLine(Task(w,n,c));
        }
         public static string Task(string w, int n, int c)
        {
            switch(w)
            {
            case "Monday":    return "It is "+w+" today, James, you have to work, you must spray "+n+" trees and you need "+(n*c)+" dollars to buy liquid";
            case "Tuesday":   return "It is "+w+" today, John, you have to work, you must spray "+n+" trees and you need "+(n*c)+" dollars to buy liquid";
            case "Wednesday": return "It is "+w+" today, Robert, you have to work, you must spray "+n+" trees and you need "+(n*c)+" dollars to buy liquid";
            case "Thursday":  return "It is "+w+" today, Micheal, you have to work, you must spray "+n+" trees and you need "+(n*c)+" dollars to buy liquid";
            case "Friday":    return "It is "+w+" today, William, you have to work, you must spray "+n+" trees and you need "+(n*c)+" dollars to buy liquid";        
            }
            
            
            return "Invalid day";
        }
    }
}
