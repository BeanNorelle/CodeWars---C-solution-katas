using System;

namespace _49_linqpract01
{
    public class Person{
        public int age { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string FullName { get{ return firstName+" "+lastName;} set{}}
   
     }
    }
