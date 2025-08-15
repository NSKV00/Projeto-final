namespace Projeto_final.Forms
{
    public partial class funcionarios : Form
    {
        public funcionarios()
        {
            InitializeComponent();
        }

        private void funcionários_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Cfuncionarios = new CFuncionarios();
            Cfuncionarios.ShowDialog();
        }
    }
}
