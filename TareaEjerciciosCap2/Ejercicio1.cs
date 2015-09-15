using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjerciciosCap2
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           //oioi
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void Lado_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LongLado_textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Perimetro_textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(LadotextBox1.Text);
            double longLado = Convert.ToDouble(LongLadotextBox2.Text);
            double resultado = lado * longLado;
            PerimetrotextBox3.Text = resultado.ToString();
        }
    }
}
