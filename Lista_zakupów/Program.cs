using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Program:Koszyk
    {
        static void Main(string[] args)
        {
            Produkt Produkt1 = new Produkt(1, "a", "aa", 10);
            DodajDoKoszyka(MojKoszyk, 1, Produkt1);
            Produkt Produkt2 = new Produkt(2, "b", "bb", 20);
            DodajDoKoszyka(MojKoszyk, 2, Produkt2);
            Produkt Produkt3 = new Produkt(3, "c", "cc", 30);
            DodajDoKoszyka(MojKoszyk, 3, Produkt3);
            WyswietlZawartoscKoszyka();
            Console.WriteLine("");
            Produkt Produkt4 = new Produkt(4, "d", "dd", 40);
            DodajDoKoszyka(MojKoszyk, 4, Produkt4);
            WyswietlZawartoscKoszyka();


            Console.ReadLine();

        }
    }
}
