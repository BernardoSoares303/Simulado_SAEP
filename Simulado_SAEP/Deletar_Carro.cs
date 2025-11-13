using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simulado_SAEP
{
    public partial class Deletar_Carro : Form
    {
        public static string conexao = "server=127.0.0.1;Port=3307;database=simulado_saep;uid=root;pwd='';";
        static Form1 f1 = new Form1();
        static int id;
        public Deletar_Carro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletar(id);
            this.Close();
        }

        public static void deletar(int id)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                string query = "DELETE FROM carros WHERE id_carro = @id;";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Carro deletado com sucesso!", "Sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum carro encontrado com esse ID.", "Aviso");
                    }
                }
            }
        }

        private void Deletar_Carro_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            f1.Show();
        }
    }
}
