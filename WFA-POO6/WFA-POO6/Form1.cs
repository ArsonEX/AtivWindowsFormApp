using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MilhaQuilo mq;
            mq = new MilhaQuilo();

            mq.setMilhas(double.Parse(txtMilha.Text));

            mq.calcular();

            txtKm.Text = mq.getResultado().ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Clique para converter para Quilômetros.";
        }

        private void txtMilha_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Digite o valor em milhas náuticas.";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }
    }
}
