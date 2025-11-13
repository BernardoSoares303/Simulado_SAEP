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
    public partial class Editar_Carro : Form
    {
        static Carro c1 = new Carro();
        static Form1 f1 = new Form1();
        static int id;

        public static string conexao = "server=127.0.0.1;Port=3306;database=simulado_saep;uid=root;pwd='';";
        public Editar_Carro()
        {
            InitializeComponent();
        }

        private void Editar_Carro_FormClosing(object sender, FormClosingEventArgs e)
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
            if (Nacional_Radio.Checked == true)
            {
                c1.importado = false;
            }
            else if (Internacional_Radio.Checked == true)
            {
                c1.importado = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(textBox1.Text);
        }
        public static void editar(Carro c1, int id)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string query = @$"update carros set modelo_carro=@modelo_carro, ano_carro=@ano_carro,avarias=@avarias,valor_carro=@valor_carro,cor = @cor,placa= @placa,chassi= @chassi,tipo_combustivel= @tipo_combustivel,qaunt_portas= @qaunt_portas,max_velocidade= @max_velocidade,importado=@importado,potencia=@potencia,km_rodados=@km_rodados where id_carro = @id;";

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
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            editar(c1, id);
            this.Close();
        }

    }
}
