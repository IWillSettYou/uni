namespace allatkert
{
    internal class Program
    {
        struct TeruletT
        {
            public string nev;
            public int adb;
            public string[] ak;
        }

        const int MaxN = 100;

        static void Main(string[] args)
        {
            Console.Error.WriteLine("Állatkert");

            // deklaráció
            int osszA, dbMajom;
            string holKacsa;
            TeruletT[] a  = new TeruletT[MaxN];

            // beolvasás
            Beolvasas(out int n, ref a);

            // megoldás

            osszA = Ossz(n, ref a);
            dbMajom = Megszamol(n, ref a);
            holKacsa = Kivalaszt(n, ref a);

            // kiíratás
            Kiir(osszA, dbMajom, holKacsa);




        }
        static void Beolvasas(out int n, ref TeruletT[] a)
        {

                bool vanKacsa = false;
                bool hiba = false;
            do
            {
                do
                {
                    Console.Error.Write("Hány terület láttatok az állatkertben?: ");
                    hiba = !int.TryParse(Console.ReadLine(), out n) || n <= 0;
                    if (hiba) Console.Error.WriteLine("ANYÁD!");
                } while (hiba);
                for (int i = 0; i < n; i++)
                {
                    Console.Error.WriteLine($"{i + 1} terület adatai: ");
                    Console.Error.Write(" neve?: ");
                    a[i].nev = Console.ReadLine();
                    do
                    {

                        Console.Error.WriteLine(" álatok száma a területen?: ");
                        hiba = int.TryParse(Console.ReadLine(), out a[i].adb);
                        if (!hiba)
                        {
                            Console.Error.WriteLine(" állatok listája ;-vel elválasztva?: ");
                            a[i].ak = Console.ReadLine().Split(";");
                            hiba = (a[i].adb != a[i].ak.Length);
                        }
                        if (hiba) Console.Error.WriteLine("ANYÁD MEGINT!");
                        vanKacsa = vanKacsa || Van(a[i], "kacsa");
                    } while (hiba);

                }
                if (vanKacsa)
                {
                    Console.Error.WriteLine("ANYÁD HARMADJÁRA!");
                }
            } while (!vanKacsa);

        }

        static int Ossz(int n, ref TeruletT[] a)
        {
            int s = 0;
            for(int i = 0; i < n; ++i)
            {
                s += a[i].adb;
            }
            return s;
        }
        static int Megszamol(int n, ref TeruletT[] a)
        {
            int s = 0;
            for (int i = 0; i < n; ++i)
            {
                if (Van(a[i], "majom"))
                {
                    s++;
                }
            }
            return s;
        }

        static bool Van(TeruletT t, string mi)
        {
            int i = 0;
            while((i < t.adb) && (t.ak[i] != mi))
            {
                i++;
            }
            return i < t.adb;
        }

        static string Kivalaszt(int n, ref TeruletT[] a)
        {
            int holInd = 0;
            while (!Van(a[holInd], "kacsa"))
            {
                holInd++;
            }
            return a[holInd].nev; ;
        }
        static void Kiir(int osszA, int dbMajom, string holKacsa)
        {
            Console.WriteLine($"{osszA}\n{dbMajom}\n{holKacsa}");
        }

    }
}
