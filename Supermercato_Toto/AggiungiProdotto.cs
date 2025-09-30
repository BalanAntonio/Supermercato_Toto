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
    public partial class AggiungiProdotto : Form
    {
        public AggiungiProdotto()
        {
            InitializeComponent();
        }

        List<Prodotto> p;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            string tutto = File.ReadAllText("Catalogo.json");
            p = JsonConvert.DeserializeObject<List<Prodotto>>(tutto);

            for(int i = 0; i < p.Count; i++)
            {
                cmb_prodotto.Items.Add(p[i].Nome.ToString());
            }
            cmb_prodotto.SelectedIndex = 0;
            cmb_prodotto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmb_prodotto_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < p.Count; i++)
            {
                if (p[i].Nome.ToString() == cmb_prodotto.SelectedItem.ToString())
                {
                    nmr_quantita.Maximum = p[i].Quantita;
                }
            }
        }
    }
}
