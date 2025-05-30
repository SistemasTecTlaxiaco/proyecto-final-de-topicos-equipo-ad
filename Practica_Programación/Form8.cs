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

            // Configurar DataGridView
            dataGridViewPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrincipal.MultiSelect = false;
            dataGridViewPrincipal.ReadOnly = true;
            dataGridViewPrincipal.AllowUserToAddRows = false;


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
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewPrincipal.SelectedRows[0];
            string nombreProducto = row.Cells["Producto"].Value.ToString();
            int idProducto = Convert.ToInt32(row.Cells["ID"].Value);

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el producto '{nombreProducto}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM productos WHERE id_producto = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no se haga clic en los encabezados
            {
                DataGridViewRow row = dataGridViewPrincipal.Rows[e.RowIndex];

                // Asignar valores a los TextBox
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtProducto.Text = row.Cells["Producto"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value?.ToString() ?? "";
                txtPrecioCompra.Text = row.Cells["Precio Compra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["Precio Venta"].Value.ToString();
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

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 nuevoFormulario = new Form5();
            nuevoFormulario.Show();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
        string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
        string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("Nombre, precio de compra y precio de venta son obligatorios", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO productos 
                           (nombre, descripcion, precio_compra, precio_venta, existencia) 
                           VALUES (@nombre, @descripcion, @precioCompra, @precioVenta, @existencia)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", txtProducto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@precioCompra", decimal.Parse(txtPrecioCompra.Text));
                    cmd.Parameters.AddWithValue("@precioVenta", decimal.Parse(txtPrecioVenta.Text));
                    cmd.Parameters.AddWithValue("@existencia",
                        string.IsNullOrWhiteSpace(txtExistencia.Text) ? 0 : int.Parse(txtExistencia.Text));

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto agregado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los campos de precio y existencia deben ser números válidos", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
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

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegura que no se haga clic en los encabezados
            {
                DataGridViewRow row = dataGridViewPrincipal.Rows[e.RowIndex];

                // Asignar valores a los TextBox
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtProducto.Text = row.Cells["Producto"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value?.ToString() ?? "";
                txtPrecioCompra.Text = row.Cells["Precio Compra"].Value.ToString();
                txtPrecioVenta.Text = row.Cells["Precio Venta"].Value.ToString();
                txtExistencia.Text = row.Cells["Existencia"].Value.ToString();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewPrincipal.SelectedRows[0];
            string nombreProducto = row.Cells["Producto"].Value.ToString();
            int idProducto = Convert.ToInt32(row.Cells["ID"].Value);

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el producto '{nombreProducto}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM productos WHERE id_producto = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewPrincipal.SelectedRows[0];
            string nombreProducto = row.Cells["Producto"].Value.ToString();
            int idProducto = Convert.ToInt32(row.Cells["ID"].Value);

            DialogResult confirm = MessageBox.Show(
                $"¿Eliminar el producto '{nombreProducto}'?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM productos WHERE id_producto = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", idProducto);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente", "Éxito",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

