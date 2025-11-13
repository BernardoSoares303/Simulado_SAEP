namespace Simulado_SAEP
{
    partial class Editar_Carro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Carro));
            pictureBox1 = new PictureBox();
            Editar = new Button();
            Km_text = new TextBox();
            label13 = new Label();
            Potencia_Text = new TextBox();
            label12 = new Label();
            Internacional_Radio = new RadioButton();
            Nacional_Radio = new RadioButton();
            label11 = new Label();
            Velocidade_text = new TextBox();
            label10 = new Label();
            Num_Portas_Text = new TextBox();
            label9 = new Label();
            Combustivel_Text = new TextBox();
            label8 = new Label();
            Chassi_text = new TextBox();
            label7 = new Label();
            Placa_Text = new TextBox();
            label6 = new Label();
            Cor_Text = new TextBox();
            label5 = new Label();
            Valor_Text = new TextBox();
            label4 = new Label();
            Avarias_Text = new TextBox();
            label3 = new Label();
            Ano_Text = new TextBox();
            label2 = new Label();
            Modelo_Text = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(516, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // Editar
            // 
            Editar.Font = new Font("Impact", 38F, FontStyle.Italic);
            Editar.Location = new Point(546, 405);
            Editar.Name = "Editar";
            Editar.Size = new Size(471, 128);
            Editar.TabIndex = 56;
            Editar.Text = "Editar Carro";
            Editar.UseVisualStyleBackColor = true;
            Editar.Click += Editar_Click;
            // 
            // Km_text
            // 
            Km_text.BackColor = Color.FromArgb(204, 210, 223);
            Km_text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Km_text.Location = new Point(947, 20);
            Km_text.Name = "Km_text";
            Km_text.Size = new Size(112, 37);
            Km_text.TabIndex = 55;
            Km_text.TextChanged += Km_text_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Impact", 22F, FontStyle.Italic);
            label13.Location = new Point(762, 17);
            label13.Name = "label13";
            label13.Size = new Size(179, 37);
            label13.TabIndex = 54;
            label13.Text = "Km Rodados: ";
            // 
            // Potencia_Text
            // 
            Potencia_Text.BackColor = Color.FromArgb(204, 210, 223);
            Potencia_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Potencia_Text.Location = new Point(644, 17);
            Potencia_Text.Name = "Potencia_Text";
            Potencia_Text.Size = new Size(112, 37);
            Potencia_Text.TabIndex = 53;
            Potencia_Text.TextChanged += Potencia_Text_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 22F, FontStyle.Italic);
            label12.Location = new Point(507, 17);
            label12.Name = "label12";
            label12.Size = new Size(131, 37);
            label12.TabIndex = 52;
            label12.Text = "Potencia:";
            // 
            // Internacional_Radio
            // 
            Internacional_Radio.AutoSize = true;
            Internacional_Radio.Font = new Font("Impact", 14F, FontStyle.Italic);
            Internacional_Radio.Location = new Point(312, 532);
            Internacional_Radio.Name = "Internacional_Radio";
            Internacional_Radio.Size = new Size(135, 27);
            Internacional_Radio.TabIndex = 51;
            Internacional_Radio.TabStop = true;
            Internacional_Radio.Text = "Internacional";
            Internacional_Radio.UseVisualStyleBackColor = true;
            // 
            // Nacional_Radio
            // 
            Nacional_Radio.AutoSize = true;
            Nacional_Radio.Font = new Font("Impact", 14F, FontStyle.Italic);
            Nacional_Radio.Location = new Point(209, 531);
            Nacional_Radio.Name = "Nacional_Radio";
            Nacional_Radio.Size = new Size(97, 27);
            Nacional_Radio.TabIndex = 50;
            Nacional_Radio.TabStop = true;
            Nacional_Radio.Text = "Nacional";
            Nacional_Radio.UseVisualStyleBackColor = true;
            Nacional_Radio.TextChanged += Nacional_Radio_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 22F, FontStyle.Italic);
            label11.Location = new Point(12, 523);
            label11.Name = "label11";
            label11.Size = new Size(191, 37);
            label11.TabIndex = 49;
            label11.Text = "Nacinalidade: ";
            // 
            // Velocidade_text
            // 
            Velocidade_text.BackColor = Color.FromArgb(204, 210, 223);
            Velocidade_text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Velocidade_text.Location = new Point(279, 484);
            Velocidade_text.Name = "Velocidade_text";
            Velocidade_text.Size = new Size(94, 37);
            Velocidade_text.TabIndex = 48;
            Velocidade_text.TextChanged += Velocidade_text_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 22F, FontStyle.Italic);
            label10.Location = new Point(12, 484);
            label10.Name = "label10";
            label10.Size = new Size(261, 37);
            label10.TabIndex = 47;
            label10.Text = "Velocidade Maxima:";
            // 
            // Num_Portas_Text
            // 
            Num_Portas_Text.BackColor = Color.FromArgb(204, 210, 223);
            Num_Portas_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Num_Portas_Text.Location = new Point(259, 431);
            Num_Portas_Text.Name = "Num_Portas_Text";
            Num_Portas_Text.Size = new Size(69, 37);
            Num_Portas_Text.TabIndex = 46;
            Num_Portas_Text.TextChanged += Num_Portas_Text_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 22F, FontStyle.Italic);
            label9.Location = new Point(12, 431);
            label9.Name = "label9";
            label9.Size = new Size(241, 37);
            label9.TabIndex = 45;
            label9.Text = "Numero De Portas:";
            // 
            // Combustivel_Text
            // 
            Combustivel_Text.BackColor = Color.FromArgb(204, 210, 223);
            Combustivel_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Combustivel_Text.Location = new Point(194, 377);
            Combustivel_Text.Name = "Combustivel_Text";
            Combustivel_Text.Size = new Size(218, 37);
            Combustivel_Text.TabIndex = 44;
            Combustivel_Text.TextChanged += Combustivel_Text_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 22F, FontStyle.Italic);
            label8.Location = new Point(12, 377);
            label8.Name = "label8";
            label8.Size = new Size(176, 37);
            label8.TabIndex = 43;
            label8.Text = "Combustivel:";
            // 
            // Chassi_text
            // 
            Chassi_text.BackColor = Color.FromArgb(204, 210, 223);
            Chassi_text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Chassi_text.Location = new Point(125, 323);
            Chassi_text.Name = "Chassi_text";
            Chassi_text.Size = new Size(203, 37);
            Chassi_text.TabIndex = 42;
            Chassi_text.TextChanged += Chassi_text_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 22F, FontStyle.Italic);
            label7.Location = new Point(12, 323);
            label7.Name = "label7";
            label7.Size = new Size(107, 37);
            label7.TabIndex = 41;
            label7.Text = "Chassi:";
            // 
            // Placa_Text
            // 
            Placa_Text.BackColor = Color.FromArgb(204, 210, 223);
            Placa_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Placa_Text.Location = new Point(109, 272);
            Placa_Text.Name = "Placa_Text";
            Placa_Text.Size = new Size(125, 37);
            Placa_Text.TabIndex = 40;
            Placa_Text.TextChanged += Placa_Text_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 22F, FontStyle.Italic);
            label6.Location = new Point(12, 272);
            label6.Name = "label6";
            label6.Size = new Size(91, 37);
            label6.TabIndex = 39;
            label6.Text = "Placa:";
            // 
            // Cor_Text
            // 
            Cor_Text.BackColor = Color.FromArgb(204, 210, 223);
            Cor_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Cor_Text.Location = new Point(87, 221);
            Cor_Text.Name = "Cor_Text";
            Cor_Text.Size = new Size(112, 37);
            Cor_Text.TabIndex = 38;
            Cor_Text.TextChanged += Cor_Text_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 22F, FontStyle.Italic);
            label5.Location = new Point(12, 221);
            label5.Name = "label5";
            label5.Size = new Size(66, 37);
            label5.TabIndex = 37;
            label5.Text = "Cor:";
            // 
            // Valor_Text
            // 
            Valor_Text.BackColor = Color.FromArgb(204, 210, 223);
            Valor_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Valor_Text.Location = new Point(105, 171);
            Valor_Text.Name = "Valor_Text";
            Valor_Text.Size = new Size(297, 37);
            Valor_Text.TabIndex = 36;
            Valor_Text.TextChanged += Valor_Text_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 22F, FontStyle.Italic);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 35;
            label4.Text = "Valor:";
            // 
            // Avarias_Text
            // 
            Avarias_Text.BackColor = Color.FromArgb(204, 210, 223);
            Avarias_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Avarias_Text.Location = new Point(137, 118);
            Avarias_Text.Name = "Avarias_Text";
            Avarias_Text.Size = new Size(297, 37);
            Avarias_Text.TabIndex = 34;
            Avarias_Text.TextChanged += Avarias_Text_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 22F, FontStyle.Italic);
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(113, 37);
            label3.TabIndex = 33;
            label3.Text = "Avarias:";
            // 
            // Ano_Text
            // 
            Ano_Text.BackColor = Color.FromArgb(204, 210, 223);
            Ano_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Ano_Text.Location = new Point(87, 71);
            Ano_Text.Name = "Ano_Text";
            Ano_Text.Size = new Size(112, 37);
            Ano_Text.TabIndex = 32;
            Ano_Text.TextChanged += Ano_Text_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 22F, FontStyle.Italic);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 37);
            label2.TabIndex = 31;
            label2.Text = "Ano:";
            // 
            // Modelo_Text
            // 
            Modelo_Text.BackColor = Color.FromArgb(204, 210, 223);
            Modelo_Text.Font = new Font("Impact", 18F, FontStyle.Italic);
            Modelo_Text.Location = new Point(137, 17);
            Modelo_Text.Name = "Modelo_Text";
            Modelo_Text.Size = new Size(275, 37);
            Modelo_Text.TabIndex = 30;
            Modelo_Text.TextChanged += Modelo_Text_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22F, FontStyle.Italic);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 29;
            label1.Text = "Modelo: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(204, 210, 223);
            textBox1.Font = new Font("Impact", 18F, FontStyle.Italic);
            textBox1.Location = new Point(561, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 37);
            textBox1.TabIndex = 59;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Impact", 22F, FontStyle.Italic);
            label14.Location = new Point(507, 71);
            label14.Name = "label14";
            label14.Size = new Size(48, 37);
            label14.TabIndex = 58;
            label14.Text = "Id:";
            // 
            // Editar_Carro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 143, 143);
            ClientSize = new Size(1079, 575);
            Controls.Add(textBox1);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Controls.Add(Editar);
            Controls.Add(Km_text);
            Controls.Add(label13);
            Controls.Add(Potencia_Text);
            Controls.Add(label12);
            Controls.Add(Internacional_Radio);
            Controls.Add(Nacional_Radio);
            Controls.Add(label11);
            Controls.Add(Velocidade_text);
            Controls.Add(label10);
            Controls.Add(Num_Portas_Text);
            Controls.Add(label9);
            Controls.Add(Combustivel_Text);
            Controls.Add(label8);
            Controls.Add(Chassi_text);
            Controls.Add(label7);
            Controls.Add(Placa_Text);
            Controls.Add(label6);
            Controls.Add(Cor_Text);
            Controls.Add(label5);
            Controls.Add(Valor_Text);
            Controls.Add(label4);
            Controls.Add(Avarias_Text);
            Controls.Add(label3);
            Controls.Add(Ano_Text);
            Controls.Add(label2);
            Controls.Add(Modelo_Text);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editar_Carro";
            Text = "Editar_Carro";
            FormClosing += Editar_Carro_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Editar;
        private TextBox Km_text;
        private Label label13;
        private TextBox Potencia_Text;
        private Label label12;
        private RadioButton Internacional_Radio;
        private RadioButton Nacional_Radio;
        private Label label11;
        private TextBox Velocidade_text;
        private Label label10;
        private TextBox Num_Portas_Text;
        private Label label9;
        private TextBox Combustivel_Text;
        private Label label8;
        private TextBox Chassi_text;
        private Label label7;
        private TextBox Placa_Text;
        private Label label6;
        private TextBox Cor_Text;
        private Label label5;
        private TextBox Valor_Text;
        private Label label4;
        private TextBox Avarias_Text;
        private Label label3;
        private TextBox Ano_Text;
        private Label label2;
        private TextBox Modelo_Text;
        private Label label1;
        private TextBox textBox1;
        private Label label14;
    }
}