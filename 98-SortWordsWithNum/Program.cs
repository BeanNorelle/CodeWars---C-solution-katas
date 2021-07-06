using System;
using System.Text.RegularExpressions;

namespace _98_SortWordsWithNum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string Words = "4of Fo1r pe6ople g3ood th5e the2";
                    Console.Write(wordsArray(Words));

        }

        public static string wordsArray(string Words){

                    string [] wordsArray = Words.Split(" ");
                   int [] intArray = new int [wordsArray.Length];

            for(int i =0; i<wordsArray.Length;i++){
              intArray[i] = Int32.Parse(Regex.Replace(wordsArray[i], @"[A-Za-z ]", string.Empty));
            }
            
                for(int i = 0;i<intArray.Length;i++)
                    for(int j = 0;j<intArray.Length;j++){
                        if(intArray[j]>intArray[i]){
                            
                            var temp = intArray[j];
                            intArray[j] = intArray[i];
                            intArray[i] = temp;

                            var temp2 = wordsArray[j];
                            wordsArray[j] = wordsArray[i];
                            wordsArray[i] = temp2;

                        }
                    }

            return string.Join(" ", wordsArray);
        }
    }
}
