namespace _09._09cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine($"a1: {a++}");
            Console.WriteLine($"a2: {a++}");
            Console.WriteLine($"a3: {a++}");
            Console.WriteLine($"a4: {a++}");
            Console.WriteLine($"a5: {a++}");
            Console.WriteLine($"a6: {a++}");
            Console.WriteLine($"a7: {a++}");
            Console.WriteLine($"a8: {a++}");
            Console.WriteLine($"a9: {a++}");
            Console.WriteLine($"a10: {a++}");

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{a + i}");
            }

        }
    }
}
