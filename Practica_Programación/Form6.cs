
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
using MySql.Data.MySqlClient;

    namespace Practica_Programación
{
    public partial class Form6 : Form
    {

        private string connectionString = "Server=localhost;Port=3308;Database=tienda_db;Uid=root;Pwd=root;";

        public Form6()
        {
         
            InitializeComponent();
            ConfigurarDataGridViewVenta();
            ConfigurarControles();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            IblFecha.Text = Operaciones.MostrarFecha();
            IblHora.Text = Operaciones.MostrarHora();
            CargarProductos();
        }

        private void ConfigurarDataGridViewProductos()
        {
            // Configurar DataGridView de productos
            dataProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProductos.MultiSelect = false;
            dataProductos.ReadOnly = true;
            dataProductos.AllowUserToAddRows = false;
            dataProductos.CellDoubleClick += DataProductos_CellDoubleClick;
        }

        private void ConfigurarDataGridViewVenta()
        {
            dataGridViewVenta.Columns.Clear();
            dataGridViewVenta.Columns.Add("ID", "ID");
            dataGridViewVenta.Columns.Add("Nombre", "Producto");
            dataGridViewVenta.Columns.Add("Precio", "Precio Unitario");
            dataGridViewVenta.Columns.Add("Cantidad", "Cantidad");
            dataGridViewVenta.Columns.Add("Subtotal", "Subtotal");
        }

        private void CargarProductos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_producto, nombre, precio_venta, existencia FROM productos";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataProductos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void DataProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Almacenar el producto seleccionado en la variable temporal
                productoSeleccionado = (dataProductos.DataSource as DataTable).DefaultView[e.RowIndex];

                // Mostrar información del producto seleccionado
                txtBuscar.Text = productoSeleccionado["nombre"].ToString();
                txtCantidad.Text = "1"; // Establecer cantidad por defecto
                txtCantidad.Focus(); // Poner foco en el campo de cantidad
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionado == null)
            {
                MessageBox.Show("No hay producto seleccionado");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida");
                return;
            }

            int existencia = Convert.ToInt32(productoSeleccionado["existencia"]);
            if (cantidad > existencia)
            {
                MessageBox.Show("No hay suficiente existencia");
                return;
            }


            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                if (row.Cells["ID"].Value != null &&
                    row.Cells["ID"].Value.ToString() == productoSeleccionado["id_producto"].ToString())
                {
                    // Actualizar cantidad y subtotal
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = cantidadActual + cantidad;
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    row.Cells["Subtotal"].Value = (cantidadActual + cantidad) * precio;
                    ActualizarTotales();
                    productoSeleccionado = null;
                    txtBuscar.Clear();
                    txtCantidad.Clear();
                    return;
                }
            }


            decimal precioVenta = Convert.ToDecimal(productoSeleccionado["precio_venta"]);
            decimal subtotal = cantidad * precioVenta;

            dataGridViewVenta.Rows.Add(
                productoSeleccionado["id_producto"],
                productoSeleccionado["nombre"],
                precioVenta,
                cantidad,
                subtotal
            );

            ActualizarTotales();
            productoSeleccionado = null;
            txtBuscar.Clear();
            txtCantidad.Clear();
        }



        private void CalcularTotales()
        {
            decimal total = 0;
            int numProductos = 0;

            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                    numProductos += Convert.ToInt32(row.Cells["Cantidad"].Value);
                }
            }

            txtTotal.Text = total.ToString("C");
            txtNoProductos.Text = numProductos.ToString();
        }

        private void LimpiarCampos()
        {
            dataGridViewVenta.Rows.Clear();
            txtTotal.Clear();
            txtNoProductos.Clear();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cancelar la venta?", "Ventas",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta");
                return;
            }

            try
            {
                // Aquí iría el código para guardar la venta en la base de datos
                MessageBox.Show("Venta registrada correctamente");
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                CargarProductos();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_producto, nombre, precio_venta, existencia " +
                                 "FROM productos WHERE nombre LIKE @busqueda";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@busqueda", "%" + busqueda + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataProductos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message);
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nuevoFormulario = new Form5();
            nuevoFormulario.Show();
        }

        private void txtCobrar_Click(object sender, EventArgs e)
        {
            BtnAgregar_Click(sender, e);
        }

        
    }
}