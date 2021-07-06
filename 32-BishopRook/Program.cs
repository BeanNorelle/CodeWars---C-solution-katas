using System;
using System.Collections.Generic;

namespace _32_BishopRook
{
    class Program
    {
        static void Main(string[] args)
        {
            //the chessboard generate from a two dimensional array           
     
  
          string bishop =  "f3";

        string rook = "e2";

        Console.WriteLine("Bishop on {0} and rook on {1}. Can bishop take rook? {2}",bishop,rook, find2(bishop, rook));
                Console.WriteLine("Bishop on {0} and rook on {1}. Can bishop take rook? {2}",bishop,rook, BandP(bishop, rook));
        }
        
//find if coordinates are equal method return boolean
public static bool find2(string pos,string pod){ 
          string [,]chessboard = new string[8,8] {{"a1","b1","c1","d1","e1","f1","g1","h1"},
                                                    {"a2","b2","c2","d2","e2","f2","g2","h2"},
                                                    {"a3","b3","c3","d3","e3","f3","g3","h3"},
                                                    {"a4","b4","c4","d4","e4","f4","g4","h4"},
                                                    {"a5","b5","c5","d5","e5","f5","g5","h5"},
                                                    {"a6","b6","c6","d6","e6","f6","g6","h6"},
                                                    {"a7","b7","c7","d7","e7","f7","g7","h7"},
                                                    {"a8","b8","c8","d8","e8","f8","g8","h8"}};

    var pos2 = new List<string>();
     int x = 0;
     int y =0;
          for(int i = 0; i<8; i++){
                for(int j = 0; j<8;j++){
                        if(chessboard[j,i].Equals(pos)){              
                    
                            x=i;
                            y=j;
                        }
                  }
          }

          //right down direction
        for(int m=x,o=y;o<8; o++){              
            if(m<8){              
           //  Console.WriteLine("1 these are the coordinates: {0}", chessboard[o,m]);
             pos2.Add(chessboard[o,m]);
               m++;                
                }
        }
        //left down direction
        for(int n=y,b=x;n<8;n++){           
            if(b>-1){
            //    Console.WriteLine("2 these are the coordinates: {0}", chessboard[n,b]);
                    pos2.Add(chessboard[n,b]);
              b--;       
                }
        }
        //upward right direction
        for(int a=y,q=x;a>-1;a--){
              if(q<8){
              //   Console.WriteLine("3 these are the coordinates: {0}", chessboard[a,q]);
                     pos2.Add(chessboard[a,q]);
              q++;       
                } 
        }
        //upward left direction
        for(int u=y,p=x;u>-1;u--){
              if(p>-1){
                // Console.WriteLine("4 these are the coordinates: {0}", chessboard[u,p]);
                     pos2.Add(chessboard[u,p]);
              p--;       
                } 
        }
       return  pos2.Contains(pod);   
     }
//this is a better solution
  public static bool BandP(string bishop, string pawn)
        {
            var bishopPos = bishop.ToCharArray();  
            var pawnPos = pawn.ToCharArray();
      
            if (MathF.Abs(bishopPos[0] - pawnPos[0]) == MathF.Abs(bishopPos[1] - pawnPos[1]))
                return true;
            else
                return false;

                
        }

    }
}
