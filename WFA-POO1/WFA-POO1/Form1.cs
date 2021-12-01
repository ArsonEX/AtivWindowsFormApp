using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Area a;
            a = new Area();

            if (double.Parse(txtBase.Text) <= 0 || double.Parse(txtAltura.Text) <= 0)
            {
                MessageBox.Show("Os valores da base & altura devem ser números positivos!");
            }
            else
            {
                a.setBasinha(double.Parse(txtBase.Text));
                a.setAltura(double.Parse(txtAltura.Text));

                a.calcular();

                txtRes.Text = a.getResultado().ToString();
            }

        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text +=" Clique para calcular a área.";
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Text = "Descrição:";
        }

        private void txtBase_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += " Digite o valor da base.";
        }

        private void txtAltura_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text += "Digite o valor da altura.";
        }
    }
}
