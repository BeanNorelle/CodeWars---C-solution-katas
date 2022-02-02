using System;
using System.Linq;

namespace _225_ParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] nArr = {2,4,7};

            Console.Write(LinqFindOutlier(nArr));
        }

        public static int FindOutlier(int [] nArr)
        {
            int odd = 0;
            int even = 0;
            for(int i = 0; i<3;i++)
            {
                if(nArr[i]%2==0)
                {odd++;}
                else
                even++;
            }
            return WhatNum(nArr,(odd>even)); 
        }
        public static int WhatNum(int [] n,bool IsOdd)
        {   
            if(IsOdd)
            foreach(int s in n)
            {
                if(s%2!=0) return s;
            }
            else
            foreach(int s in n)
            {
                if(s%2==0) return s;
            }
            return 0;
        }
        public static int LinqFindOutlier(int [] nlist)
        {
            int odd = 0;
            int even = 0;
            for(int i = 0; i<3;i++)
            {
                if(nlist[i]%2==0)
                {odd++;}
                else
                even++;
            }
            return (nlist.Where(integer => (odd<even) ? integer % 2 == 0 : integer % 2 != 0)).First();
        }
    }
}
