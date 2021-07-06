using System;

namespace c_
{

    class lib
    
    {
        protected int Number;
        public int number { 
            get{return Number;} 
            set{if(value<=10){               
                Console.WriteLine("You are too young.");}
            else{
                Console.WriteLine("You are of the right age.");} 
                Number = value;} 
                }
        public string name { get; set; }
    }
}