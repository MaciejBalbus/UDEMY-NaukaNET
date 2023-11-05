internal class Program
{
    /// <summary>
    /// Komentarz do tworzenia dokumentacji; Tutaj opis
    /// </summary>
    /// <param name="args">tu opis parametru args</param>
    private static void Main(string[] args)
    {
        #region ToJestPoczatekRegionu;

        int rezultat;
        int x = 10;
        int y = 5;

        rezultat = (x + y);
        Console.WriteLine("Dodawanie x+y = " +rezultat);

        rezultat = (x - y);
        Console.WriteLine("Odejmowanie x-y = " + rezultat);

        rezultat = (x * y);
        Console.WriteLine("Mnożenie x*y = " + rezultat);

        rezultat = (x / y);
        Console.WriteLine("Dzielenie x/y = " + rezultat);

        rezultat = (x%y);
        Console.WriteLine("Modulo x%y = " + rezultat);

        rezultat = 2 + 2 * 5;
        Console.WriteLine("2 + 2 * 5 = " + rezultat);

        rezultat = (2 + 2) * 5;
        Console.WriteLine("(2 + 2) * 5 = " + rezultat);

        #endregion;

        Console.WriteLine("***************************************");

        int wartosc1 = 10;
        int wartosc2 = 10;

        Console.WriteLine("Pre-increment rezultat: ");
        Console.WriteLine(++wartosc1);

        Console.WriteLine("Post-increment rezultat: ");
        Console.WriteLine(wartosc2++);
        Console.WriteLine(wartosc2);

        Console.WriteLine("***************************************");

        bool boolRezultat;
        x = 2;
        y = 10;
        Console.WriteLine("x= " + x +"\ny= "+ y );

        boolRezultat = (x == y);
        Console.WriteLine("Operator porównania: (x == y) = " + boolRezultat);

        boolRezultat = (x > y);
        Console.WriteLine("Operator większy niż: (x > y) = " + boolRezultat);

        boolRezultat = (x < y);
        Console.WriteLine("Operator mniejszy niż: (x < y) = " + boolRezultat);

        boolRezultat = (x >= y);
        Console.WriteLine("Operator większy równy niż: (x >= y) = " + boolRezultat);

        boolRezultat = (x <= y);
        Console.WriteLine("Operator mniejszy równy niż: (x <= y) = " + boolRezultat);

        boolRezultat = (x != y);
        Console.WriteLine("Operator nieówny: (x != y) = " + boolRezultat);

        Console.WriteLine("***************************************");

        bool a = true;
        bool b = false;
        Console.WriteLine("AND a = " + a + "\nb = " + b);

        boolRezultat = a || b;
        Console.WriteLine("OR a || b = " + boolRezultat);

        boolRezultat = !a;
        Console.WriteLine("NOT !a = " + boolRezultat);

        Console.WriteLine("***************************************");

        x = 2;
        y = 10;
        Console.WriteLine("x= " + x + "\ny= " + y);

        int wiekszaLiczba;
        wiekszaLiczba = x>y ? x : y;
        Console.WriteLine("Wyrazenie trójelementowe x>y ? x : y; zwraca " + wiekszaLiczba);

        //Komentarze jednowierszowe;

        /*
         * komentarz wieloliniowy;
         * druga linia 
         */

        



    }
}