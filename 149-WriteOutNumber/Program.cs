using System;
using System.Collections.Generic;

namespace _149_WriteOutNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] names = {"Ara","Jay","Mike","Ara"};
           foreach(var name in names)
           {
               HandOutGift(name);
           }
        }

       static List<string> NamesList = new List<string>();
       public static void HandOutGift(string name)
        {
            if(!NamesList.Contains(name))
            {
            NamesList.Add(name);
            }
            else
            {
                throw new ArgumentException();
            }
            
        }
    }
}
