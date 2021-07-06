using System;

namespace _25_practice
{
    class names{
        public string Getname;
        public int age;

        public string naml()
        {
         Getname = Getname+Convert.ToString(age);
         return Getname;
        }

        public string snames { get=>snames; set{Getname =value+"sds";} } 
    }

    }

