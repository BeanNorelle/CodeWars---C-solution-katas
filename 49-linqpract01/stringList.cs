using System;
using System.Collections.Generic;
namespace _49_linqpract01
{
    public class stringList
    {
        public static List<Person> loadPeople()
        {
            List<Person> listPeople = new List<Person>();

            listPeople.Add(new Person{firstName="Bean Norelle",lastName="Sobremisana",age=29});
            listPeople.Add(new Person{firstName="Mark",        lastName="Sajulga",age=29});
            listPeople.Add(new Person{firstName="Mojeb",       lastName="Tantao",age=31});
            listPeople.Add(new Person{firstName="Nassif",      lastName="Panda",age=30});
            listPeople.Add(new Person{firstName="Kevin",       lastName="Mugot",age=28});
            return listPeople;
        }
    }
}