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
        internal Prodotto Aggiunto { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string tutto = File.ReadAllText("Catalogo.json");
            p = JsonConvert.DeserializeObject<List<Prodotto>>(tutto);

            for(int i = 0; i < p.Count; i++)
            {
                if (p[i].Quantita > 0) { //aggiungi i prodotti disponibili alla combobox
                    cmb_prodotto.Items.Add(p[i].Nome.ToString());
                }
                
            }
            cmb_prodotto.SelectedIndex = 0; //seleziona di default il primo elemento
            cmb_prodotto.DropDownStyle = ComboBoxStyle.DropDownList; //disabilita la funzionalita di scrivere dentro la combobox
        }

        private void cmb_prodotto_SelectedIndexChanged(object sender, EventArgs e)
        {// quando l'utente cambia prodotto nella combobox viene cambiato il valore massimo che si puo inserire nel numeric 
            for(int i = 0; i < p.Count; i++)
            {
                if (p[i].Nome.ToString() == cmb_prodotto.SelectedItem.ToString())
                {
                    nmr_quantita.Maximum = p[i].Quantita;
                }
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Aggiunto = new Prodotto(IdProdotto(cmb_prodotto.SelectedItem.ToString()), p[IdProdotto(cmb_prodotto.SelectedItem.ToString())].Prezzo * (float)nmr_quantita.Value, (int)nmr_quantita.Value);
            p[IdProdotto(cmb_prodotto.SelectedItem.ToString())].Quantita -= (int)nmr_quantita.Value;
            AggiornaJSON();
            this.Close();
        }
    }
}
