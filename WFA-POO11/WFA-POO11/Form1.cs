using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtAltura.Text) > 2.7 || (double.Parse(txtAltura.Text) < 0.6 || 
                double.Parse(txtPeso.Text) > 600 || double.Parse(txtPeso.Text) < 27))
            {
                MessageBox.Show("Valores impossíveis, houve algum erro de formatação?");
            }
            else
            {
                IMC i;
                i = new IMC();

                i.setAltura(double.Parse(txtAltura.Text));
                i.setPeso(double.Parse(txtPeso.Text));

                i.calcular();

                txtRes.Text = i.getImc().ToString("##00.00");

                if (i.getImc() < 20)
                {
                    radMenor.Checked = true;
                }
                else
                {
                    if (i.getImc() >= 25)
                    {
                        radMaior.Checked = true;
                    }
                    else
                    {
                        radMedio.Checked = true;
                    }
                }
            }
        }

        private void LimpDesc(object sender, EventArgs e)
        {
            lblDesc.Visible = false;
        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Clique para calcular seu IMC.";
            lblDesc.Visible = true;
        }

        private void txtPeso_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite seu peso (00,00 Kg).";
            lblDesc.Visible = true;
        }

        private void txtAltura_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite sua altura (0,00 m).";
            lblDesc.Visible = true;
        }
    }
}
