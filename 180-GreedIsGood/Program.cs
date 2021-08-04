using System;

namespace _180_GreedIsGood
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = {4, 4, 4, 3, 3};
            Console.WriteLine(Score(arr));
        }
        public static int Score(int[] dice) 
        {    
              int result = 0;
              int one = 0;
              int two = 0;
              int three = 0;
              int four = 0;
              int five = 0;
              int six = 0;

             foreach(int num in dice)
             {
                 switch(num)
                 {
                     case 1: one++; break;
                     case 2: two++; break;
                     case 3: three++; break;
                     case 4: four++; break;
                     case 5: five++; break;
                     case 6: six++; break;
                 }
             }

             if(one==3) result += 1000;
             if(two>=3) result += 200;
             if(three>=3) result += 300;
             if(four>=3) result += 400;
             if(five>=3) result += 500;

             if(one==1) result += 100;
             if(five==1) result += 50;

             return result;
        }
    }
}
