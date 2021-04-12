using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            txtNumero1.TextAlign = HorizontalAlignment.Center;
            txtNumero2.TextAlign = HorizontalAlignment.Center;
            lblResultado.Text = "Resultado";
        }


        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormCalculadora mv = new FormCalculadora();
            Dispose();
        }


        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = "0";
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }


        static double Operar(string num1, string num2, string operador)
        {
            Numero numA1 = new Numero(num1);
            Numero numA2 = new Numero(num2);

            if (String.IsNullOrEmpty(operador))
            {
                operador = "+";
            }
            double resultado = Calculadora.Operar(numA1, numA2, operador);
            return resultado;
        }


        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "Valor invalido" || lblResultado.Text != "Resultado")
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
            }
            //Genero alternancia de habilitacion entre los botones convertir
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }


        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            //Genero alternancia de habilitacion entre los botones convertir
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
