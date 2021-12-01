using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_POO10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(double.Parse(txtBase.Text)<=0 || double.Parse(txtAltura.Text) <= 0)
            {
                MessageBox.Show("Os valores devem ser positivos.");
            }
            else
            {
                Terreno t;
                t = new Terreno();

                t.setAltura(double.Parse(txtAltura.Text));
                t.setBasin(double.Parse(txtBase.Text));

                t.calcular();

                txtRes.Text = t.getArea().ToString();
                if (t.getArea()>100)
                {
                    radTerG.Checked = true;
                }
                else
                {
                    radTerP.Checked = true;
                }
            }
            
        }

        private void LimparDesc(object sender, EventArgs e)
        {
            lblDesc.Visible = false;
        }

        private void btnCalcular_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Clique para calcular a área.";
            lblDesc.Visible = true;
        }

        private void txtAltura_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite a altura do retângulo.";
            lblDesc.Visible = true;
        }

        private void txtBase_MouseEnter(object sender, EventArgs e)
        {
            lblDesc.Text = "Digite a base do retângulo.";
            lblDesc.Visible = true;
        }
    }
}
