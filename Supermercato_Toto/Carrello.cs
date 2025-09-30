using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            Prodotto nuovo = ap.Aggiunto;
            Prodotti.Add(nuovo);
            //MessageBox.Show(ap.Aggiunto.Nome.ToString());
            AggiornaData();
        }
    }
}
