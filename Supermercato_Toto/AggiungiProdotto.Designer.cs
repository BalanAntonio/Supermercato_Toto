namespace Supermercato_Toto
{
    partial class AggiungiProdotto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_prodotto = new System.Windows.Forms.ComboBox();
            this.nmr_quantita = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantita)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aggiungi prodotto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodotto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_prodotto
            // 
            this.cmb_prodotto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_prodotto.FormattingEnabled = true;
            this.cmb_prodotto.Location = new System.Drawing.Point(178, 89);
            this.cmb_prodotto.Name = "cmb_prodotto";
            this.cmb_prodotto.Size = new System.Drawing.Size(171, 24);
            this.cmb_prodotto.TabIndex = 4;
            this.cmb_prodotto.SelectedIndexChanged += new System.EventHandler(this.cmb_prodotto_SelectedIndexChanged);
            // 
            // nmr_quantita
            // 
            this.nmr_quantita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nmr_quantita.Location = new System.Drawing.Point(178, 136);
            this.nmr_quantita.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_quantita.Name = "nmr_quantita";
            this.nmr_quantita.Size = new System.Drawing.Size(171, 23);
            this.nmr_quantita.TabIndex = 5;
            this.nmr_quantita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantità:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AggiungiProdotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmr_quantita);
            this.Controls.Add(this.cmb_prodotto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AggiungiProdotto";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_prodotto;
        private System.Windows.Forms.NumericUpDown nmr_quantita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}