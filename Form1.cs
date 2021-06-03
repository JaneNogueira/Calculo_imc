using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
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

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            /*variável recebe os valores digitados no textbox
             * Essa é a declaração de variável*/

            double peso, altura, imc;
            peso = Convert.ToDouble(TxtCaixa1.Text);
            altura = Convert.ToDouble(TxtCaixa2.Text);
            imc = peso / (altura * altura);

            /*a textbox 3 recebe o valor do resultado da divisão da altura dividida por duas vezes o peso. */

            TxtIMC.Text = imc.ToString("0.00");
            /*a partir desse momento, serão criadas condições com uma série de ifs para que 
             * as informações do imc sejam exibidas.
             * Teremos agora a configuração das messageBox a partir dos ifs*/

            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do peso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está no peso ideal", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está com sobrepeso", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso com obesidade Grau 1", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do peso com obesidade Grave Grau 2", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("SITUAÇÃO: Você está acima do peso com obesidade Mórbida Grau 3", "Cálculo IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);



        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCaixa1.Text =  "";
            TxtCaixa2.Text =  "";
            TxtIMC.Text = "";


        }

        private void TxtCaixa1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
