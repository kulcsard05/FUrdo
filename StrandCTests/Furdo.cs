namespace StrandC
{
    internal class Furdo
    {


        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int Ar { get; private set; }
        public int Vizhofok { get; private set; }

        public Furdo(string input)
        {
            string[] adatok = input.Split(';');
            Nev = adatok[0];
            Cim = adatok[1];
            Ar = int.Parse(adatok[2]);
            Vizhofok = int.Parse(adatok[3]);
        }



        public override string? ToString()
        {
            return $"{Nev}-{Cim}-{Ar}-{Vizhofok}";
        }

        public  string Telepules()
        {
            string adat = Cim.Split(' ')[1].Trim(',');
            return adat;
        }
    }

}
