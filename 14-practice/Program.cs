using System;
using System.Collections.Generic;

namespace _14_practice
{
    class Program
    {
        static void Main(string[] args)
        {

        List<int> numberlist = new List<int>();
      int power=2;
    for(int i =0;i<10;i++){
      
      numberlist.Add(i);
     
       Console.WriteLine(Math.Pow(2,i));
    }
       
    }
}
}