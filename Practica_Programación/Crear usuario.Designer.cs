namespace Practica_Programación
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label2 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            LabelUsuario = new Label();
            label3 = new Label();
            label5 = new Label();
            btnAceptar = new Button();
            btnAcceder = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nunito Black", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(433, 177);
            label2.Name = "label2";
            label2.Size = new Size(307, 59);
            label2.TabIndex = 12;
            label2.Text = "Crear usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = SystemColors.InactiveBorder;
            txtContraseña.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(452, 358);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(268, 43);
            txtContraseña.TabIndex = 11;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.InactiveBorder;
            txtUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(452, 278);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 43);
            txtUsuario.TabIndex = 10;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // LabelUsuario
            // 
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.White;
            LabelUsuario.Location = new Point(347, 282);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(105, 32);
            LabelUsuario.TabIndex = 13;
            LabelUsuario.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(305, 363);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 14;
            label3.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(457, 501);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 19;
            label5.Text = "¿Ya tienes cuenta?";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(511, 436);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(143, 45);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Crear";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.LightSlateGray;
            btnAcceder.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ButtonHighlight;
            btnAcceder.Location = new Point(617, 500);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(94, 29);
            btnAcceder.TabIndex = 22;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1178, 727);
            Controls.Add(btnAcceder);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(LabelUsuario);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "Form3";
            Text = "Crear usuario";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label LabelUsuario;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button btnAceptar;
        private Button btnAcceder;
    }
}