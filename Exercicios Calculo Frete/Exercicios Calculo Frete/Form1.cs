using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Calculo_Frete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void CalcularFrete()
        {
            try
            {
                double valor = double.Parse(txtValor.Text);
                double valorTotal = 0;
                double valorFrete = 0;

                if (valor > 1000)
                {
                    valorFrete = 0;
                }
                else if (cbxUf.SelectedItem.ToString() == "São Paulo")
                {
                    valorFrete = 5;
                }
                else if (cbxUf.SelectedItem.ToString() == "Rio de Janeiro")
                {
                    valorFrete = 10;
                }
                else if (cbxUf.SelectedItem.ToString() == "Amazonas")
                {
                    valorFrete = 20;
                }
                else
                {
                    valorFrete = 15;

                }

                // calcular o total
                valorTotal = valor + valorFrete;

                // determinei o texto dos labels com os valores das variaveis 
                lblFrete.Text = valorFrete.ToString("C");
                lblValorCompra.Text = valor.ToString("C");
                lblTotal.Text = valorTotal.ToString("C");
            }
            catch (Exception e)
            {
                MessageBox.Show("Preencha os Campos Anteriores", "Erro");
            }

        }
        void Limpar()
        {
            // apagar o texto dos textbox
            txtNome.Text = "";
            txtValor.Text = "";
            cbxUf.Text = "";

            // limpar os labels lblValorCompra, lblFrete lblTotal
            lblValorCompra.Text = "";
            lblFrete.Text = "";
            lblTotal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtValor.Select();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxUf.Select();
            }
        }

        private void cbxUf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Select();
            }
        }
    }
}