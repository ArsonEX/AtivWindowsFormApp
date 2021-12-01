using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtA.Text)<=0 || int.Parse(txtB.Text) <= 0 || int.Parse(txtC.Text) <= 0)
            {
                MessageBox.Show("Os valores dos lados devem ser positivos.");
            }
            else
            {
                FTriangulo ft;
                ft = new FTriangulo();

                ft.setA(int.Parse(txtA.Text));
                ft.setB(int.Parse(txtB.Text));
                ft.setC(int.Parse(txtC.Text));

                if (ft.triangular() == "Não")
                {
                    chkN.Checked = true;
                    chkS.Checked = false;
                    radNem.Checked = true;
                }
                else
                {
                    chkN.Checked = false;
                    chkS.Checked = true;
                    if (ft.triangular() == "equilátero")
                    {
                        radEqui.Checked = true;
                    }
                    else
                    {
                        if (ft.triangular() == "isosceles")
                        {
                            radIsos.Checked = true;
                        }
                        else
                        {
                            radEsca.Checked = true;
                        }
                    }
                }
            }
        }

        private void LimpDesc(object sender, EventArgs e)
        {
            lblDesc.Visible = false;
        }

        private void btnCalc_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Clique para calcular o triângulo formado.";
            lblDesc.Visible = true;
        }

        private void txtA_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite o valor do lado A.";
            lblDesc.Visible = true;
        }

        private void txtB_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite o valor do lado B.";
            lblDesc.Visible = true;
        }

        private void txtC_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite o valor do lado C.";
            lblDesc.Visible = true;
        }
    }
}
