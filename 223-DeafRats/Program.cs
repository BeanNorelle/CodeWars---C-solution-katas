using System;
using System.Collections.Generic;
using System.Linq;
namespace _223_DeafRats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DeafRats("~O~O~OO~O~O~~OP"));
        }
        public static int DeafRats(string data)
        {
            Stack<char> path = new Stack<char>();
            bool RightPiper = true;
            int Deaf = 0;
            char result = ' ';
            int tail =0; int head=0;

            foreach(char c in data)
            {
                if(RightPiper==true){
                    switch(c)
                        {
                            case '~':                                     
                                      if(head!=1){path.Push(c);}
                                      else head--;
                                      break;
                            case 'O': 
                                      if(path.Count()!=0){
                                      if(path.Pop()!='~'){ head++; Deaf++;} 
                                      }
                                      else{ Deaf++; head++;}
                                      break;

                            case 'P': RightPiper=false; path.Clear();break;
                            default: continue;
                        }
                } 
                else
                  if(RightPiper==false){
                    switch(c)
                        {
                            case 'O':                                     
                                      if(tail!=1){path.Push(c);}
                                      else tail--;
                                      break;
                            case '~': 
                                      if(path.Count()!=0){
                                      if(path.Pop()!='O'){ tail++; Deaf++;} 
                                      }
                                      else{ Deaf++; tail++;}
                                      break;

                            case 'P': RightPiper=false; path.Clear();break;
                            default: continue;
                        }
                } 

            }
            return Deaf;
        }


    }
}
