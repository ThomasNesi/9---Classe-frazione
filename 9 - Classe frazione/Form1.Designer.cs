namespace _9___Classe_frazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.num_box = new System.Windows.Forms.TextBox();
            this.den_box = new System.Windows.Forms.TextBox();
            this.ris_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ad_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.molt_btn = new System.Windows.Forms.Button();
            this.sot_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_box
            // 
            this.num_box.Location = new System.Drawing.Point(211, 189);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(60, 20);
            this.num_box.TabIndex = 0;
            this.num_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // den_box
            // 
            this.den_box.Location = new System.Drawing.Point(211, 233);
            this.den_box.Name = "den_box";
            this.den_box.Size = new System.Drawing.Size(60, 20);
            this.den_box.TabIndex = 1;
            // 
            // ris_box
            // 
            this.ris_box.Location = new System.Drawing.Point(320, 208);
            this.ris_box.Name = "ris_box";
            this.ris_box.Size = new System.Drawing.Size(60, 20);
            this.ris_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // ad_btn
            // 
            this.ad_btn.Location = new System.Drawing.Point(444, 143);
            this.ad_btn.Name = "ad_btn";
            this.ad_btn.Size = new System.Drawing.Size(88, 23);
            this.ad_btn.TabIndex = 4;
            this.ad_btn.Text = "addizione";
            this.ad_btn.UseVisualStyleBackColor = true;
            // 
            // div_btn
            // 
            this.div_btn.Location = new System.Drawing.Point(444, 230);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(88, 23);
            this.div_btn.TabIndex = 5;
            this.div_btn.Text = "divisione";
            this.div_btn.UseVisualStyleBackColor = true;
            // 
            // molt_btn
            // 
            this.molt_btn.Location = new System.Drawing.Point(444, 201);
            this.molt_btn.Name = "molt_btn";
            this.molt_btn.Size = new System.Drawing.Size(88, 23);
            this.molt_btn.TabIndex = 6;
            this.molt_btn.Text = "moltiplicazione";
            this.molt_btn.UseVisualStyleBackColor = true;
            // 
            // sot_btn
            // 
            this.sot_btn.Location = new System.Drawing.Point(444, 172);
            this.sot_btn.Name = "sot_btn";
            this.sot_btn.Size = new System.Drawing.Size(88, 23);
            this.sot_btn.TabIndex = 7;
            this.sot_btn.Text = "sottrazione";
            this.sot_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sot_btn);
            this.Controls.Add(this.molt_btn);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.ad_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ris_box);
            this.Controls.Add(this.den_box);
            this.Controls.Add(this.num_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_box;
        private System.Windows.Forms.TextBox den_box;
        private System.Windows.Forms.TextBox ris_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ad_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button molt_btn;
        private System.Windows.Forms.Button sot_btn;
    }
}

