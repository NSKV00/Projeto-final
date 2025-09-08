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
        private Form activeForm;

        //Constructor
        public Home()
        {
            InitializeComponent();
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
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }
    }
}

