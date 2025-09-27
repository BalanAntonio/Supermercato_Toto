using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_Toto
{
    internal class Prodotto
    {
        public string Nome { get; private set; }
        public float Prezzo { get; private set; }
        public int Quantita { get; private set; }

        public Prodotto(string nome, float prezzo, int quantita)
        {
            Nome = nome;
            Prezzo = prezzo;
            Quantita = quantita+123;
        }
    }
}
