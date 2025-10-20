using System;

/* Név: Barta Máté Bence
* Neptun Kód: SAZZ1P
* Email cím: bmate20050911@gmail.com <-(személyes) sazz1p@inf.elte.hu bartamate@student.elte.hu 
*/

namespace Barta_Máté_Bead_1C
{
    internal class Program
    {
        const int MaxN = 100;
        static void Main(string[] args)
        {
            // deklarálás
            Console.Error.WriteLine("Idős és alacson fizetésűek száma");
            int n, l, m, db;
            int[] k = new int[MaxN];
            int[] f = new int[MaxN];

            // beolvasás
            Console.Error.Write("N L M? : ");
            string[] tmp = Console.ReadLine().Trim().Split(" ");

            n = int.Parse(tmp[0]);
            l = int.Parse(tmp[1]);
            m = int.Parse(tmp[2]);

            Console.Error.WriteLine("Dolgozók életkora és fizetése");
            for (int i = 1; n >= i; ++i)
            {
                Console.Error.Write($"{i}. dolgozó adatai : ");
                string[] tmp2 = Console.ReadLine().Trim().Split(" ");
                k[i - 1] = int.Parse(tmp2[0]);
                f[i - 1] = int.Parse(tmp2[1]);
            }

            // feldolgozás
            db = 0;
            for(int i = 1; n >= i; ++i)
            {
                if (k[i - 1] > l && f[i - 1] < m) db++; // algoritmusban 1..n van írva, de mivel az array az 0-tól indexelődik, muszályok vagyunk kivonni az indexből 1-et az azonosításhoz
            }

            // kiíratás
            Console.WriteLine(db);
        }
    }
}
