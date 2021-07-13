using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _133_ShoppingCart 
{   
    class Program
    {
        public static Hashtable CustomerTable = new Hashtable();
        public static Hashtable ProduceTable = new Hashtable();
        public static Hashtable TransactionTable = new Hashtable();
        public static List<string> NameList = new List<string>();
        static void Main(string[] args)
        {                
       List<string>inputArray = new List<string>{
            "Carrot is $1.",
            "Watermelon is $5.",
            "Lemon is $2.",
            "Steve has $10.",
            "Jim has $800.",
            "Steve buys 7 carrots.",
            "Jim buys 2 watermelons.",
            "Jim buys 1 carrot."};        

            foreach(var s in ShoppingCalculation(inputArray))
            {
                Console.WriteLine(s.Item1+" "+s.Item2+" "+s.Item3);
            }   
        }    
        public static List<(string, string, string)> ShoppingCalculation(List<string> inputList)
        {
            foreach(var input in inputList)
            {
                ProcessDataString(input);
            }

        int CustomerCount = CustomerTable.Count;        
        List<(string,string,string)> TransactionList = new List<(string, string, string)>(CustomerCount);

            string product = string.Empty; string Change = string.Empty;
            string name = string.Empty; int quantity = 0;
   
            foreach(var entry in NameList)
            {   
                StringBuilder sb = new StringBuilder();
                product = string.Empty;
                quantity = 0;
                Change = string.Empty;

                var smallJobs = TransactionTable.Values.Cast<Transactions>()
                                                       .Where(Transactions => Transactions.CustomerName == entry)
                                                       .OrderBy(x=>x.TransactionsReciept);

                foreach(var s in smallJobs)
                {              
                    quantity = s.Quantity;
                    product = MakePluralProducts(s.Product,quantity);
                    sb.Append(quantity+" "+product);
                    sb.Append(',');
                }       
            
                string productList = sb.ToString().Trim(',');
                Person customer = (Person)CustomerTable[entry];
                Change = customer.Currency+customer.Money.ToString(); 
                TransactionList.Add((entry,Change,productList));
            }
            return TransactionList;          
        }

        public static void ProcessDataString(string str)
        {   
            string [] strArray = str.Replace(".","").Split(' ');

            Person person;
            Produce produce;
            Transactions transactions;

            string currencySymbol = string.Empty;
            int currencyAmount = 0;

            if(strArray[1] == "has")
            {
                currencyAmount = GetCurrencyMoney(strArray[2]).Item1;
                currencySymbol = GetCurrencyMoney(strArray[2]).Item2;
                string name = CheckCustomerTable(strArray[0]);
                person = new Person(name,currencyAmount,currencySymbol);
                
                NameList.Add(name);
                CustomerTable.Add(person.Name,person);
            }

            if(strArray[1] == "is")
            {   
                currencyAmount = GetCurrencyMoney(strArray[2]).Item1;
                currencySymbol = GetCurrencyMoney(strArray[2]).Item2;
                produce = new Produce(strArray[0],currencyAmount,currencySymbol);
                ProduceTable.Add(produce.ProduceName,produce);
            }

            if(strArray[1] == "buys")
            {
                int id = TransactionTable.Count;
                int Quantity = Convert.ToInt32(strArray[2]);
                string CustomerName = strArray[0]; 
                string product = CheckInventoryItems(strArray[3],Quantity);        
                string Symbol = GetCurrencySymbol(product);
                int totalPrice =  GetProductPrice(product) * Quantity;  
                int CustomerWallet = GetPersonMoney(strArray[0]);                    
                int change =  CustomerWallet - totalPrice;
                 
                transactions = new Transactions(id,CustomerName,Quantity,product,totalPrice,Symbol,change,CustomerWallet);
                TransactionTable.Add(transactions.TransactionsReciept,transactions);

                UpdatePersonWallet(change,CustomerName);
            }               
        }
        
        public static string MakePluralProducts(string product,int q)
        {
           return (q>1) ? product.ToLower()+'s' : product.ToLower();
        }
        public static string CheckCustomerTable(string str)
        {
            return (!CustomerTable.ContainsKey(str)) ? str : throw new ArgumentException("Duplicate User"); 
        }
        public static string CheckInventoryItems(string str,int q)
        {   
            string word = (q!=1) ? str.Remove(str.Length-1) : str;
            string itemProduct = Char.ToUpper(word[0]) + word.Substring(1);
            return (ProduceTable.ContainsKey(itemProduct)) ? itemProduct : "Unavailable";
        }
        public static Tuple<int,string> GetCurrencyMoney(string str)
        {
            int Money = Int32.Parse(Regex.Match(str, @"\d+").Value);
            string symbol = Regex.Match(str, @"\D").Value;
            return Tuple.Create(Money,symbol);
        }
        public static int GetProductPrice(string productName)
        {
            Produce producePrice = (Produce)ProduceTable[CheckInventoryItems(productName,1)];
            return ProduceTable.ContainsKey(CheckInventoryItems(productName,1)) ? producePrice.ProducePrice : 0;
        }
        public static string GetCurrencySymbol(string productName) //gets Currency symbol and check for 
        {
            Produce producePrice = (Produce)ProduceTable[CheckInventoryItems(productName,1)];
            return ProduceTable.ContainsKey(CheckInventoryItems(productName,1)) ? producePrice.Currency : string.Empty;
        }
        public static int GetPersonMoney(string CustomerName)
        {   
            Person customer = (Person)CustomerTable[CustomerName];  
            return (CustomerTable.ContainsKey(CustomerName)) ? customer.Money : 0;
        }
        public static void UpdatePersonWallet(int change,string CustomerName)
        {
            Person customer = (Person)CustomerTable[CustomerName];
            customer.Money = change;
        }
    }
    public class Person 
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public string Currency { get; set; }
        public Person(string name,int money,string currency)
        {
            this.Name = name;
            this.Money = money;
            this.Currency = currency; 
        }
    }
    public class Produce
    {
        public string ProduceName { get; set; }
        public string Currency {get; set;}
        public int ProducePrice { get; set; }
        public Produce(string name, int price, string currency)
        {
            this.ProduceName = name;
            this.ProducePrice = price;
            this.Currency = currency;
        }
    }

    public class Transactions
    {
        public int TransactionsReciept {get;set;}
        public string CustomerName {get; set;}
        public string Currency {get; set;}
        public string Product {get; set;}  
        public int CustomerMoney {get; set;} 
        public int Change {get; set;} 
        public int TotalPrice {get; set;}
        public int Quantity {get; set;}

        public Transactions(int id, string name,int quantity,string product,int totalPrice,string currency,int change,int customerMoney)
        {  
            this.TransactionsReciept = id;
            this.CustomerName = name;
            this.Currency = currency;
            this.TotalPrice = totalPrice;
            this.CustomerMoney = customerMoney;
            this.Product = product;
            this.Quantity = quantity; 
            this.Change = change;
        }
    }
}
