using System;

namespace _19_practice
{
        class Book
        {
            public string title;
            public string author;
            public int pages;
            public int edition;

            public Book(string aauthor,string atitle,int apages,int aedition)
            {
                title =atitle; author = aauthor; pages = apages; edition = aedition;
            }
            public string read()=>pages>=100? "This book is a really long read" : "This book is really short";
            

            
        }

}