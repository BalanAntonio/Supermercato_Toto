using Newtonsoft.Json;
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

namespace Supermercato_Toto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AggiornaData()
        {
            string testo = File.ReadAllText("Catalogo.json");
            List<Prodotto> p = new List<Prodotto>();
            p = JsonConvert.DeserializeObject<List<Prodotto>>(testo);

            dtg_catalogo.DataSource = p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carrello c = new Carrello();
            c.ShowDialog();
            AggiornaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rifornisci r = new Rifornisci();
            r.ShowDialog();
            AggiornaData();
        }
    }
}
