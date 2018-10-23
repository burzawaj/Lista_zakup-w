using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Koszyk
    {
        static public Dictionary<int, Produkt> MojKoszyk = new Dictionary<int, Produkt>()
        {

        };
        public static void DodajDoKoszyka(Dictionary<int, Produkt> MojKoszyk, int klucz, Produkt nowyProdukt)
        {
            MojKoszyk.Add(klucz, nowyProdukt);
        }
        public static void WyswietlZawartoscKoszyka()
        {
            int aPomoc = 0;
            foreach (var item in MojKoszyk)
            {
                aPomoc = aPomoc + 1;
                Console.WriteLine($"Numer produktu: { MojKoszyk[aPomoc].NumerProduktu} Nazwa produktu: {MojKoszyk[aPomoc].Nazwa} Opis produktu: {MojKoszyk[aPomoc].OpisProduktu} Cena: {MojKoszyk[aPomoc].Cena}");
            }

        }
    }
}
