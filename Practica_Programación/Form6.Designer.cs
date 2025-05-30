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
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dataProductos = new DataGridView();
            dataGridViewVenta = new DataGridView();
            lblTotal = new Label();
            lblProductos = new Label();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 60);
            panel1.TabIndex = 0;
            // 
            // BtnMenu
            // 
            BtnMenu.BackColor = Color.WhiteSmoke;
            BtnMenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMenu.ForeColor = Color.Maroon;
            BtnMenu.Location = new Point(10, 9);
            BtnMenu.Margin = new Padding(3, 2, 3, 2);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(100, 40);
            BtnMenu.TabIndex = 1;
            BtnMenu.Text = "Menú";
            BtnMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 37);
            label1.TabIndex = 0;
            label1.Text = "Venta en general";
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.Transparent;
            LabelUsuario.Location = new Point(99, 517);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(178, 24);
            LabelUsuario.TabIndex = 12;
            LabelUsuario.Text = "No. de productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(384, 514);
            label2.Name = "label2";
            label2.Size = new Size(71, 26);
            label2.TabIndex = 24;
            label2.Text = "Total:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Teal;
            BtnAgregar.BackgroundImage = (Image)resources.GetObject("BtnAgregar.BackgroundImage");
            BtnAgregar.BackgroundImageLayout = ImageLayout.Center;
            BtnAgregar.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BtnAgregar.Location = new Point(709, 81);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(125, 34);
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
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BtnCancelar.Location = new Point(709, 133);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(125, 34);
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
            txtCobrar.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCobrar.ForeColor = SystemColors.ActiveCaptionText;
            txtCobrar.Location = new Point(830, 494);
            txtCobrar.Margin = new Padding(3, 2, 3, 2);
            txtCobrar.Name = "txtCobrar";
            txtCobrar.Size = new Size(133, 53);
            txtCobrar.TabIndex = 27;
            txtCobrar.Text = "Cobrar";
            txtCobrar.UseVisualStyleBackColor = false;
            txtCobrar.Click += txtCobrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(195, 71);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 28;
            label3.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(62, 63);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 30;
            label4.Text = "Fecha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(62, 122);
            label5.Name = "label5";
            label5.Size = new Size(55, 24);
            label5.TabIndex = 31;
            label5.Text = "Hora";
            // 
            // IblFecha
            // 
            IblFecha.AutoSize = true;
            IblFecha.BackColor = Color.Transparent;
            IblFecha.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblFecha.ForeColor = Color.Transparent;
            IblFecha.Location = new Point(46, 87);
            IblFecha.Name = "IblFecha";
            IblFecha.Size = new Size(93, 22);
            IblFecha.TabIndex = 32;
            IblFecha.Text = "LblFecha";
            // 
            // IblHora
            // 
            IblHora.AutoSize = true;
            IblHora.BackColor = Color.Transparent;
            IblHora.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IblHora.ForeColor = Color.Transparent;
            IblHora.Location = new Point(34, 146);
            IblHora.Name = "IblHora";
            IblHora.Size = new Size(82, 22);
            IblHora.TabIndex = 33;
            IblHora.Text = "LblHora";
            // 
            // Cantidad
            // 
            Cantidad.AutoSize = true;
            Cantidad.BackColor = Color.Transparent;
            Cantidad.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cantidad.ForeColor = Color.Transparent;
            Cantidad.Location = new Point(647, 230);
            Cantidad.Name = "Cantidad";
            Cantidad.Size = new Size(92, 24);
            Cantidad.TabIndex = 34;
            Cantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.InactiveBorder;
            txtCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(752, 229);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(54, 29);
            txtCantidad.TabIndex = 35;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.InactiveBorder;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(195, 101);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(206, 29);
            txtBuscar.TabIndex = 39;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Teal;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Center;
            btnBuscar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(194, 136);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 30);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataProductos
            // 
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Location = new Point(46, 190);
            dataProductos.Margin = new Padding(3, 2, 3, 2);
            dataProductos.Name = "dataProductos";
            dataProductos.RowHeadersWidth = 51;
            dataProductos.Size = new Size(461, 82);
            dataProductos.TabIndex = 41;
            // 
            // dataGridViewVenta
            // 
            dataGridViewVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenta.Location = new Point(46, 328);
            dataGridViewVenta.Margin = new Padding(3, 2, 3, 2);
            dataGridViewVenta.Name = "dataGridViewVenta";
            dataGridViewVenta.RowHeadersWidth = 51;
            dataGridViewVenta.Size = new Size(918, 141);
            dataGridViewVenta.TabIndex = 42;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Transparent;
            lblTotal.Location = new Point(456, 516);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(28, 22);
            lblTotal.TabIndex = 44;
            lblTotal.Text = "---";
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.BackColor = Color.Transparent;
            lblProductos.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductos.ForeColor = Color.Transparent;
            lblProductos.Location = new Point(283, 518);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(28, 22);
            lblProductos.TabIndex = 45;
            lblProductos.Text = "---";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(990, 562);
            Controls.Add(lblProductos);
            Controls.Add(lblTotal);
            Controls.Add(dataGridViewVenta);
            Controls.Add(dataProductos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
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
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtBuscar;
        private Button button1;
        private Button btnBuscar;
        private DataGridView dataProductos;
        private DataGridView dataGridViewVenta;
        private Label lblTotal;
        private Label lblProductos;
    }
}