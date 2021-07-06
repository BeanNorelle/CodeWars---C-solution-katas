using System;

namespace _50_scopingExperiments
{
    class Program
    {
        static void Main(string[] args)
        {

                int a =3;
                int b =8;
                
                int c;
                {
                    c = a+b;
                } 


               

                     Console.WriteLine("{0} {1}",doo(),sum());
        }
       
        public static Func<int> doo =() =>{
                    return 2+3;
                };
        public static int sum(){
            return 2+5;
        }


    }
}
