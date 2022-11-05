using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public void operador(string oper)
        {
            switch (oper)
            {
                case "+":
                    txtNumeros.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) + Convert.ToDouble(txtVisor.Text));
                    txtVisor.Text = "";
                    break;
                case "-":
                    txtNumeros.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) - Convert.ToDouble(txtVisor.Text));
                    txtVisor.Text = "";
                    break;
                case "x":
                    txtNumeros.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) * Convert.ToDouble(txtVisor.Text));
                    txtVisor.Text = "";
                    break;
                case "/":
                    txtNumeros.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) / Convert.ToDouble(txtVisor.Text));
                    txtVisor.Text = "";
                    break;
            }
        }
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text =="") || (cont==1))
            {
                txtVisor.Text = "1";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "1";
            }
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {

            if ((txtVisor.Text != "") && (txtNumeros.Text == ""))
            {
                txtNumeros.Text = txtVisor.Text;
                txtVisor.Text = "";
                txtOperador.Text = "+";
            }
            else
            {
                operador(txtOperador.Text);
                txtOperador.Text = "+";
            }
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text !="")&&(txtNumeros.Text !=""))
            {
                cont = 1; 
                switch (txtOperador.Text)
                {
                    case "+":
                        txtVisor.Text = Convert.ToString(Convert.ToDouble(txtVisor.Text) + Convert.ToDouble(txtNumeros.Text));
                        txtOperador.Text = "";
                        txtNumeros.Text = "";
                        break;
                    case "-":

                        txtVisor.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) - Convert.ToDouble(txtVisor.Text));
                        txtOperador.Text = "";
                        txtNumeros.Text = "";
                        break;
                    case "x":
                        txtVisor.Text = Convert.ToString(Convert.ToDouble(txtVisor.Text) * Convert.ToDouble(txtNumeros.Text));
                        txtOperador.Text = "";
                        txtNumeros.Text = "";
                        break;
                    case "/":
                        txtVisor.Text = Convert.ToString(Convert.ToDouble(txtNumeros.Text) / Convert.ToDouble(txtVisor.Text));
                        txtOperador.Text = "";
                        txtNumeros.Text = "";
                        break;
                }
            }
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "2";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "2";
            }

        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }

            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "3";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "3";
            }
        }
        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "4";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "4";
            }
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "5";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "5";
            }
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "6";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "6";
            }
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "7";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "7";
            }
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "8";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "8";
            }
        }
        private void btnNove_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                txtVisor.Text = "";
            }
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "9";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "9";
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text == "") || (cont == 1))
            {
                txtVisor.Text = "0";
                cont = 0;
            }
            else
            {
                txtVisor.Text += "0";
            }
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text != "") && (txtNumeros.Text == ""))
            {
                txtNumeros.Text = txtVisor.Text;
                txtVisor.Text = "";
                txtOperador.Text = "-";
            }
            else
            {
                operador(txtOperador.Text);
                txtOperador.Text = "-";
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text != "") && (txtNumeros.Text == ""))
            {
                txtNumeros.Text = txtVisor.Text;
                txtVisor.Text = "";
                txtOperador.Text = "x";
            }
            else
            {
                operador(txtOperador.Text);
                txtOperador.Text = "x";
            }
        }
        private void btnDivi_Click(object sender, EventArgs e)
        {
            if ((txtVisor.Text != "") && (txtNumeros.Text == ""))
            {
                txtNumeros.Text = txtVisor.Text;
                txtVisor.Text = "";
                txtOperador.Text = "/";
            }
            else
            {
                operador(txtOperador.Text);
                txtOperador.Text = "/";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumeros.Text = "";
            txtOperador.Text = "";
            txtVisor.Text = "";
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text!="")
            {
                string apagar = txtVisor.Text;
                int tamanho = apagar.Length - 1;
                char[] teste = apagar.ToCharArray(0,tamanho);
                txtVisor.Text = "";
                foreach(char test in teste)
                {
                    txtVisor.Text += test.ToString();
                }
            }
        }
    }
}
