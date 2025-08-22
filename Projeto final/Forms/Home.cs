using Projeto_final.Forms;

namespace Projeto_final
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var listarClientes = new Clientes();
            listarClientes.Show();
        }

        private void Veiculos_Click(object sender, EventArgs e)
        {
            var listarVeiculos = new Veiculos();
            listarVeiculos.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MenuLateral_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var listarClientes = new Clientes();
            listarClientes.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            // Cria uma instância do novo formulário
            var listarFuncionarios = new funcionarios();

            // Exibe o novo formulário
            listarFuncionarios.Show();
        }
    }
}
