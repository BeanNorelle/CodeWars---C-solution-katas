using System;

namespace _95_BuildTower
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var s in TowerBuilder(5)){
                Console.WriteLine(s);
            }
        }
        public static string[] TowerBuilder(int nFloors){
            string [] towerFloor = new string[nFloors];
            

            for(int i = 0; i<nFloors;i++){
                string Sb = "";
                Sb += new String(' ', (nFloors-1)-i);
                Sb += new String('*', (i*2)+1);
                Sb += new String(' ', (nFloors-1)-i);
                towerFloor[i] = Sb;

            }

            return towerFloor;
        }
    }
}
