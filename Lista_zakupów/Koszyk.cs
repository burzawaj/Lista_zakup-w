using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Koszyk
    {
        public List<Produkt> MojKoszyk { get; private set; }
        public Koszyk (List<Produkt> mojKoszyk)
        {
            MojKoszyk = mojKoszyk;
        }
        public void DodajDoKoszyka(Produkt NowyProdukt)
        {
            MojKoszyk.Add(NowyProdukt);
        }
        public void WyswietlKoszyk()
        {
            Console.WriteLine("W koszyku mamy:");
            for (int i = 0; i < MojKoszyk.Count; i++)
            {
                Console.WriteLine($"Numer produktu: {MojKoszyk[i].NumerProduktu} Nazwa produktu : {MojKoszyk[i].Nazwa} Opis produktu : {MojKoszyk[i].OpisProduktu} Cena: {MojKoszyk[i].Cena} zł ");
            }

        }
    }

}
