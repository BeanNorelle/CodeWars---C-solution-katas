using System;
using System.Diagnostics;
namespace _55_logilcalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();

            bool[]boolarr = {true , false, true};
            sw.Start();
            Console.WriteLine("The result is: {0}",boolres(boolarr,"XOR"));
            sw.Stop();
            Console.WriteLine("Elapsed: {0}",sw.Elapsed.TotalMilliseconds);
        }
        public static bool boolres(bool[] boolarray, string operat)
        {
            switch(operat){
                case "AND": return booland(boolarray);
                case "XOR": return boolxor(boolarray); 
                case "OR": return boolxor(boolarray);
                default: return false;
            }
        }
        //AND operator returns boolean
        public static bool booland(bool[]arrayand){ 
            bool boo=arrayand[0];
            for(int i = 1; i<arrayand.Length;i++){
                boo =(arrayand[i]&&boo);
            }
            return boo;
        }
        //XOR operator returns boolean
         public static bool boolxor(bool[]arrayand){
            bool boo=arrayand[0];
            for(int i = 1; i<arrayand.Length;i++){
                boo =(arrayand[i]^boo);
            }
            return boo;
        }
        //OR operator
         public static bool boolor(bool[]arrayand){
            bool boo=arrayand[0];
            for(int i = 1; i<arrayand.Length;i++){
                boo =(arrayand[i]||boo);
            }
            return boo;
        }
    }
}
