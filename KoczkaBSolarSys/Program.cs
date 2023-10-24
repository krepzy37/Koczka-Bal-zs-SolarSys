using System.Text;
namespace KoczkaBSolarSys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> bolygok = new();
            using StreamReader sr = new(@"..\..\..\src\solsys.txt", Encoding.UTF8);
            while (!sr.EndOfStream) bolygok.Add(new Bolygo(sr.ReadLine()));
            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a naprendszerben");
            var atlag = bolygok.Average(p=>p.HoldSzam);
            Console.WriteLine($"3.2: a naprendszerbena bolygóknak átlagosan {atlag} holdjuk van");
            var legnagyobb = bolygok.Max(p=>p.TerfogatFoldhoz);
            Console.WriteLine($"3.3: a legnagyobb térfogatú bolygó a {legnagyobb}");
            Console.Write("írd be a keresett bolygó nevét: ");
            string kertbolygo = Console.ReadLine();
            var keresett = bolygok.Where(p => p.Nev);
            if ()

        }
        
        
    }
}