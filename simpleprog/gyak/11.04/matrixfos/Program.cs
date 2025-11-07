namespace matrixfos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deklaráció
            int ki;



            beolvasas(out int n, out int v, out int [,] p);

            ki = maxpoontos(n, v ,p);

            kiiras(ki);

        }

        static void beolvasas(out int n, out int v, out int[,] p)
        {
            Console.Error.WriteLine("Add meg a versenynapok és a bersenyzők számát (tab-bal elválasztva): ");
            string[] tmp = Console.ReadLine().Split("\t");
            n = int.Parse(tmp[0]);
            v = int.Parse(tmp[1]);
            p = new int[n, v];

            for (int j = 0; j < n; j++)
            {
                Console.Error.WriteLine($"Add meg a(z) {j + 1}. versenynapon szerzett pontszámokat (tab-bal elválasztva): ");
                tmp = Console.ReadLine().Split("\t");
                for (int i = 0; i < v; i++)
                {
                    p[i, j] = int.Parse(tmp[i]);
                }

            }

        }

        static int maxpoontos(int n, int v, int[,] p) 
        {
            int ki = 0;
            for (int i = 0; i < v; i++)
            {
                if (ossz(ki, n, p) < ossz(i, n, p))
                {
                    ki = i;
                }
            }
            return ki;
        }

        static int ossz(int n, int i, int[,] p)
        {
            int s = 0;
            for (int j = 0; j < n; j++)
            {
                s += p[j, i];
            }
            return s;
        }

        static void kiiras(int ki)
        {
            Console.Error.WriteLine($"A(z) {ki + 1}. versenyzőnek van a legtöbb pontja.");
        }


    }
}
