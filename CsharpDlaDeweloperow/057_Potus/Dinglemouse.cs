using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Potus
{
    public struct Punkt
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    public class Dinglemouse
    {
        public static bool AllAlone(char[][] house)
        {
            Punkt potus =default;

            for (int i = 0;i<house.GetLength(0);i++)
            {
                for(int j = 0; j < house[i].Length; j++)
                {
                    if (house[i][j] == 'X')
                    {
                        potus = new Punkt(i, j);
                    }
                }

                
            }
            var zeskanowanePunkty = new List<Punkt>();
            var nieJestSam = Scaner(potus,house,zeskanowanePunkty);
            return !nieJestSam;
        }

        public static bool Scaner(Punkt punkt, char[][] house, List<Punkt> zeskanowanePunkty)
        {
            if (zeskanowanePunkty.Contains(punkt))
            {
                return false;
            }

            zeskanowanePunkty.Add(punkt);

            if (house[punkt.X][punkt.Y] == 'o')
            {
                return true;
            }

            if (house[punkt.X][punkt.Y] == '#')
            {
                return false;
            }

            var punktUP = new Punkt(punkt.X, punkt.Y-1);
            var punktDOWN = new Punkt(punkt.X, punkt.Y+1);
            var punktLEFT = new Punkt(punkt.X-1, punkt.Y);
            var punktRIGHT = new Punkt(punkt.X+1, punkt.Y);

            return Scaner(punktUP, house, zeskanowanePunkty) ||
                Scaner(punktDOWN, house, zeskanowanePunkty) ||
                Scaner(punktLEFT, house, zeskanowanePunkty) ||
                Scaner(punktRIGHT, house, zeskanowanePunkty);






        }
    }
}
