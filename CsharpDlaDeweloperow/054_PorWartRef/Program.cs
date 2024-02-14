namespace _054_PorWartRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HP1 = 350;
            int HP2 = 350;

            Samochod samochod1 = new(HP1);
            Samochod samochod2 = new(HP2);

            bool porownanieTypWartosciowy = HP1 == HP2;
            Console.WriteLine("HP1==HP2: "+porownanieTypWartosciowy);

            bool porownanieTypReferencyjny = samochod1 == samochod2;
            Console.WriteLine("samochod1 == samochod2: " + porownanieTypReferencyjny);

            porownanieTypReferencyjny = samochod1.Equals(samochod2);
            Console.WriteLine("samochod1.Equals(samochod2): " + porownanieTypReferencyjny);


        }
    }

    class Samochod
    {
        public Samochod(int KonieMechaniczne)
        {
            this.KonieMechaniczne = KonieMechaniczne;
        }

        public int KonieMechaniczne { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;

            Samochod samochodObj = (Samochod)obj;
            return this.KonieMechaniczne == samochodObj.KonieMechaniczne;
        }
        public static bool operator == (Samochod lewy,Samochod prawy)
        {
            return Equals(lewy, prawy); 
        }
        public static bool operator !=(Samochod lewy, Samochod prawy)
        {
            return !Equals(lewy, prawy);
        }
    }
}
