using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
namespace _49_linqpract01
{
    class Program
    {
        static void Main(string[] args)
        {     
                    Console.WriteLine("the average age is {0}",(decimal)(PepList().Sum(x=>x.age)/PepList().Count()));
               foreach(var s in PepList()){
                    Console.WriteLine("Name is {0}, age is {1}",s.FullName, s.age);
            }            
        }
        private static IEnumerable<Person> PepList(){
                 List<Person> people = stringList.loadPeople();        
                 people = people.OrderBy(x=>x.lastName).ToList();      
            return  people;           
        } 
    }
}
