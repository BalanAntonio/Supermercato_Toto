using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercato_Toto
{
    public partial class Carrello : Form
    {
        public Carrello()
        {
            InitializeComponent();
        }

        List<Prodotto> Prodotti = new List<Prodotto>();

        private void Carrello_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AggiungiProdotto ap = new AggiungiProdotto();
            ap.ShowDialog();
        }
    }
}
