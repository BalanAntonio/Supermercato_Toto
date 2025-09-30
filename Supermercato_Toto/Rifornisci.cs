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
    public partial class Rifornisci : Form
    {
        public Rifornisci()
        {
            InitializeComponent();
        }

        List<Prodotto> p;

        private void Rifornisci_Load(object sender, EventArgs e)
        {
            string tutto = File.ReadAllText("Catalogo.json");
            p = JsonConvert.DeserializeObject<List<Prodotto>>(tutto);

            for (int i = 0; i < p.Count; i++)
            {
                //aggiungi i prodotti disponibili alla combobox
                cmb_prodotto.Items.Add(p[i].Nome.ToString());
            }
            cmb_prodotto.SelectedIndex = 0; //seleziona di default il primo elemento
            cmb_prodotto.DropDownStyle = ComboBoxStyle.DropDownList; //disabilita la funzionalita di scrivere dentro la combobox
        }

        private int IdProdotto(string nome)
        {
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].Nome.ToString() == nome) { return i; }
            }
            return -1;
        }

        private void AggiornaJSON()
        {
            string convertito = JsonConvert.SerializeObject(p, Formatting.Indented);
            File.WriteAllText("Catalogo.json", convertito);
        }

        private void btn_rifornisci_Click(object sender, EventArgs e)
        {
            p[IdProdotto(cmb_prodotto.SelectedItem.ToString())].Quantita += (int)nmr_quantita.Value;
            AggiornaJSON();
            this.Close();
        }
    }
}
