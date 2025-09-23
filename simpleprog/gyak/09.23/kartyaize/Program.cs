using System.Threading.Channels;

namespace kartyaize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kartyak = ["7", "8", "9", "t", "a", "f", "k", "A"];
            int[] ertekek = [7, 8, 9, 10, 2, 3, 4, 11];
            bool kedv = true;
            const int db = 8;
            int osszeg = 0;

            int pont = 0;

            Console.WriteLine("21-re egészítsd ki!! (i/n) válaszok");
            while (kedv)
            {
                string? valasz;

                int ertek;

                // beolvasás
                do
                {

                    Random rnd = new();
                    string kartya = kartyak[rnd.Next(1, 9) - 1];

                    // implementálás

                    int i = 1;
                    while (kartya != kartyak[i - 1])
                    {
                        i++;
                    }
                    ertek = ertekek[i - 1];
                    if (ertek == 11 && osszeg > 10) osszeg += 1;
                    else osszeg += ertek;

                    if (osszeg > 21)
                    {
                        Console.WriteLine($"Túllépted! Az összeged: {osszeg}");
                        Console.WriteLine($"A húzott kártyád: {kartya}");
                        break;
                    }
                    else if (osszeg == 21)
                    {
                        Console.WriteLine($"Eltaláltad! Az összeged: {osszeg}\nA húzott kártyád: {kartya}\n\t\t\tKaptál 5 pontot!");
                        pont += 5;
                        break;
                    }

                    // kiírás
                    Console.WriteLine($"A húzott kártyád: {kartya}");
                    Console.WriteLine($"Eddig összesen: {osszeg}");

                    Console.WriteLine("Húzol még?");
                    valasz = Console.ReadLine();
                } while ((valasz == "y") || (valasz == "Y") || (valasz == "i") || (valasz == "I") || (valasz == ""));

                if (osszeg == 20)
                {
                    pont += 4;
                    Console.WriteLine("\t\t\tKaptál 4 pontot!");
                }
                if (osszeg == 19)
                {
                    pont += 3;
                    Console.WriteLine("\t\t\tKaptál 3 pontot!");
                }
                if (osszeg == 18)
                {
                    pont += 2;
                    Console.WriteLine("\t\t\tKaptál 2 pontot!");
                }
                if (osszeg == 17)
                {
                    pont += 1;
                    Console.WriteLine("\t\t\tKaptál 1 pontot!");
                }


                osszeg = 0;

                Console.WriteLine($"Eddig {pont} pontod van!\nVan-e még kedv?");
                valasz = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"\tÖsszesen {pont} pontod van!");
                if ((valasz != "y") && (valasz != "Y") && (valasz != "i") && (valasz != "I") && (valasz != "")) kedv = false;
            }
            Console.WriteLine("Nyomj egy gombot a kilépéshez!");
            Console.ReadKey();
        }
    }
}
