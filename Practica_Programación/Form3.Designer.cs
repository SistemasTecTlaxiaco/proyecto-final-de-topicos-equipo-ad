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
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            LabelUsuario = new Label();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
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
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveBorder;
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(452, 358);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 43);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveBorder;
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(452, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 43);
            textBox1.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveBorder;
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(452, 437);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(268, 43);
            textBox3.TabIndex = 15;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nunito Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(346, 442);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 16;
            label1.Text = "Corrreo:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Candara", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(612, 574);
            label6.Name = "label6";
            label6.Size = new Size(76, 21);
            label6.TabIndex = 20;
            label6.Text = "ACCEDER";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(461, 571);
            label5.Name = "label5";
            label5.Size = new Size(159, 24);
            label5.TabIndex = 19;
            label5.Text = "¿Ya tienes cuenta?";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(515, 506);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 21;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_figma;
            ClientSize = new Size(1178, 727);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(LabelUsuario);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label LabelUsuario;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button button1;
    }
}