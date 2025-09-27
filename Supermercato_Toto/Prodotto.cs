using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermercato_Toto
{
    internal class Prodotto
    {
        //public string Nome { get; private set; }
        public enum Nomi { Pane, Latte, Uova, Burro, Formaggio, Yogurt, Pasta, Riso, Farina, Zucchero, Sale, Aceto, Pomodori, Insalata, Carote, Patate, Cipolle, Mele, Banane, Arance, Limoni, Pollo, Manzo, Pesce, Prosciutto, Salame, Fagioli, Ceci, Lenticchie, Caffe, Te, Cioccolato, Biscotti, Marmellata, Miele, Acqua, Vino, Birra, Ketchup, Maionese, Senape, Spezie, Gelato, Detergente, Shampoo, Detersivo, Sapone, Tovaglioli }
        public Nomi Nome;
        public float Prezzo { get; private set; }
        public int Quantita { get; private set; }

        public Prodotto(int nome, float prezzo, int quantita)
        {
            Nome = (Nomi)nome;
            Prezzo = prezzo;
            Quantita = quantita;
        }
    }
}
