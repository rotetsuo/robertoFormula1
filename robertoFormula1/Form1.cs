using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robertoFormula1
{
    public partial class Form1 : Form
    {

        double[] Tempos = new double[5];
        int i = 0;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tempos[i] = double.Parse(TxbTomadaTempo.Text);
            i++;
            TxbTomadaTempo.Text = null;
            if(i == 5)
            {
                MessageBox.Show("Tomada de Tempo cadastradas!");
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            TxbTomadaTempo.Text = null;
            txbMedia.Text = null;
            txbMelhorVolta.Text = null;
            txbPiorVolta.Text = null;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double somaTempos, media, melhorTempo, piorTempo;
            somaTempos = 0;
            melhorTempo= 0;
            piorTempo= 9999999;
            for(int j = 0; j < Tempos.Length; j++)
            {
                somaTempos += Tempos[j];
                if(melhorTempo < Tempos[j])
                {
                    melhorTempo= Tempos[j];
                }
                if (piorTempo > Tempos[j])
                {
                    piorTempo = Tempos[j];
                }

            }
            media = somaTempos/ Tempos.Length;
            txbMedia.Text = media.ToString();
            txbMelhorVolta.Text = melhorTempo.ToString();
            txbPiorVolta.Text = piorTempo.ToString();

        }
    }
}
