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
        Frazione frazione = new Frazione();
        public Form1()
        {
            InitializeComponent();
        }

        private void ad_btn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(num_box.Text);
            int d = Convert.ToInt16(den_box.Text);
            ris_box.Text = frazione.somma(n, d).ToString();
        }

        private void sot_btn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt16(num_box.Text);
            int d = Convert.ToInt16(den_box.Text);
            ris_box.Text = frazione.sottrai(n, d).ToString();
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
        public Frazione()
        {
            numeratore = 0;
            denominatore = 0;
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
        public int moltiplica(int num)
        {
            return numeratore;
        }
        public int divisione(int num)
        {
            return denominatore;
        }
    }
}
