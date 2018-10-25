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
            Produkt Produkt4 = new Produkt(1, "a", "aa", 10);
            Produkt Produkt3 = new Produkt(2, "b", "bb", 20);
            Produkt Produkt2 = new Produkt(3, "c", "cc", 30);
            Produkt Produkt1 = new Produkt(4, "d", "dd", 40);
            KoszJarek.DodajDoKoszyka(Produkt1);
            KoszJarek.DodajDoKoszyka(Produkt2);
            KoszJarek.DodajDoKoszyka(Produkt3);
            KoszJarek.DodajDoKoszyka(Produkt4);
            KoszJarek.WyswietlKoszyk();
            /*KoszJarek.UsunZKoszyka(3);
            KoszJarek.WyswietlKoszyk();*/
            Produkt1.PodajCene();
            KoszJarek.PodajCene();
            KoszJarek.SortujPoCenach();
            KoszJarek.WyswietlKoszyk();
            Console.ReadLine();
        }
    }
}
