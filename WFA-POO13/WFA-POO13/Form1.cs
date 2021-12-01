using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtA.Text) <= 0 || int.Parse(txtB.Text) <= 0 || int.Parse(txtC.Text) <= 0)
            {
                MessageBox.Show("Os valores dos lados devem ser positivos.");
            }
            else
            {
                TriRetan tr;
                tr = new TriRetan();

                tr.setA(int.Parse(txtA.Text));
                tr.setB(int.Parse(txtB.Text));
                tr.setC(int.Parse(txtC.Text));

                if (tr.trianguloRetangular()==0)
                {
                    chkN.Checked = true;
                    chkS.Checked = false;
                }
                else
                {
                    chkN.Checked = false;
                    chkS.Checked = true;
                }
            }
        }

        private void LimpDesc(object sender, EventArgs e)
        {
            lblDesc.Visible = false;
        }

        private void btnCalc_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Clique para checar o triângulo formado.";
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
