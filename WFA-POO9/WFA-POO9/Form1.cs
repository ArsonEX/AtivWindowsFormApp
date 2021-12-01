using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            MaiorIgual m;
            m = new MaiorIgual();

            m.setn1(int.Parse(txtN1.Text));
            m.setn2(int.Parse(txtN2.Text));

            if (m.indicarMaior()==0)
            {
                txtMaior.Text = "Números iguais";
            }
            else
            {
                if (m.indicarMaior() == 1)
                {
                    txtMaior.Text = m.getn1().ToString() + " (Primeiro)";
                }
                else
                {
                    txtMaior.Text = m.getn2().ToString() + " (Segundo)"; ;
                }
            }
        }

        private void LimpDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }

        private void btnDet_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Clique para determinar o maior número.";
        }

        private void txtN1_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite o primeiro número.";
        }

        private void txtN2_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite o segundo número.";
        }
    }
}
