using System.IO;
namespace doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();
            using (var sr = new StreamReader(@"..\..\..\src\solsys.txt"))
            {
                while (!sr.EndOfStream) bolygok.Add(new Bolygo(sr.ReadLine()));
            }

            Console.WriteLine("3: feladat:");

            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");

            Console.WriteLine($"3.2: a naprendszerben egy bolygónak átlagosan {bolygok.Average(b => b.HoldSzama)}");

            var maxbolygo = bolygok.SingleOrDefault(b => b.Aranya == bolygok.Max(b2 => b2.Aranya));
            Console.WriteLine($"3.3: a legnagyobb térfogatú bolygó a" +
                $" {maxbolygo.Nev}");

            Console.Write("3.4: Írd be a keresett bolygó nevét: ");
            var sor = Console.ReadLine();
            Console.WriteLine(bolygok.SingleOrDefault(b => b.Nev == sor) != null ?
                "Van ilyen bolgyó a naprendszerben." :
                "Sajnos nincsen ilyen bolygó a naprendszerben.");

            Console.Write("3.5: Írj be egy egész számot: ");
            var szam = int.Parse(Console.ReadLine());
            var tobbHold = bolygok.Where(b => b.HoldSzama > szam).Select(b => b.Nev).ToArray();
            Console.WriteLine($"a következő bolygóknak van {szam}-nál/nél több holdja:");
            foreach (var item in tobbHold)
            {
                Console.Write($"{item}, ");
            }


        } 
    }
}