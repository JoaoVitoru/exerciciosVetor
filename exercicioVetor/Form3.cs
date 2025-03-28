using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioVetor
{
    public partial class frmexercicio2 : Form
    {
        int i, soma = 0, x, contador=30;
        int[] vetorNotas = new int[30];
        public frmexercicio2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtmedia.Clear();
            txtnota.Clear();
            soma = 0;
            contador = 30;
            lblnotarest.Text = "(" + contador.ToString() + ")";
            txtnota.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            txtmedia.Text = (soma / 30).ToString();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                contador = contador - 1;
                for (i = 0; i < 30; i++)
                {
                    x = Convert.ToInt32(txtnota.Text);
                    vetorNotas[i] = x;
                    soma = soma + vetorNotas[i];
                    txtnota.Clear();
                    txtnota.Focus();
                    break;
                }
                lblnotarest.Text = "(" + contador.ToString() + ")";
             }
        }
    }
}
