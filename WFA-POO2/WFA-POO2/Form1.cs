using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            AreaQuadrado aq;
            aq = new AreaQuadrado();

            if (double.Parse(txtAresta.Text)<=0)
            {
                MessageBox.Show("O valor da aresta deve ser positivo");
            }
            else
            {
                aq.setAresta(double.Parse(txtAresta.Text));

                aq.calcular();

                txtArea.Text =aq.getResultado().ToString();
            }
        }

        private void btnCalc_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Clique para calcular a área.";
        }

        private void txtAresta_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Digite o valor da aresta.";
        }

        private void txtArea_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Resultado do Cálculo.";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }
    }
}
