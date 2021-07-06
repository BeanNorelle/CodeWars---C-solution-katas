using  System;
using System.Collections.Generic;

namespace _28_inheiritance
{
    class Mindanao
    {
        public string Province { get; set; }
    }

    class Region10 : Mindanao
    {
        public  List<string> city = new List<string>()
        {"CDOC", "CEBU", "DAVAO","MANILA"};
        



    }
}