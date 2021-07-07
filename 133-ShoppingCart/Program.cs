using System;
using System.Collections.Generic;
using System.Collections;

namespace _133_ShoppingCart
{
    
    class Program
    {
   

        public static Hashtable HashTble;
        static void Main(string[] args)
        {
        
        string input = "Alice has $10";
            
    
             DetermineInputData(input);

            foreach()
           
        }
     public static Dictionary<string,string> Produce = new Dictionary<string,string>();
     public static Dictionary<string,string> Customer = new Dictionary<string,string>();
     public static Dictionary<string,int,string> Transaction = new Dictionary<string,int,string>();
    //  public static List<(string, string, string)> ShoppingCalculation(List<string> input) 
    //  {   
    //      CustomerData customerData;             
    //  }
    
    public static void DetermineInputData(string input)
    {
        string [] strArray = input.Split(' ');
        if(input.Contains("has"))
        {
            Customer.Add(strArray[0],strArray[2]);
        }
        if(input.Contains("is"))
        {
            Produce.Add(strArray[0],strArray[2]);
        }
        if(input.Contains("buys"))
        {
            Transaction.Add(strArray[0],strArray[2]);
        }
    }

    }









     public class CustomerData
    {
         public int id {get; set;}
         public string name {get; set;}
         public float Money {get; set;}
         public string Produce {get; set;}
         public CustomerData(int id,string name,float Money, string Produce)
         {
             this.id = id;
             this.name = name;
             this.Money= Money;
             this.Produce = Produce; 
         }
    }


}
