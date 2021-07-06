using System;
using System.Collections.Generic;

namespace _59_humanreadable
{
    class Program
    {
        static void Main(string[] args)
        {   
         string [] leThirteen = {"one","two", "three","four","five","six","seven","eight","nine","ten","eleven"
          ,"twelve","thirteen"};
          string [] gttens = {"twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninety;"};
            int []num = {1,12,304,4,5};
            foreach(var nlist in str(num,leThirteen,gttens)){
                Console.WriteLine(nlist);
            }
           
        }
        public static string[] str(int [] numList,string[]leThirteen,string []gttens)
        {
     
        string word="";
        List<string> numList1 = new List<string>();
   
        foreach(var num in numList){
            if(num<=13){
                word+=leThirteen[num-1];
            }
            if(num>=14&&num<20){
              
                    word+=numstr(num,leThirteen);
            }
            if(num>99){
                word+=leThirteen[(num/100)-1]+" hundred";
                if((num%100)!=0){  
                   word+=(" and "+ leThirteen[(int)(((num/100m)-(num/100))*100)-1]);
                     }
            }
            numList1.Add(word);
            word="";
         }
            numList1.Sort();
            return numList1.ToArray();
        }
        public static string numstr(int num,string[]leThirteen){
                 if(num==15){
                    return "fifteen";
                }
                else{
                    return leThirteen[num-10-1]+"teen";
        }
    }
    }
}
