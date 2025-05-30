namespace Practica_Programación
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leckerli One", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 81);
            label1.TabIndex = 2;
            label1.Text = "Menú";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Teal;
            button1.Image = Properties.Resources.venta1;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(210, 115);
            button1.Name = "button1";
            button1.Size = new Size(315, 272);
            button1.TabIndex = 23;
            button1.Text = "Hacer una venta";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Teal;
            button2.Image = Properties.Resources.Gemini_Generated_Image_nvshtznvshtznvsh;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(553, 115);
            button2.Name = "button2";
            button2.Size = new Size(291, 272);
            button2.TabIndex = 24;
            button2.Text = "Inventario";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Font = new Font("Nunito Black", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Teal;
            button3.Image = Properties.Resources.salir;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(393, 413);
            button3.Name = "button3";
            button3.Size = new Size(291, 268);
            button3.TabIndex = 25;
            button3.Text = "Salir";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1108, 730);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Menú";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}