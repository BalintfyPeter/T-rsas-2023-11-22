using System;
using System.IO;

namespace tarsas 
{
    internal class Program
    {

        // M: nothing
        // E: forward
        // V: back

        static void Main(string[] args)
        {

            //Feladat 1
            string[] paths = File.ReadAllLines("osvenyek.txt");
            string[] nums = File.ReadAllLines("dobasok.txt");


            //Feladat 2
            Console.WriteLine("2. feladat");
            Console.WriteLine("a dobások száma:" + ;
            Console.WriteLine("Az ösvények száma:" + paths.Length);


            //Feladat 3
            Console.WriteLine("3. feladat");

            int longestPath = 0;

            for (int path = 0; path < paths.Length; path++)
            {
                if (paths[path].Length > longestPath)
                {
                    longestPath = path;
                }
            }

            Console.WriteLine("Az egyik leghosszabb a(z) " + longestPath + " ösvény, hossza: x");


            //Feladat 4
            Console.WriteLine("4. feladat");

            Console.Write("Adja meg egy ösvény sorszámát!");
            int playedPath = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a játékosok számát!");
            int playerNum = Convert.ToInt32(Console.ReadLine()); 

            Convert.ToInt32(playerNum);

            if (playerNum > 2 || playerNum < 5)
            {
                Console.WriteLine("Hiba! Az adott szám kissebb mint 2 vagy nagyob mint 5!");
            }


            //Feladat 5
            int M = 0;
            int E = 0;
            int V = 0;

            foreach (var field in playedPath)
            {
                if (field == "M")
                {
                    M++;
                }

                else if (field == "E")
                {
                    E++;
                }

                else if (field == "V")
                {
                    V++;
                }
            }

            Console.WriteLine("5. feladat");
            Console.WriteLine("M:" + M + "darab");
            Console.WriteLine("E:" + E + "darab");
            Console.WriteLine("V:" + V + "darab");
        }
    }
}