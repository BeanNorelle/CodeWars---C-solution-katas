using System;

namespace _82_humanReadable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7231;
            Console.WriteLine(GetReadableTime(n));

        }
            public static string GetReadableTime(int seconds)
            {
                int n = seconds;
                string s = (n/60/60).ToString("d2")+":"+(n/60 %60).ToString("d2")+":"+(n%60).ToString("d2");
                return s;
            }
    }
}
