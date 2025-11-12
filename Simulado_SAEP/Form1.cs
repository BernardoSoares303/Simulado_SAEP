namespace Simulado_SAEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cadastrar_Carro_Click(object sender, EventArgs e)
        {
            Cadastrar_Carro cadastrar_Carro = new Cadastrar_Carro(this);
            this.Hide();

            cadastrar_Carro.Show();
        }

        private void Editar_Carros_Click(object sender, EventArgs e)
        {

        }

        private void Excluir_Carros_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Carros_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
