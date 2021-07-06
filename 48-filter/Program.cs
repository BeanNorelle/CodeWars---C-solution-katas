using System;
using System.Collections.Generic;
using System.Linq;

namespace _48_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] birdyies =  {"Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish"};
            foreach(var birdlist in GooseFilter(birdyies)){
                Console.WriteLine(birdlist);
            }
           
        }
                public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            List<string> filterBirds = new List<string>();
          
                   foreach(var bird in birds){
                    if(!geese.Contains(bird)){
                              filterBirds.Add(bird);
                    }                                      
                   }
            return filterBirds;
        }
    }
}
