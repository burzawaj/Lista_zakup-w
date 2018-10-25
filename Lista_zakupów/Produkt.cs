﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupów
{
    class Produkt
    {
        public decimal Cena { get; private set; }
        public uint KodProduktu { get; private set; }
        public string Nazwa { get; private set; }
        public string OpisProduktu { get; private set; }

        public Produkt(uint _kodProduktu, string _nazwa, string _opis, decimal _cena)
        {
            KodProduktu = _kodProduktu;
            Nazwa = _nazwa;
            Cena = _cena;
            OpisProduktu = _opis;
        }
    }
}
