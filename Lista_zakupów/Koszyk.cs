using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Koszyk:ICeny
    {
        List<Produkt> mojKoszyk;
        public Koszyk()
        {
            mojKoszyk = new List<Produkt>();   
        }
        public void DodajDoKoszyka(Produkt NowyProdukt)
        {
            mojKoszyk.Add(NowyProdukt);
        }
        public void WyswietlKoszyk()
        {
            Console.WriteLine("W koszyku mamy:");
            for (int i = 0; i < mojKoszyk.Count; i++)
            {
                Console.WriteLine($"Kod produktu: {mojKoszyk[i].KodProduktu} Nazwa produktu : {mojKoszyk[i].Nazwa} Opis produktu : {mojKoszyk[i].OpisProduktu} Cena: {mojKoszyk[i].Cena} zł ");
            }   

        }
        public void UsunZKoszyka(uint _kodUsuwanego)
        {
            for (int i = 0; i < mojKoszyk.Count; i++)
            {
                if (mojKoszyk[i].KodProduktu == _kodUsuwanego)
                {
                    mojKoszyk.RemoveAt(i);
                }   
            }

        }

        public virtual void PodajCene()
        {
            decimal _sumaCen = 0;
            for (int i = 0; i < mojKoszyk.Count; i++)
            {
                _sumaCen = _sumaCen + mojKoszyk[i].Cena;
                
            }
            Console.WriteLine($"Wartość koszyka wynosi: {_sumaCen}");

        }
        public void SortujPoCenach()
        {
            mojKoszyk.Sort();
        }
        public void PodsumujKoszyk()
        {
            SortujPoCenach();
            WyswietlKoszyk();
            PodajCene();

        }

    }

}
