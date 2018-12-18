using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau_8
{
    class Program
    {
        enum week {Lundi=1/* =1 pour assigner l'indice 1 à lundi */, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche};

        static void Main(string[] args)
        {
            week lundi = week.Lundi;
            Console.WriteLine(lundi);
            week mardi = week.Mardi;
            Console.WriteLine(mardi);
            week mercredi = week.Mercredi;
            Console.WriteLine(mercredi);
            week jeudi = week.Jeudi;
            Console.WriteLine(jeudi);
            week vendredi = week.Vendredi;
            Console.WriteLine(vendredi);
            week samedi = week.Samedi;
            Console.WriteLine(samedi);
            week dimanche = week.Dimanche;
            Console.WriteLine(dimanche);

            Console.WriteLine(Enum.GetName(typeof(week),4));// afficher un élément d'une énumération suivant son indice, à savoir 4
        }
    }
}
