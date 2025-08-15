using Projeto_final.Forms.Clientes;

namespace Projeto_final.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ccliente = new CClientes();
            Ccliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Dcliente = new DClientes();
            Dcliente.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
