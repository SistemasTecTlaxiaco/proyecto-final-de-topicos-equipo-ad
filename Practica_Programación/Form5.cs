using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Programación
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 nuevoFormulario = new Form8();
            nuevoFormulario.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 nuevoFormulario = new Form6();
            nuevoFormulario.Show();

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Cerrar aplicación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
