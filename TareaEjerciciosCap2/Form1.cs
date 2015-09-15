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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercico3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
                    }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 ej = new Ejercicio1();
            ej.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 ej = new Ejercicio2();
            ej.Show();
        }
    }
}
