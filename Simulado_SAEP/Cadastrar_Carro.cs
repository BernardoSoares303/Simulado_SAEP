using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_SAEP
{
    public partial class Cadastrar_Carro : Form
    {

        static Carro c1 = new Carro();
        static Form1 f1 = new Form1();

        public static string conexao = "server=127.0.0.1;Port=3306;database=simulado_saep;uid=root;pwd='';";

        public Cadastrar_Carro(Form1 f1)
        {
            InitializeComponent();
        }

        private void Cadastrar_Carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
            cadastrar(c1);
            this.Close();
        }

        public static void cadastrar(Carro c1)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string query = @"insert into carros (modelo_carro, ano_carro,avarias,valor_carro,cor,placa,chassi,tipo_combustivel,qaunt_portas,max_velocidade,importado,potencia,km_rodados) values 
                (@modelo_carro, @ano_carro,@avarias,@valor_carro,@cor,@placa,@chassi,@tipo_combustivel,@qaunt_portas,@max_velocidade,@importado,@potencia,@km_rodados);";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@modelo_carro", c1.modelo_carro);
                cmd.Parameters.AddWithValue("@ano_carro", c1.ano_carro);
                cmd.Parameters.AddWithValue("@avarias", c1.avarias);
                cmd.Parameters.AddWithValue("@valor_carro", c1.valor_carro);
                cmd.Parameters.AddWithValue("@cor", c1.cor);
                cmd.Parameters.AddWithValue("@placa", c1.placa);
                cmd.Parameters.AddWithValue("@chassi", c1.chassi);
                cmd.Parameters.AddWithValue("@tipo_combustivel", c1.tipo_combustivel);
                cmd.Parameters.AddWithValue("@qaunt_portas", c1.qaunt_portas);
                cmd.Parameters.AddWithValue("@max_velocidade", c1.max_velocidade);
                cmd.Parameters.AddWithValue("@importado", c1.importado);
                cmd.Parameters.AddWithValue("@potencia", c1.potencia);
                cmd.Parameters.AddWithValue("@km_rodados", c1.km_rodados);

                cmd.ExecuteNonQuery();
                
            }
        }
    }
}
