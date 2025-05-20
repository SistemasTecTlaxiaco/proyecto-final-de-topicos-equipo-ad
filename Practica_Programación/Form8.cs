using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica_Programación
{
    public partial class Form8 : Form
    {
        // Cadena de conexión con puerto 3308 y contraseña "root"


        private string connectionString = "Server=localhost;Port=3308;Database=tienda_db;Uid=root;Pwd=root;";

        public Form8()
        {
            InitializeComponent();
            CargarProductos(); 
        }

        private void CargarProductos()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_producto as 'ID', nombre as 'Producto', " +
                                 "descripcion as 'Descripción', " +
                                 "precio_compra as 'Precio Compra', " +
                                 "precio_venta as 'Precio Venta', " +
                                 "existencia as 'Existencia' FROM productos";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar al DataGridViewPrincipal
                    dataGridViewPrincipal.DataSource = dt;

                    // Opcional: Ajustar el ancho de las columnas
                    dataGridViewPrincipal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBusqueda = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(nombreBusqueda))
            {
                CargarProductos();
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_producto as 'ID', nombre as 'Producto', " +
                                 "descripcion as 'Descripción', " +
                                 "precio_compra as 'Precio Compra', " +
                                 "precio_venta as 'Precio Venta', " +
                                 "existencia as 'Existencia' " +
                                 "FROM productos WHERE nombre LIKE @nombre";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombreBusqueda + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewPrincipal.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos con ese nombre.", "Información",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un ID
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un producto de la lista para editar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE productos SET nombre = @nombre, descripcion = @descripcion, " +
                                 "precio_compra = @precioCompra, precio_venta = @precioVenta, " +
                                 "existencia = @existencia WHERE id_producto = @id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", txtProducto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@precioCompra", decimal.Parse(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@precioVenta", decimal.Parse(txtPrecioVenta.Text));
                    cmd.Parameters.AddWithValue("@existencia", int.Parse(txtExistencia.Text));
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto a actualizar", "Advertencia",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un ID
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un producto de la lista para eliminar", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmar eliminación
            DialogResult confirm = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM productos WHERE id_producto = @id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto a eliminar", "Advertencia",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            // Llenar las cajas de texto cuando se selecciona un producto
            if (dataGridViewPrincipal.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewPrincipal.SelectedRows[0];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtProducto.Text = row.Cells["Producto"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value.ToString();
                txtPrecioCompra.Text = row.Cells["Precio compra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["Precio venta"].Value.ToString();
                txtExistencia.Text = row.Cells["Existencia"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtProducto.Clear();
            txtDescripcion.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtExistencia.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
