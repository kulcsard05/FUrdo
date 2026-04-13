 namespace StrandC
{
    public class Program
    {


        public static int IRSZ(string input)
        {
            int split = int.Parse(input.Split(' ')[0]);
            return split;
        }

        static void Main(string[] args)
        {
            List<Furdo> lista = new List<Furdo>();
            String[] Sorok = File.ReadAllLines("strandadatok.txt");
            foreach (String s in Sorok.Skip(1))
            {
                lista.Add(new Furdo(s));
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("7.feladat");
            Console.WriteLine(lista.Count);
            Console.WriteLine("----------------------");
            Console.WriteLine("8.feladat");
            Console.WriteLine(Math.Round(lista.Average(x => x.Ar), 1));
            Console.WriteLine("----------------------");
            Console.WriteLine("9.feladat");
            Console.WriteLine(lista.MinBy(x => x.Vizhofok).Nev);
            Console.WriteLine("----------------------");
            Console.WriteLine("10.feladat");
            Console.WriteLine("Adj meg egy fürdő nevet: ");
            string input = Console.ReadLine();
            Furdo Talalat = lista.Find(x => x.Nev == input);
            if (Talalat != null)
            {
                Console.WriteLine(IRSZ(Talalat.Cim));
                Console.WriteLine(Talalat.Telepules());
            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű fürdő!");
            }
            Console.WriteLine("----------------------");


        }
    }
}
