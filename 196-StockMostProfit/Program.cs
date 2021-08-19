using System;
using System.Linq;

namespace _196_StockMostProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers =  {1, 2, 3, 4, 5, 6};
            Console.WriteLine(GetMostProfitFromStockQuotes(numbers));
        }

        public static int GetMostProfitFromStockQuotes(int[] quotes)
        {   
             int max = 0;  
             int result = 0; 
             int qlen = quotes.Length -1;
             int index = 0;
             int [] QouteR = quotes;

                for (int i = 0; i <= qlen; i++)
                    {
                        index = qlen - i;
                        if (QouteR[index] < max)
                        {
                            result += max - QouteR[index];
                        }
                        else
                        {
                            max = QouteR[index];
                        }
                    }
             return result;
        }
    }
}
