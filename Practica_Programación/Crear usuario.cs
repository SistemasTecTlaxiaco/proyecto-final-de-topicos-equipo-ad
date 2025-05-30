using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Practica_Programación
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=127.0.0.1;Port=3308;Database=usuarios;Uid=root;Pwd=root;";

        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Usuario y contraseña son obligatorios");
                return;
            }

            try
            {
                string contraseñaEncriptada = EncriptarSHA256(txtContraseña.Text);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Verificar si el usuario ya existe
                    string checkUser = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
                    MySqlCommand checkCmd = new MySqlCommand(checkUser, conn);
                    checkCmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("El usuario ya existe");
                        return;
                    }

                    // Insertar nuevo usuario
                    string insertQuery = "INSERT INTO usuarios (usuario, password) VALUES (@usuario, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    insertCmd.Parameters.AddWithValue("@password", contraseñaEncriptada);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado exitosamente");

                    this.Hide();
                    Form5 nuevoFormulario = new Form5();
                    nuevoFormulario.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar: {ex.Message}");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenidos nuevoFormulario = new Bienvenidos();
            nuevoFormulario.Show();
        }
    }
}
