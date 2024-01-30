using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9___Classe_frazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ad_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num_box.Text) || string.IsNullOrEmpty(den_box.Text))
            {
                MessageBox.Show("Non hai inserito nulla!");
            }
            else
            {
                int n = Convert.ToInt16(num_box.Text);
                int d = Convert.ToInt16(den_box.Text);
                Frazione frazione = new Frazione(n, d);
                ris_box.Text = frazione.somma(n, d).ToString();
            }
        }

        private void sot_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num_box.Text) || string.IsNullOrEmpty(den_box.Text))
            {
                MessageBox.Show("Non hai inserito nulla!");
            }
            else
            {
                int n = Convert.ToInt16(num_box.Text);
                int d = Convert.ToInt16(den_box.Text);
                Frazione frazione = new Frazione(n, d);
                ris_box.Text = frazione.sottrai(n, d).ToString();
            }
        }

        private void molt_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num_box.Text) || string.IsNullOrEmpty(den_box.Text))
            {
                MessageBox.Show("Non hai inserito nulla!");
            }
            else
            {
                int n = Convert.ToInt16(num_box.Text);
                int d = Convert.ToInt16(den_box.Text);
                Frazione frazione = new Frazione(n, d);
                ris_box.Text = frazione.moltiplica(n, d).ToString();
            }
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num_box.Text) || string.IsNullOrEmpty(den_box.Text))
            {
                MessageBox.Show("Non hai inserito nulla!");
            }
            else
            {
                int n = Convert.ToInt16(num_box.Text);
                int d = Convert.ToInt16(den_box.Text);
                Frazione frazione = new Frazione(n, d);
                ris_box.Text = frazione.divisione(n, d).ToString();
            }
        }

        private void sem_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num_box.Text) || string.IsNullOrEmpty(den_box.Text))
            {
                MessageBox.Show("Non hai inserito nulla!");
            }
            else
            {
                int n = Convert.ToInt16(num_box.Text);
                int d = Convert.ToInt16(den_box.Text);
                Frazione frazione = new Frazione(n, d);
                frazione.Semplificazione();
                ris_box.Text = $"{frazione.Numeratore} / {frazione.Denominatore}";
            }
        }
    }
    class Frazione
    {
        private int numeratore;
        private int denominatore;
        
        public int Numeratore
        {
            get { return numeratore; }
            set { numeratore = value; }
        }
        public int Denominatore
        {
            get { return denominatore; }
            set { denominatore = value; }
        }
        public Frazione(int num, int den)
        {
            Numeratore = num;
            Denominatore = den;
        }

        public void Semplificazione()
        {
            int p = mcd(Numeratore, Denominatore);
            Numeratore /= p;
            Denominatore /= p;
            
        }
        public int mcd(int n, int d)
        {
            while(d != 0)
            {
                int t = d;
                d = n % d;
                n = t;
            }
            return n;
        }
        public int somma(int n, int d)
        {
            int s = n + d;
            return s;
        }
        public int sottrai(int n, int d)
        {
            int s = n - d;
            return s;
        }
        public int moltiplica(int n, int d)
        {
            int s = n * d;
            return s;
        }
        public float divisione(float n, float d)
        {
            float s = n / d;
            return s;
        }
    }
}
