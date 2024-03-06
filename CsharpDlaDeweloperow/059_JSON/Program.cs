using System.Diagnostics.Tracing;
using Newtonsoft.Json;

namespace _059_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gracz = new Gracz()
            {
                Nazwa = "Marian",
                Poziom = 1,
                PunktyZycia =100,
                Statystyki = new List<Statystyka>
                {
                    new Statystyka()
                    {
                        Name ="Sila",
                        Punkty= 10
                    },
                    new Statystyka()
                    {
                        Name = "Inteligencja",
                        Punkty= 10
                    }
                }

            };

            gracz.Poziom++;

            var GraczSeriaJson = JsonConvert.SerializeObject(gracz);
            File.WriteAllText(@"GraczSeriaJson.json", GraczSeriaJson);


            var WczytanyGraczString = File.ReadAllText(@"GraczSeriaJson.json");
            Gracz WczytanyGracz = JsonConvert.DeserializeObject<Gracz>(WczytanyGraczString);
        }
    }
}
