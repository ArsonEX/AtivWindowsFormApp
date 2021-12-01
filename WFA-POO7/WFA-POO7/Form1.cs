using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtDolar.Text)<0 || double.Parse(txtCotacao.Text)<=0)
            {
                MessageBox.Show("O valor da cotação deve ser positivo.");
            }
            else
            {
                CotaDolar cd;
                cd = new CotaDolar();

                cd.setQuantia(double.Parse(txtDolar.Text));
                cd.setCotacao(double.Parse(txtCotacao.Text));

                cd.calcular();

                txtBRL.Text=cd.getResultado().ToString("##0.00");
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Clique para converter para Real.";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }

        private void txtDolar_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite o valor em dolar ($00,00).";
        }

        private void txtCotacao_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite a cotação Dolar/BRL.";
        }
    }
}
