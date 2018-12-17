using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z, resultat;

            x = 3;
            y = 4;
            z = 5;

            Console.WriteLine("Les valeurs de X, Y et Z sont " + x + ", " + y + " et " + z);
            resultat = (x + y) * z;
            Console.WriteLine("Le résultat de '(X + Y) x Z' est " + resultat);
        }
    }
}
