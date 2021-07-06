using System;
using System.Collections.Generic;

namespace _71_snailpattern
{
    class Program // this is my first 4kyu kata
    {
        static void Main(string[] args)
        {
            int [][] arrayS = {new int[4]{11,12,13,14},
                               new int[4]{21,22,23,24},
                               new int[4]{31,32,33,34},
                               new int[4]{41,42,43,44}};

             int [][] arrayS2 = {new int[3]{11,12,13},
                                 new int[3]{21,22,23},
                                 new int[3]{31,32,33}};

                int [][] arrayS3 = {new int[5]{11,12,13,14,15},
                                    new int[5]{21,22,23,24,25},
                                    new int[5]{31,32,33,34,35},
                                    new int[5]{41,42,43,44,45},
                                    new int[5]{51,52,53,54,55}};
                
                int [][] arrayS4 = {new int[]{}};//array is zero



                List<object> arrList = new List<object>{arrayS,arrayS2,arrayS3,arrayS4};
                int count=1;
                foreach(int[][] arr in arrList){
                    
                    Console.WriteLine("\n This is array no#: {0} ",count );
                        snailPat(arr); count++;
                }
                                         
        }
           
        public static int [] snailPat(int[][] array){

            if(array[0].Length==0)
            {   Console.WriteLine("Is empty");
                return new int[0]; } 
            else{
             int count =0; int count2 =0;  int count3 =0; int count4=0; int nn = (int)Math.Pow(array.GetLength(0),2);
            int numpass =0; 
            List<int> snail = new List<int>();

            while(nn>=numpass){
 Console.Write(">");
                 for(int i =0+count ; i<array.GetLength(0)-count; i++){//yoop 1 toRight
                   
                    Console.Write(array[count][i]+ " ");   numpass++;

                    snail.Add(array[count][i]);

                        } if(numpass==nn){break;}count+=1; Console.WriteLine("");

 Console.Write("v");
                 for(int j = 0 + count;j<array.GetLength(0)-count2;j++){//loop 2 toDown
                   
                     Console.Write(array[j][(array.GetLength(0)-1)-count2] + " ");

                        snail.Add(array[j][(array.GetLength(0)-1)-count2]);

                    numpass++;
                        }  if(numpass==nn){break;} count2+=1; Console.WriteLine("");


 Console.Write("<");
                 for(int k = array.GetLength(0)-count2 ;k>count3 ;k--){//loop 3 toLeft

                    Console.Write(array[(array.GetLength(0)-1)-count3][k-count2+count3]+" ");
                    
                    snail.Add(array[(array.GetLength(0)-1)-count3][k-count2+count3]);

                     numpass++;
                         }  if(numpass==nn){break;} count3+=1; Console.WriteLine("");

 Console.Write("^");
                 for(int l = array[0].Length-count3;l>count3;l--){//loop 4 to UP

                     Console.Write(array[l-count3+count4][0+count4] + " ");

                     snail.Add(array[l-count3+count4][0+count4]);numpass++;

                         }count4+=1; Console.WriteLine("");

                         if(numpass==nn){break;}
            }

            return snail.ToArray();
            }
    }
  }
}