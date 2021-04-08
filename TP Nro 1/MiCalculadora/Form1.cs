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
           // lblResultado.AutoSize = false;
          //  lblResultado.TextAlign = ContentAlignment.MiddleLeft;
            





        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero(txtNumero1.Text);
            Numero num2 = new Numero(txtNumero2.Text);
            double resultado;

            resultado = Calculadora.Operar(num1, num2, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FormCalculadora mv = new FormCalculadora();
            this.Close();
        }

      
    }
}
