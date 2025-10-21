namespace meleg
{
    internal class Program
    {
        const int MaxN = 100;
        const int MaxM = 100;
        static void Main(string[] args)
        {
            Console.Error.WriteLine("Egy melegebb település");

            // deklaráció
            int n, m, ind;
            int[,] h = new int[MaxN, MaxM];

            // beolvasás
            Console.Error.WriteLine("N M K? :");
            string[] tmp = Console.ReadLine().Split(" ");
            n = int.Parse(tmp[0]);
            m = int.Parse(tmp[1]);

            for(int ii = 0; ii < n; ii++)
            {
                Console.Error.WriteLine($"{ii + 1}. település hőmérsékletei: ");
                tmp = Console.ReadLine().Split(" ");
                for(int j = 0; j < m; j++)
                {
                    h[ii, j] = int.Parse(tmp[j]);
                }
            }

            // megoldás
            ind = -1;
            int i = 0;
            while((i < n) && (ind < 0))
            {
                int j = -1;
                do
                {
                    j++;
                    int k = 0;
                    while((k < m) && (h[i,k] > h[j, k]))
                    {
                        k++;
                        if (k >= m) ind = i;
                    }
                } while ((j < n) && (ind < 0));
                i++;
            }


            // kiíratás
            Console.WriteLine(ind);
        }
    }
}
