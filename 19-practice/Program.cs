
using System; //using classes

namespace _19_practice
{
    class Program
    {
        static void Main(string[] args)
        {
           Book redrising = new Book("Brown","Red Rising",765,1);
             Book icdedragon = new Book("Martin","Ice dragon",55,1);
         
            Console.WriteLine(redrising.title+ " " +redrising.read());
             Console.WriteLine(icdedragon.title+ " " +icdedragon.read());

            numbers n = new numbers();
            n.age = 22;
            Console.WriteLine(n.Age);

        }
    }
}
