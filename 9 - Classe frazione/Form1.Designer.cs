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
            this.sem_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num_box
            // 
            this.num_box.Location = new System.Drawing.Point(211, 186);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(81, 20);
            this.num_box.TabIndex = 0;
            // 
            // den_box
            // 
            this.den_box.Location = new System.Drawing.Point(211, 233);
            this.den_box.Name = "den_box";
            this.den_box.Size = new System.Drawing.Size(81, 20);
            this.den_box.TabIndex = 1;
            // 
            // ris_box
            // 
            this.ris_box.Location = new System.Drawing.Point(335, 208);
            this.ris_box.Name = "ris_box";
            this.ris_box.Size = new System.Drawing.Size(71, 20);
            this.ris_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // ad_btn
            // 
            this.ad_btn.Location = new System.Drawing.Point(444, 157);
            this.ad_btn.Name = "ad_btn";
            this.ad_btn.Size = new System.Drawing.Size(88, 23);
            this.ad_btn.TabIndex = 4;
            this.ad_btn.Text = "addizione";
            this.ad_btn.UseVisualStyleBackColor = true;
            this.ad_btn.Click += new System.EventHandler(this.ad_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.Location = new System.Drawing.Point(444, 246);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(88, 23);
            this.div_btn.TabIndex = 5;
            this.div_btn.Text = "divisione";
            this.div_btn.UseVisualStyleBackColor = true;
            // 
            // molt_btn
            // 
            this.molt_btn.Location = new System.Drawing.Point(444, 217);
            this.molt_btn.Name = "molt_btn";
            this.molt_btn.Size = new System.Drawing.Size(88, 23);
            this.molt_btn.TabIndex = 6;
            this.molt_btn.Text = "moltiplicazione";
            this.molt_btn.UseVisualStyleBackColor = true;
            // 
            // sot_btn
            // 
            this.sot_btn.Location = new System.Drawing.Point(444, 186);
            this.sot_btn.Name = "sot_btn";
            this.sot_btn.Size = new System.Drawing.Size(88, 23);
            this.sot_btn.TabIndex = 7;
            this.sot_btn.Text = "sottrazione";
            this.sot_btn.UseVisualStyleBackColor = true;
            this.sot_btn.Click += new System.EventHandler(this.sot_btn_Click);
            // 
            // sem_btn
            // 
            this.sem_btn.Location = new System.Drawing.Point(444, 128);
            this.sem_btn.Name = "sem_btn";
            this.sem_btn.Size = new System.Drawing.Size(88, 23);
            this.sem_btn.TabIndex = 8;
            this.sem_btn.Text = "semplifica";
            this.sem_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NUMERATORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DENOMINATORE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "RISULTATO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sem_btn);
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
        private System.Windows.Forms.Button sem_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

