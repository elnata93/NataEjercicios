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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcularButton1_Click(object sender, EventArgs e)
        {
            double grados = Convert.ToDouble(gradosTextBox1.Text);
            double resultado = (grados*3.14)/180 ;
            resultTextBox4.Text = resultado.ToString();
        }
    }
}
