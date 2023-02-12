using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cambioDeMoneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal monto = decimal.Parse(txtMonto.Text);
            decimal valorDolar = 3.82m;

            if (comboBox1.Text == "Soles" && comboBox2.Text == "Dolares")
            {

                decimal conversinon = decimal.Round(monto / valorDolar, 2);
                lblResultado.Text = conversinon.ToString();


            }
            else if (comboBox1.Text == "Dolares" && comboBox2.Text == "Soles")
            {
                decimal conversion = decimal.Round(monto * valorDolar, 3);
                lblResultado.Text = "valor: " + conversion.ToString();
            }

        }
    }
}
