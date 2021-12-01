using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDet_Click(object sender, EventArgs e)
        {
            Maior m;
            m = new Maior();

            m.setn1(int.Parse(txtN1.Text));
            m.setn2(int.Parse(txtN2.Text));

            txtMaior.Text = m.indicarMaior().ToString() + " ("+m.getns()+")";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text ="Descrição:";
        }

        private void txtN1_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite o primeiro número.";
        }

        private void txtN2_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Digite o segundo número.";
        }

        private void btnDet_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição: Clique para determinar o maior.";
        }
    }
}
