using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_SAEP
{
    public partial class Cadastrar_Carro : Form
    {

        static Carro c1 = new Carro();

        public string conexao = "server=127.0.0.1;uid=root;pwd='';database=simulado_saep";

        public Cadastrar_Carro(Form1 f1)
        {
            InitializeComponent();
        }

        private void Cadastrar_Carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();

            f1.Show();
        }

        private void Modelo_Text_TextChanged(object sender, EventArgs e)
        {
            c1.modelo_carro = Modelo_Text.Text;
        }

        private void Ano_Text_TextChanged(object sender, EventArgs e)
        {
            c1.ano_carro = int.Parse(Ano_Text.Text);
        }

        private void Avarias_Text_TextChanged(object sender, EventArgs e)
        {
            c1.avarias = Avarias_Text.Text;
        }

        private void Valor_Text_TextChanged(object sender, EventArgs e)
        {
            c1.valor_carro = double.Parse(Valor_Text.Text);
        }

        private void Cor_Text_TextChanged(object sender, EventArgs e)
        {
            c1.cor = Cor_Text.Text;
        }

        private void Placa_Text_TextChanged(object sender, EventArgs e)
        {
            c1.placa = Placa_Text.Text;
        }

        private void Chassi_text_TextChanged(object sender, EventArgs e)
        {
            c1.chassi = Chassi_text.Text;
        }

        private void Combustivel_Text_TextChanged(object sender, EventArgs e)
        {
            c1.tipo_combustivel = Combustivel_Text.Text;
        }

        private void Num_Portas_Text_TextChanged(object sender, EventArgs e)
        {
            c1.qaunt_portas = int.Parse(Num_Portas_Text.Text);
        }

        private void Velocidade_text_TextChanged(object sender, EventArgs e)
        {
            c1.max_velocidade = double.Parse(Velocidade_text.Text);
        }

        private void Potencia_Text_TextChanged(object sender, EventArgs e)
        {
            c1.potencia = int.Parse(Potencia_Text.Text);
        }

        private void Km_text_TextChanged(object sender, EventArgs e)
        {
            c1.km_rodados = double.Parse(Km_text.Text);
        }

        private void Nacional_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if(Nacional_Radio.Checked == true)
            {
                c1.importado = false;
            }else if (Internacional_Radio.Checked == true)
            {
                c1.importado = true;
            }
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {

        }

        public static void cadastrar(Carro c1)
        {
              
        }
    }
}
