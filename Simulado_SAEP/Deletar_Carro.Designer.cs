namespace Simulado_SAEP
{
    partial class Deletar_Carro
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 60F, FontStyle.Italic);
            label1.Location = new Point(21, 228);
            label1.Name = "label1";
            label1.Size = new Size(123, 98);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Impact", 55F, FontStyle.Italic);
            textBox1.Location = new Point(150, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 97);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Impact", 50F, FontStyle.Italic);
            button1.Location = new Point(412, 412);
            button1.Name = "button1";
            button1.Size = new Size(259, 107);
            button1.TabIndex = 2;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Deletar_Carro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(143, 143, 143);
            ClientSize = new Size(1079, 575);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Deletar_Carro";
            Text = "Deletar_Carro";
            FormClosing += Deletar_Carro_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}