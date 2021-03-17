using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecCalc
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textValor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMenos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse (textValor1.Text);
            valor2 = double.Parse(textValor2.Text);
            if(rbSoma.Checked)
            {
                resultado = valor1 + valor2;
                textResu.Text = resultado.ToString();
            }

            if (rbMenos.Checked)
            {
                resultado = valor1 - valor2;
                textResu.Text = resultado.ToString();
            }

            if (rbMulti.Checked)
            {
                resultado = valor1 * valor2;
                textResu.Text = resultado.ToString();
            }

            if (rbDiv.Checked)
            {
                resultado = valor1 / valor2;
                textResu.Text = resultado.ToString();
            }

            if (rbResto.Checked)
            {
                resultado = valor1 % valor2;
                textResu.Text = resultado.ToString();
            }
        }
    }
}
