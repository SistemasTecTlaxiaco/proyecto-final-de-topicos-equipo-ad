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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            panel1 = new Panel();
            BtnMenu = new Button();
            label1 = new Label();
            LabelUsuario = new Label();
            txtTotal = new TextBox();
            txtNoProductos = new TextBox();
            label2 = new Label();
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            txtCobrar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IblFecha = new Label();
            IblHora = new Label();
            Cantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            Precio = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataProductos = new DataGridView();
            dataGridViewVenta = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 80);
            panel1.TabIndex = 0;
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leckerli One", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(391, 12);
            label1.Name = "label1";
            label1.Size = new Size(327, 54);
            label1.TabIndex = 0;
            label1.Text = "Venta en general";
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Transparent;
            LabelUsuario.Location = new Point(113, 689);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(210, 32);
            LabelUsuario.TabIndex = 12;
            LabelUsuario.Text = "No. de productos:";
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.InactiveBorder;
            txtTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(555, 685);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(174, 43);
            txtTotal.TabIndex = 11;
            // 
            // txtNoProductos
            // 
            txtNoProductos.BackColor = SystemColors.InactiveBorder;
            txtNoProductos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoProductos.Location = new Point(338, 685);
            txtNoProductos.Name = "txtNoProductos";
            txtNoProductos.Size = new Size(61, 43);
            txtNoProductos.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nunito Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(439, 686);
            label2.Name = "label2";
            label2.Size = new Size(96, 38);
            label2.TabIndex = 24;
            label2.Text = "Total:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Teal;
            BtnAgregar.BackgroundImage = (Image)resources.GetObject("BtnAgregar.BackgroundImage");
            BtnAgregar.BackgroundImageLayout = ImageLayout.Center;
            BtnAgregar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BtnAgregar.Location = new Point(810, 108);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(143, 45);
            BtnAgregar.TabIndex = 25;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Teal;
            BtnCancelar.BackgroundImage = (Image)resources.GetObject("BtnCancelar.BackgroundImage");
            BtnCancelar.BackgroundImageLayout = ImageLayout.Center;
            BtnCancelar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BtnCancelar.Location = new Point(810, 177);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(143, 45);
            BtnCancelar.TabIndex = 26;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // txtCobrar
            // 
            txtCobrar.BackColor = Color.Teal;
            txtCobrar.BackgroundImage = (Image)resources.GetObject("txtCobrar.BackgroundImage");
            txtCobrar.BackgroundImageLayout = ImageLayout.Center;
            txtCobrar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCobrar.ForeColor = SystemColors.ActiveCaptionText;
            txtCobrar.Location = new Point(949, 659);
            txtCobrar.Name = "txtCobrar";
            txtCobrar.Size = new Size(152, 71);
            txtCobrar.TabIndex = 27;
            txtCobrar.Text = "Cobrar";
            txtCobrar.UseVisualStyleBackColor = false;
            txtCobrar.Click += txtCobrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(223, 95);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 28;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(71, 84);
            label4.Name = "label4";
            label4.Size = new Size(78, 32);
            label4.TabIndex = 30;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(71, 163);
            label5.Name = "label5";
            label5.Size = new Size(69, 32);
            label5.TabIndex = 31;
            label5.Text = "Hora";
            // 
            // IblFecha
            // 
            IblFecha.AutoSize = true;
            IblFecha.BackColor = Color.Transparent;
            IblFecha.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblFecha.ForeColor = Color.Transparent;
            IblFecha.Location = new Point(52, 116);
            IblFecha.Name = "IblFecha";
            IblFecha.Size = new Size(116, 27);
            IblFecha.TabIndex = 32;
            IblFecha.Text = "LblFecha";
            // 
            // IblHora
            // 
            IblHora.AutoSize = true;
            IblHora.BackColor = Color.Transparent;
            IblHora.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblHora.ForeColor = Color.Transparent;
            IblHora.Location = new Point(39, 195);
            IblHora.Name = "IblHora";
            IblHora.Size = new Size(101, 27);
            IblHora.TabIndex = 33;
            IblHora.Text = "LblHora";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.BackColor = Color.Transparent;
            Cantidad.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidad.ForeColor = Color.Transparent;
            Cantidad.Location = new Point(739, 307);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(114, 32);
            Cantidad.TabIndex = 34;
            Cantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.InactiveBorder;
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(859, 305);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(61, 34);
            txtCantidad.TabIndex = 35;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Transparent;
            lblPrecio.Location = new Point(859, 254);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(101, 27);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "LblHora";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.BackColor = Color.Transparent;
            Precio.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Precio.ForeColor = Color.Transparent;
            Precio.Location = new Point(769, 253);
            Precio.Name = "Precio";
            Precio.Size = new Size(84, 32);
            Precio.TabIndex = 38;
            Precio.Text = "Precio";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.InactiveBorder;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(223, 135);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(235, 34);
            txtBuscar.TabIndex = 39;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Teal;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(222, 182);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(101, 40);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataProductos
            // 
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Location = new Point(52, 253);
            dataProductos.Name = "dataProductos";
            dataProductos.RowHeadersWidth = 51;
            dataProductos.Size = new Size(527, 109);
            dataProductos.TabIndex = 41;
            // 
            // dataGridViewVenta
            // 
            dataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenta.Location = new Point(52, 437);
            dataGridViewVenta.Name = "dataGridViewVenta";
            dataGridViewVenta.RowHeadersWidth = 51;
            dataGridViewVenta.Size = new Size(1049, 188);
            dataGridViewVenta.TabIndex = 42;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1131, 750);
            Controls.Add(dataGridViewVenta);
            Controls.Add(dataProductos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(Precio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(Cantidad);
            Controls.Add(IblHora);
            Controls.Add(IblFecha);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCobrar);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(label2);
            Controls.Add(LabelUsuario);
            Controls.Add(txtTotal);
            Controls.Add(txtNoProductos);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Venta en general";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button BtnMenu;
        private ColumnHeader columnHeader4;
        private Label LabelUsuario;
        private TextBox txtTotal;
        private TextBox txtNoProductos;
        private Label label2;
        private Button BtnAgregar;
        private Button BtnCancelar;
        private Button txtCobrar;
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
        private TextBox txtBuscar;
        private Button button1;
        private Button btnBuscar;
        private DataGridView dataProductos;
        private DataGridView dataGridViewVenta;
    }
}