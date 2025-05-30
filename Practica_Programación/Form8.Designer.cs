namespace Practica_Programación
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            BtnMenu = new Button();
            label1 = new Label();
            panel1 = new Panel();
            dataGridViewPrincipal = new DataGridView();
            BtnBuscar = new Button();
            txtBusqueda = new TextBox();
            BtnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtID = new TextBox();
            Precio = new Label();
            txtProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtPrecioVenta = new TextBox();
            label6 = new Label();
            txtExistencia = new TextBox();
            txtPrecioCompra = new TextBox();
            pictureBox1 = new PictureBox();
            btnLimpiar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            BtnMenu.Click += BtnMenu_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leckerli One", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(627, 12);
            label1.Name = "label1";
            label1.Size = new Size(203, 54);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(BtnMenu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Red;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 80);
            panel1.TabIndex = 1;
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewPrincipal.Anchor = AnchorStyles.None;
            dataGridViewPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrincipal.Location = new Point(323, 105);
            dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            dataGridViewPrincipal.RowHeadersWidth = 51;
            dataGridViewPrincipal.Size = new Size(831, 435);
            dataGridViewPrincipal.TabIndex = 2;
            dataGridViewPrincipal.CellContentClick += dataGridViewPrincipal_CellContentClick;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.None;
            BtnBuscar.BackColor = Color.Teal;
            BtnBuscar.BackgroundImageLayout = ImageLayout.Center;
            BtnBuscar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBuscar.ForeColor = SystemColors.ControlLightLight;
            BtnBuscar.Location = new Point(26, 105);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(143, 45);
            BtnBuscar.TabIndex = 26;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.None;
            txtBusqueda.BackColor = SystemColors.InactiveBorder;
            txtBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(26, 156);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(242, 34);
            txtBusqueda.TabIndex = 36;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.None;
            BtnAgregar.BackColor = Color.Teal;
            BtnAgregar.BackgroundImageLayout = ImageLayout.Center;
            BtnAgregar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ControlLightLight;
            BtnAgregar.Location = new Point(1197, 105);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(188, 73);
            BtnAgregar.TabIndex = 37;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BackColor = Color.Teal;
            btnEditar.BackgroundImageLayout = ImageLayout.Center;
            btnEditar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(1197, 213);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(188, 73);
            btnEditar.TabIndex = 38;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.Teal;
            btnEliminar.BackgroundImageLayout = ImageLayout.Center;
            btnEliminar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(1197, 467);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(188, 73);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_2;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.None;
            txtID.BackColor = SystemColors.InactiveBorder;
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(374, 578);
            txtID.Name = "txtID";
            txtID.Size = new Size(124, 34);
            txtID.TabIndex = 40;
            // 
            // Precio
            // 
            Precio.Anchor = AnchorStyles.None;
            Precio.AutoSize = true;
            Precio.BackColor = Color.Transparent;
            Precio.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Precio.ForeColor = Color.White;
            Precio.Location = new Point(418, 543);
            Precio.Name = "Precio";
            Precio.Size = new Size(39, 32);
            Precio.TabIndex = 41;
            Precio.Text = "ID";
            // 
            // txtProducto
            // 
            txtProducto.Anchor = AnchorStyles.None;
            txtProducto.BackColor = SystemColors.InactiveBorder;
            txtProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProducto.Location = new Point(508, 578);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(119, 34);
            txtProducto.TabIndex = 42;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(508, 543);
            label2.Name = "label2";
            label2.Size = new Size(117, 32);
            label2.TabIndex = 43;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(627, 543);
            label3.Name = "label3";
            label3.Size = new Size(142, 32);
            label3.TabIndex = 45;
            label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.BackColor = SystemColors.InactiveBorder;
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(636, 578);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(123, 34);
            txtDescripcion.TabIndex = 44;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nunito Black", 11F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(764, 548);
            label4.Name = "label4";
            label4.Size = new Size(142, 26);
            label4.TabIndex = 47;
            label4.Text = "Precio compra";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nunito Black", 11F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(904, 549);
            label5.Name = "label5";
            label5.Size = new Size(126, 26);
            label5.TabIndex = 49;
            label5.Text = "Precio venta";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Anchor = AnchorStyles.None;
            txtPrecioVenta.BackColor = SystemColors.InactiveBorder;
            txtPrecioVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioVenta.Location = new Point(906, 578);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(113, 34);
            txtPrecioVenta.TabIndex = 48;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(1028, 542);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 51;
            label6.Text = "Existencia";
            // 
            // txtExistencia
            // 
            txtExistencia.Anchor = AnchorStyles.None;
            txtExistencia.BackColor = SystemColors.InactiveBorder;
            txtExistencia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExistencia.Location = new Point(1030, 577);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(122, 34);
            txtExistencia.TabIndex = 50;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Anchor = AnchorStyles.None;
            txtPrecioCompra.BackColor = SystemColors.InactiveBorder;
            txtPrecioCompra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioCompra.Location = new Point(768, 578);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(128, 34);
            txtPrecioCompra.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_proyecto;
            pictureBox1.Location = new Point(12, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BackColor = Color.Teal;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(1197, 314);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(188, 73);
            btnLimpiar.TabIndex = 54;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1426, 678);
            Controls.Add(btnLimpiar);
            Controls.Add(pictureBox1);
            Controls.Add(txtPrecioCompra);
            Controls.Add(label6);
            Controls.Add(txtExistencia);
            Controls.Add(label5);
            Controls.Add(txtPrecioVenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtProducto);
            Controls.Add(Precio);
            Controls.Add(txtID);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(BtnAgregar);
            Controls.Add(txtBusqueda);
            Controls.Add(BtnBuscar);
            Controls.Add(dataGridViewPrincipal);
            Controls.Add(panel1);
            Name = "Form8";
            Text = "Inventario";
            Load += Form8_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMenu;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridViewPrincipal;
        private Button BtnBuscar;
        private TextBox txtBusqueda;
        private Button BtnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private TextBox textBox1;
        private Label Precio;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private TextBox txtID;
        private TextBox txtProducto;
        private TextBox txtDescripcion;
        private TextBox txtPrecioVenta;
        private TextBox txtExistencia;
        private TextBox txtPrecioCompra;
        private PictureBox pictureBox1;
        private Button btnLimpiar;
    }
}