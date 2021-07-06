using System;
using System.Linq;

namespace _43_smallestpermu
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(smallestPermu(-202301));
            // Console.WriteLine(-2003==smallestPermu(-3200));
            // Console.WriteLine(23499==smallestPermu(29394));
            // Console.WriteLine(2004788==smallestPermu(4087082));
        }

        public static int smallestPermu(int num){
                   bool negative = false;
                    if(num<0){num=num*-1; negative = true;}

                        string strnum = Convert.ToString(num);
                        char []s = strnum.ToCharArray();
                        Array.Sort(s);
                                                
                                  if(s[0]=='0')
                                  {
                                      for(int i=0;i<s.Length;i++){
                                         if(s[i]!='0'){                       
                                             s[0]=s[i];
                                             s[i]='0';
                                             break;
                                          }
                                       }
                                 }
                            
                                 
                                    if(negative)
                                    {return Int32.Parse(s)*-1;}
                                    else{
                                    return Int32.Parse(s);}
                                    
       
        
    }
}
} 
