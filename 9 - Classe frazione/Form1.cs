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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class frazione
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
        public frazione()
        {
            numeratore = 0;
            denominatore = 0;
        }

        public int somma()
        {
            return numeratore;
        }
        public int sottrai()
        {
            return denominatore;
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
