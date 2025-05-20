
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PruebaBiblioteca;
using System.Text;
using BibliotecaProyecto;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Practica_Programación
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        static string[] productos = { "Teclado", "Impresora", "Monitor", "Mouse", "Laptop", "Tablet", "Auriculares", "Cámara Web", "Router", "Disco Duro", "Memoria USB", "Tarjeta Gráfica", "Fuente de Poder", "Gabinete", "Placa Madre", "Procesador", "RAM 16GB", "SSD 1TB" };
        ArrayList aProducto = new ArrayList(productos);

        private void Form6_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            Operaciones.MostrarHora();
            IblFecha.Text = Operaciones.MostrarFecha();
            IblHora.Text = Operaciones.MostrarHora();
            LlenarProducto();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IblHora_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            cobProducto.Text = "Seleccione un producto";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
        }

        private void LlenarProducto()
        {
            foreach (var p in aProducto)
            {
                cobProducto.Items.Add(p);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir...?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cobProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cobProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto y especifique la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Operaciones.ValidarEntrada(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string productoSeleccionado = cobProducto.SelectedItem.ToString();
            double precio = ObtenerPrecio(productoSeleccionado);
            double subtotal = Operaciones.CalcularSubtotal(precio, cantidad);
            double neto = Operaciones.CalcularTotalNeto(precio, cantidad, 10); // Descuento del 10%

            ListViewItem item = new ListViewItem(new[]
            {
                productoSeleccionado,
                cantidad.ToString(),
                precio.ToString("F2"),
                subtotal.ToString("F2"),
                neto.ToString("F2")
            });

            listView1.Items.Add(item);
            LimpiarCampos();
        }

        private double ObtenerPrecio(string producto)
        {
            switch (producto)
            {
                case "Teclado": return 1_200.00;
                case "Impresora": return 3_500.00;
                case "Monitor": return 4_800.00;
                case "Mouse": return 600.00;
                case "Laptop": return 25_000.00;
                case "Tablet": return 9_000.00;
                case "Auriculares": return 1_800.00;
                case "Cámara Web": return 2_200.00;
                case "Router": return 3_000.00;
                case "Disco Duro": return 5_500.00;
                case "Memoria USB": return 450.00;
                case "Tarjeta Gráfica": return 15_000.00;
                case "Fuente de Poder": return 2_800.00;
                case "Gabinete": return 3_700.00;
                case "Placa Madre": return 12_000.00;
                case "Procesador": return 18_500.00;
                case "RAM 16GB": return 2_600.00;
                case "SSD 1TB": return 4_200.00;
                default: return 0.00;
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }
        }
    }
}
