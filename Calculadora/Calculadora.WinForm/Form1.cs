using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.WinForm
{
    public partial class CalculadoraForm : Form
    {
        double numero1 = 0, numero2 = 0;
        char Operador;
        double resultado = 0;

        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (resultado == 0)
            {
                if (txtResultado.Text == "0")
                    txtResultado.Text = "";
                txtResultado.Text += boton.Text;
                txtPreview.Text += boton.Text;
            }
            else
            {
                txtResultado.Text = boton.Text;
                
            }
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtResultado.Text);
            Operador = Convert.ToChar(boton.Text);
            txtPreview.Text += " " + Operador.ToString().ToLower() + " ";
            txtResultado.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultado.Text);
            switch (Operador)
            {
                case 'X':
                    resultado = numero2 * numero1;
                    break;

                case '+':
                    resultado = numero1 + numero2;
                    break;

                case '-':
                    resultado = numero1 - numero2;
                    break;

                default:
                    resultado = 0;
                    break;
            }

            txtResultado.Text = Convert.ToString(resultado);
            resultado = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            txtPreview.Text = "";
        }

       
    }
}
