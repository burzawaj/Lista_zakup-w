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
                Console.WriteLine($"Kod produktu: {MojKoszyk[i].KodProduktu} Nazwa produktu : {MojKoszyk[i].Nazwa} Opis produktu : {MojKoszyk[i].OpisProduktu} Cena: {MojKoszyk[i].Cena} zł ");
            }

        }
        public void UsunZKoszyka(uint _kodUsuwanego)
        {
            for (int i = 0; i < MojKoszyk.Count; i++)
            {
                if (MojKoszyk[i].KodProduktu == _kodUsuwanego)
                {
                    MojKoszyk.RemoveAt(i);
                }   
            }

        }
    }

}
