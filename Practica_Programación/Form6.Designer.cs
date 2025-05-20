namespace Practica_Programación
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            BtnMenu = new Button();
            label1 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Neto = new ColumnHeader();
            LabelUsuario = new Label();
            LblTotal = new TextBox();
            LblNoProductos = new TextBox();
            label2 = new Label();
            BtnRegistrar = new Button();
            BtnCancelar = new Button();
            button5 = new Button();
            label3 = new Label();
            cobProducto = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            IblFecha = new Label();
            IblHora = new Label();
            Cantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            Precio = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.WhiteSmoke;
            BtnMenu.Font = new Font("Leckerli One", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMenu.ForeColor = Color.Maroon;
            BtnMenu.Location = new Point(12, 12);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(114, 54);
            BtnMenu.TabIndex = 1;
            BtnMenu.Text = "Menú";
            BtnMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leckerli One", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(391, 12);
            label1.Name = "label1";
            label1.Size = new Size(327, 54);
            label1.TabIndex = 0;
            label1.Text = "Venta en general";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(255, 192, 192);
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, Neto });
            listView1.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.Location = new Point(52, 240);
            listView1.Name = "listView1";
            listView1.Size = new Size(1049, 401);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 230;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subtotal";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 170;
            // 
            // Neto
            // 
            Neto.Text = "Neto";
            Neto.TextAlign = HorizontalAlignment.Center;
            Neto.Width = 170;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.White;
            LabelUsuario.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Black;
            LabelUsuario.Location = new Point(113, 689);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(210, 32);
            LabelUsuario.TabIndex = 12;
            LabelUsuario.Text = "No. de productos:";
            // 
            // LblTotal
            // 
            LblTotal.BackColor = SystemColors.InactiveBorder;
            LblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTotal.Location = new Point(555, 685);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(174, 43);
            LblTotal.TabIndex = 11;
            // 
            // LblNoProductos
            // 
            LblNoProductos.BackColor = SystemColors.InactiveBorder;
            LblNoProductos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNoProductos.Location = new Point(338, 685);
            LblNoProductos.Name = "LblNoProductos";
            LblNoProductos.Size = new Size(61, 43);
            LblNoProductos.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Nunito Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(439, 686);
            label2.Name = "label2";
            label2.Size = new Size(96, 38);
            label2.TabIndex = 24;
            label2.Text = "Total:";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.Red;
            BtnRegistrar.BackgroundImage = Properties.Resources.fondo_figma;
            BtnRegistrar.BackgroundImageLayout = ImageLayout.Center;
            BtnRegistrar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.ForeColor = SystemColors.ControlLightLight;
            BtnRegistrar.Location = new Point(929, 106);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(143, 45);
            BtnRegistrar.TabIndex = 25;
            BtnRegistrar.Text = "Agregar";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Red;
            BtnCancelar.BackgroundImage = Properties.Resources.fondo_figma;
            BtnCancelar.BackgroundImageLayout = ImageLayout.Center;
            BtnCancelar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ControlLightLight;
            BtnCancelar.Location = new Point(929, 175);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(143, 45);
            BtnCancelar.TabIndex = 26;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.BackgroundImage = Properties.Resources.fondo_figma;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(949, 659);
            button5.Name = "button5";
            button5.Size = new Size(152, 71);
            button5.TabIndex = 27;
            button5.Text = "Cobrar";
            button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(223, 95);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 28;
            label3.Text = "Producto";
            label3.Click += label3_Click;
            // 
            // cobProducto
            // 
            cobProducto.FormattingEnabled = true;
            cobProducto.Location = new Point(223, 140);
            cobProducto.Name = "cobProducto";
            cobProducto.Size = new Size(249, 28);
            cobProducto.TabIndex = 29;
            cobProducto.SelectedIndexChanged += cobProducto_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(71, 84);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 30;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Red;
            label5.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(71, 163);
            label5.Name = "label5";
            label5.Size = new Size(69, 32);
            label5.TabIndex = 31;
            label5.Text = "Hora";
            // 
            // IblFecha
            // 
            IblFecha.AutoSize = true;
            IblFecha.BackColor = Color.Red;
            IblFecha.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblFecha.ForeColor = Color.Black;
            IblFecha.Location = new Point(52, 116);
            IblFecha.Name = "IblFecha";
            IblFecha.Size = new Size(116, 27);
            IblFecha.TabIndex = 32;
            IblFecha.Text = "LblFecha";
            IblFecha.Click += IblFecha_Click;
            // 
            // IblHora
            // 
            IblHora.AutoSize = true;
            IblHora.BackColor = Color.Red;
            IblHora.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblHora.ForeColor = Color.Black;
            IblHora.Location = new Point(39, 195);
            IblHora.Name = "IblHora";
            IblHora.Size = new Size(101, 27);
            IblHora.TabIndex = 33;
            IblHora.Text = "LblHora";
            IblHora.Click += IblHora_Click;
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.BackColor = Color.Red;
            Cantidad.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidad.ForeColor = Color.Black;
            Cantidad.Location = new Point(541, 188);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(114, 32);
            Cantidad.TabIndex = 34;
            Cantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.InactiveBorder;
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(661, 186);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(61, 34);
            txtCantidad.TabIndex = 35;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Red;
            lblPrecio.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(661, 135);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(101, 27);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "LblHora";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.BackColor = Color.Red;
            Precio.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Precio.ForeColor = Color.Black;
            Precio.Location = new Point(571, 134);
            Precio.Name = "Precio";
            Precio.Size = new Size(84, 32);
            Precio.TabIndex = 38;
            Precio.Text = "Precio";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_figma;
            ClientSize = new Size(1131, 750);
            Controls.Add(Precio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(Cantidad);
            Controls.Add(IblHora);
            Controls.Add(IblFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cobProducto);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnRegistrar);
            Controls.Add(label2);
            Controls.Add(LabelUsuario);
            Controls.Add(listView1);
            Controls.Add(LblTotal);
            Controls.Add(LblNoProductos);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button BtnMenu;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label LabelUsuario;
        private TextBox LblTotal;
        private TextBox LblNoProductos;
        private Label label2;
        private Button BtnRegistrar;
        private Button BtnCancelar;
        private Button button5;
        private Label label3;
        private ComboBox cobProducto;
        private Label label4;
        private Label label5;
        private Label IblFecha;
        private Label IblHora;
        private ColumnHeader Neto;
        private Label Cantidad;
        private TextBox txtCantidad;
        private Label lblPrecio;
        private Label Precio;
    }
}