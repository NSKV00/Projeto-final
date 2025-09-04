using Mysqlx.Session;
using Projeto_final.Forms;
using Projeto_final.Forms.Clientes;
using Projeto_final.Forms.Funcionarios;
using Projeto_final.Forms.Veiculos;

namespace Projeto_final
{
    public partial class Home : Form
    {
        //Fields
        private Button currentButton;
        //private Random random;
        private Form activeForm;
        //private int tempIndex;

        //Constructor
        public Home()
        {
            InitializeComponent();
            CloseForm.Visible = false;
        }

        //Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    CloseForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in painelLateral.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.Enabled = true;
                }
            }
        }

        private void OpenForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.painelDesktop.Controls.Add(childForm);
            this.painelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitulo.Text = childForm.Text;
        }


        //private void panel1_Paint_1(object sender, PaintEventArgs e)
        //{
        //    // Cria uma instância do novo formulário
        //    var listarFuncionarios = new Funcionario();

        //    // Exibe o novo formulário
        //    listarFuncionarios.Show();
        //}

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Clientes.Cliente(), sender);
        }

        private void btnVeiculos_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Veiculos.Veiculo(), sender);
        }

        private void btnOS_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.OrdemServico.OS(), sender);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Funcionarios.Funcionario(), sender);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitulo.Text = "HOME";
            currentButton = null;
            CloseForm.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnaleatorio_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Clientes.VerCliente(), sender);
        }
    }
}
