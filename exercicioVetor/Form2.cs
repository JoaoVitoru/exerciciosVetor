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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[15];
            int i;
            Random randomNumber = new Random();
            for(i=0; i<15; i++)
            {
                vetor[i] = randomNumber.Next(1,99);
                if (i % 2 == 0)
                {
                    txtVetorPar.Text += vetor[i].ToString() + " ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVetorPar.Clear();
        }
    }
}
