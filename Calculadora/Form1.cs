using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string Sinal = ""; 
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void buttonNumero1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void buttonNumero2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void buttonNumero3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void buttonNumero4_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void buttonNumero5_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void buttonNumero6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void buttonNumero7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void buttonNumero8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void buttonSinalMais_Click(object sender, EventArgs e)
        {
           if(textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                Sinal = "Soma";
                label1.Text = "+";
            }
        }

        private void buttonSinalIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);

            if(Sinal == "Soma")
            {
                textBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (Sinal == "subtracao")
            {
                textBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (Sinal == "multiplicacao")
            {
                textBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                textBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void buttonSinalMenos_Click(object sender, EventArgs e)
        {
            if(textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                Sinal = "subtracao";
                label1.Text = "-";
            }
        }

        private void buttonSinalVezes_Click(object sender, EventArgs e)
        {
            if(textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                Sinal = "multiplicacao";
                label1.Text = "*";
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
           if(textBoxResultado.Text != "")
           {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                Sinal = "divisao";
                label1.Text = "%";
           }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            //label1.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void buttonNumero9_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }
    }
}
