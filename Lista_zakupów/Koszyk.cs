using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Koszyk:ICeny
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

        public virtual void PodajCene()
        {
            decimal _sumaCen = 0;
            for (int i = 0; i < MojKoszyk.Count; i++)
            {
                _sumaCen = _sumaCen + MojKoszyk[i].Cena;
                
            }
            Console.WriteLine($"Wartość koszyka wynosi: {_sumaCen}");

        }
        public void SortujPoCenach()
        {
            MojKoszyk.Sort();
        }
    }

}
