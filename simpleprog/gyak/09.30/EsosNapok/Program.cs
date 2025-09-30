using System;

namespace EsosNapok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int MaxN = 100;
            int n, db = 0;
            int[] m = new int[MaxN + 1];

            Console.Error.Write("N = ?: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Error.Write($"Esős nap {i} mennyi eső esett?: ");
                m[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 1; i <= n; i++)
            {
                if (m[i] > 0) db++;
            }

            Console.WriteLine($"{db}");
        }
    }
}



