using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            AreaDiagonal ad;
            ad = new AreaDiagonal();

            if (double.Parse(txtDiagonal.Text)<=0)
            {
                MessageBox.Show("O valor da diagonal deve ser positivo");
            }
            else
            {
                ad.setDiagonal(double.Parse(txtDiagonal.Text));

                ad.calcular();

                txtArea.Text = ad.getResultado().ToString();
            }
        }

        private void btnCalc_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Clique para calcular a área.";
        }

        private void txtDiagonal_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Digite o valor da diagonal.";
        }

        private void txtArea_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Resultado do calculo.";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }
    }
}
