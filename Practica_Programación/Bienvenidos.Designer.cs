namespace Practica_Programación
{
    partial class Bienvenidos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenidos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            LabelUsuario = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnAcceder = new Button();
            btnCreaUna = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_proyecto;
            pictureBox1.Location = new Point(195, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leckerli One", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(447, 21);
            label1.Name = "label1";
            label1.Size = new Size(333, 64);
            label1.TabIndex = 1;
            label1.Text = "¡Bienvenidos!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = SystemColors.InactiveBorder;
            txtUsuario.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(759, 274);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(268, 43);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.CausesValidation = false;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(759, 354);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(268, 43);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nunito Black", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(796, 190);
            label2.Name = "label2";
            label2.Size = new Size(194, 59);
            label2.TabIndex = 5;
            label2.Text = "Acceder";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelUsuario
            // 
            LabelUsuario.Anchor = AnchorStyles.None;
            LabelUsuario.AutoSize = true;
            LabelUsuario.BackColor = Color.Transparent;
            LabelUsuario.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUsuario.ForeColor = Color.White;
            LabelUsuario.Location = new Point(654, 278);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(105, 32);
            LabelUsuario.TabIndex = 6;
            LabelUsuario.Text = "Usuario:";
            LabelUsuario.Click += LabelUsuario_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(612, 359);
            label3.Name = "label3";
            label3.Size = new Size(147, 32);
            label3.TabIndex = 9;
            label3.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(787, 528);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 11;
            label5.Text = "¿No tienes cuenta?";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Candara", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(924, 528);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 12;
            label6.Text = "CREA UNA";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnAcceder
            // 
            BtnAcceder.Anchor = AnchorStyles.None;
            BtnAcceder.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAcceder.Location = new Point(824, 450);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(143, 45);
            BtnAcceder.TabIndex = 22;
            BtnAcceder.Text = "Aceptar";
            BtnAcceder.UseVisualStyleBackColor = true;
            BtnAcceder.Click += BtnAcceder_Click;
            // 
            // btnCreaUna
            // 
            btnCreaUna.Anchor = AnchorStyles.None;
            btnCreaUna.BackColor = Color.LightSlateGray;
            btnCreaUna.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreaUna.ForeColor = Color.Cornsilk;
            btnCreaUna.Location = new Point(926, 522);
            btnCreaUna.Name = "btnCreaUna";
            btnCreaUna.Size = new Size(119, 36);
            btnCreaUna.TabIndex = 23;
            btnCreaUna.Text = "Crea una";
            btnCreaUna.UseVisualStyleBackColor = false;
            btnCreaUna.Click += btnCreaUna_Click;
            // 
            // Bienvenidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1221, 724);
            Controls.Add(btnCreaUna);
            Controls.Add(BtnAcceder);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(LabelUsuario);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Bienvenidos";
            Text = "Bienvenidos - Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox textBox2;
        private Label label2;
        private Label LabelUsuario;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button BtnAcceder;
        private Button btnCreaUna;
    }
}
