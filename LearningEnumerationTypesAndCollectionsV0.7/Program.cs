using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Duck> ducks = new List<Duck>
            {
                new Duck() {Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() {Kind = KindOfDuck.Decoy , Size = 14},
                new Duck() {Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = KindOfDuck.Decoy, Size = 13},
            };

            //Sorting by using interface ICompareable<T>


            PrintDucks(ducks);

            Console.WriteLine("A teraz te same kaczki, ale posortowane względem rozmiaru:");
            ducks.Sort();
            PrintDucks(ducks);

            //Sorting by using interface IComparer<T> and this time comparing by kind not size.
            Console.WriteLine("\r\n" + "I znów te same kaczki, ale posortowane względem rodzaju:");
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            //Sorting by using interface IComparer<T> but this time comparing ducks firstly by size then by kind.
            Console.WriteLine("\r\n" + "Po raz ostatni te same kaczki, ale posortowane najpierw zględem rozmiaru, a później względem rodzaju:");
            DuckComparer duckComparer = new DuckComparer();
            duckComparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(duckComparer);
            PrintDucks(ducks);
            Console.ReadKey();
        }



        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck); //awesome, now this method looks way better. 
            }
            Console.WriteLine("\r\nKoniec kaczek!");
        }
    }
}
