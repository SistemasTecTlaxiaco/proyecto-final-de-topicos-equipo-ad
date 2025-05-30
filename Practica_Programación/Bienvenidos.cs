using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Practica_Programación
{
    public partial class Bienvenidos : Form
    {
        public Bienvenidos() => InitializeComponent();


        private string EncriptarSHA256(string texto)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(texto);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    return Convert.ToBase64String(hashBytes);
                }
            }

            //panel1.BackColor = Color.FromArgb(125, Color.White);
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LabelEntrar_Click(object sender, EventArgs e)
        {

        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string connectionString = "Server=127.0.0.1;Port=3308;Database=usuarios;Uid=root;Pwd=root;";

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = textBox2.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Debe ingresar usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string contraseñaEncriptada = EncriptarSHA256(contraseña);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND password = @password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", contraseñaEncriptada);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        
                        this.Hide();
                        Form5 nuevoFormulario = new Form5();
                        nuevoFormulario.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreaUna_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 nuevoFormulario = new Form3();
            nuevoFormulario.Show(); 
        }
    }
}
