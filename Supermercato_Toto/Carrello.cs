using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Supermercato_Toto
{
    public partial class Carrello : Form
    {
        public Carrello()
        {
            InitializeComponent();
        }

        static List<Prodotto> Prodotti = new List<Prodotto>();

        private void AggiornaData()
        {
            dtg_catalogo.DataSource = null;
            dtg_catalogo.DataSource = Prodotti;
        }

        private void Carrello_Load(object sender, EventArgs e)
        {
            AggiornaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggiungiProdotto ap = new AggiungiProdotto();
            ap.ShowDialog();
            if (!(ap.DialogResult == DialogResult.OK)) { return; }
            Prodotto nuovo = ap.Aggiunto;
            Prodotti.Add(nuovo);
            //MessageBox.Show(ap.Aggiunto.Nome.ToString());
            AggiornaData();
        }

        private void button2_Click(object sender, EventArgs e)//stampa del scontrino
        {
            if (Prodotti.Count == 0)
            {
                MessageBox.Show("Nessun prodotto inserito nel carrello");
                return;
            }

            string finale = "------------Scontrino------------\n\n";
            float totale = 0f;
            for(int i = 0; i< Prodotti.Count; i++)
            {
                finale += $"{Prodotti[i].Nome.ToString()} x {Prodotti[i].Quantita}\t\tPrezzo: {Prodotti[i].Prezzo}\n";
                totale += Prodotti[i].Prezzo;
            }
            finale += $"\nTotale da pagare: {totale} euro";

            PrintDocument ptrDoc = new PrintDocument();
            ptrDoc.DocumentName = $"Scontrino {DateTime.Now:T}";

            ptrDoc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(finale.ToString(), new Font("Consolas", 10),
                    Brushes.Black, 10, 10);
            };

            PrintDialog ptrDialog = new PrintDialog();
            ptrDialog.Document = ptrDoc;

            if (ptrDialog.ShowDialog() == DialogResult.OK)
            {
                ptrDoc.Print();
            }
        }
    }
}
