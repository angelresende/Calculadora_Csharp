using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormPrincipal : Form
    {
        int valor=0;
        bool validar = false;
        string operacao;
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Num(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            text_Valor.Text = text_Valor.Text + bt.Text;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            text_Valor.Text = "";
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            if (validar == true) 
            {
                valor = valor + Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Somar";
            }
            else
            {
                valor = Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Somar";
                validar = true;
            }
        }

        private void btn_Subtrair_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                valor = valor - Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Subtrair";
            }
            else
            {
                valor = Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Subtrair";
                validar = true;
            }
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                valor = valor * Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Multiplicar";
            }
            else
            {
                valor = Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Multiplicar";
                validar = true;
            }
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                valor = valor / Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Dividir";
            }
            else
            {
                valor = Convert.ToInt32(text_Valor.Text);
                text_Valor.Text = "";
                operacao = "Dividir";
                validar = true;
            }
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            if (operacao == "Somar")
            {
                text_Valor.Text = Convert.ToString(valor + Convert.ToInt32(text_Valor.Text));
            }
            else if (operacao == "Subtrair")
            {
                text_Valor.Text = Convert.ToString(valor - Convert.ToInt32(text_Valor.Text));
            }
            else if (operacao == "Multiplicar")
            {
                text_Valor.Text = Convert.ToString(valor * Convert.ToInt32(text_Valor.Text));
            }
            else if (operacao == "Dividir")
            {
                text_Valor.Text = Convert.ToString(valor / Convert.ToInt32(text_Valor.Text));
            }
        }

    }
}
