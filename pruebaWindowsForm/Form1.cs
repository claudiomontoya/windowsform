using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular(1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcular(2);
        }


        private void calcular(int operacion)
        {
            try
            {
                int resultado = 0;
                switch (operacion)
                {
                    case 1: resultado = int.Parse(txt_numero1.Text) + int.Parse(txt_numero2.Text); break;
                    case 2: resultado  = int.Parse(txt_numero1.Text) - int.Parse(txt_numero2.Text); break;
                    case 3: resultado  = int.Parse(txt_numero1.Text) * int.Parse(txt_numero2.Text); break;
                    case 4: if (txt_numero2.Text != "0")
                            {
                            resultado = int.Parse(txt_numero1.Text) / int.Parse(txt_numero2.Text);
                            }
                           else
                            {
                            MessageBox.Show("No es posible dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                    default:break;
                }
              
                txt_resultado.Text = resultado.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Dede ingresar solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcular(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcular(4);
        }
    }
}
