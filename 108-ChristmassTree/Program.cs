using System;
using System.Text;

namespace _108_ChristmassTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*',4));
            Console.WriteLine(ChristmasTree(30));
        }
         public static string ChristmasTree(int height)
        {   
            int nSpaces = ((height*2)/2) -1;
            StringBuilder sB = new StringBuilder();

            for(int i=0;i<height;i++)
            {
                sB.Append(' ', (nSpaces)-i);
                sB.Append('*', (i*2)+1);
                sB.Append(' ', (nSpaces)-i);

               if(i!=height-1){sB.Append('\n',1);}       
            }
            return sB.ToString();
        }

        public static string ChristmasTree2(int height)
        {
                var simbolo = "*";
                var avr = "";
                var linha_avr = "";
                int padrao = 1;
                var blank = "";

            for (int i = 1; i <= height; i++)
            {   var q = i + 1;
                while (q <= height)
                {
                    blank += " ";
                     q++;
                }

                     if (i==1){ linha_avr = blank + "*" + blank;}
                     if (i>1){int a = i + padrao;
                        do { linha_avr += simbolo; a--;} 
                
                while (a > 0);{
                    linha_avr = blank + linha_avr + blank;
                    padrao++;}
                }
                    avr += linha_avr;
                    avr += i < height ? "\n" : "";
                    linha_avr = "";
                    blank = "";
                }
          

                return avr;
        }
    }
}
