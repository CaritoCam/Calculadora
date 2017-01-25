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
    public partial class Form1 : Form
    {
        double primero, segundo, resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }
        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void entre_Click(object sender, EventArgs e)
        {
            operacion = "division";
            primero = double.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);
            if(operacion=="division")
            {
                resultado = primero / segundo;
            }
            if(operacion=="multiplicacion")
            {
                resultado = primero * segundo;
            }
            if(operacion=="resta")
            {
                resultado = primero - segundo;
            }
            if(operacion=="suma")
            {
                resultado = primero + segundo;
            }
            pantalla.Text = resultado.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void por_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            operacion = "multiplicacion";
            pantalla.Clear();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            operacion = "resta";
            pantalla.Clear();
        }

        private void mas_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            operacion = "suma";
            pantalla.Clear();
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = Math.Sqrt(primero);
            pantalla.Text = resultado.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = Math.Pow(primero, 2);
            pantalla.Text = resultado.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void puntito_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }
    }
}
