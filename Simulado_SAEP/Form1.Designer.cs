namespace Simulado_SAEP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Cadastrar_Carro = new Button();
            Editar_Carros = new Button();
            Excluir_Carros = new Button();
            Ver_Carros = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Cadastrar_Carro
            // 
            Cadastrar_Carro.Font = new Font("Impact", 22F, FontStyle.Italic);
            Cadastrar_Carro.Location = new Point(12, 75);
            Cadastrar_Carro.Name = "Cadastrar_Carro";
            Cadastrar_Carro.Size = new Size(278, 64);
            Cadastrar_Carro.TabIndex = 0;
            Cadastrar_Carro.Text = "Cadastrar Carro";
            Cadastrar_Carro.UseVisualStyleBackColor = true;
            Cadastrar_Carro.Click += Cadastrar_Carro_Click;
            // 
            // Editar_Carros
            // 
            Editar_Carros.Font = new Font("Impact", 22F, FontStyle.Italic);
            Editar_Carros.Location = new Point(12, 187);
            Editar_Carros.Name = "Editar_Carros";
            Editar_Carros.Size = new Size(278, 64);
            Editar_Carros.TabIndex = 1;
            Editar_Carros.Text = "Editar Carros";
            Editar_Carros.UseVisualStyleBackColor = true;
            Editar_Carros.Click += Editar_Carros_Click;
            // 
            // Excluir_Carros
            // 
            Excluir_Carros.Font = new Font("Impact", 22F, FontStyle.Italic);
            Excluir_Carros.Location = new Point(12, 296);
            Excluir_Carros.Name = "Excluir_Carros";
            Excluir_Carros.Size = new Size(278, 64);
            Excluir_Carros.TabIndex = 2;
            Excluir_Carros.Text = "Excluir Carros";
            Excluir_Carros.UseVisualStyleBackColor = true;
            Excluir_Carros.Click += Excluir_Carros_Click;
            // 
            // Ver_Carros
            // 
            Ver_Carros.Font = new Font("Impact", 22F, FontStyle.Italic);
            Ver_Carros.Location = new Point(12, 408);
            Ver_Carros.Name = "Ver_Carros";
            Ver_Carros.Size = new Size(278, 64);
            Ver_Carros.TabIndex = 3;
            Ver_Carros.Text = "Ver Carros";
            Ver_Carros.UseVisualStyleBackColor = true;
            Ver_Carros.Click += Ver_Carros_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1285, 540);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 143, 143);
            ClientSize = new Size(1079, 575);
            Controls.Add(Ver_Carros);
            Controls.Add(Excluir_Carros);
            Controls.Add(Editar_Carros);
            Controls.Add(Cadastrar_Carro);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Crud Carros";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Cadastrar_Carro;
        private Button Editar_Carros;
        private Button Excluir_Carros;
        private Button Ver_Carros;
        private PictureBox pictureBox1;
    }
}
