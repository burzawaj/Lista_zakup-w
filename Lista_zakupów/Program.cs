using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produkt> KoszykJ = new List<Produkt>()
            {
            };
            Koszyk KoszJarek = new Koszyk(KoszykJ);
            Produkt Produkt5 = new Produkt(211, "e", "ee", 50);
            Produkt Produkt4 = new Produkt(111, "a", "aa", 10);
            Produkt Produkt3 = new Produkt(221, "b", "bb", 20);
            Produkt Produkt2 = new Produkt(332, "c", "cc", 30);
            Produkt Produkt1 = new Produkt(401, "d", "dd", 40);
            KoszJarek.DodajDoKoszyka(Produkt1);
            KoszJarek.DodajDoKoszyka(Produkt2);
            KoszJarek.DodajDoKoszyka(Produkt3);
            KoszJarek.DodajDoKoszyka(Produkt4);
            KoszJarek.DodajDoKoszyka(Produkt5);
            KoszJarek.WyswietlKoszyk();
            Produkt1.PodajCene();
            KoszJarek.PodajCene();
            KoszJarek.SortujPoCenach();
            KoszJarek.WyswietlKoszyk();
            Console.WriteLine("");
            KoszJarek.UsunZKoszyka(221);
            KoszJarek.WyswietlKoszyk();
            Console.ReadLine();
        }
    }
}
