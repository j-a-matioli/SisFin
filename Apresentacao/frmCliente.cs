using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmCliente : Form
    {
        private readonly ClienteService _clienteService;
        public frmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();
            atualizaListaCliente();
        }

        private void frmCliente_Load(object sender, System.EventArgs e)
        {
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();
        }

        private void atualizaListaCliente()
        {
            lstCliente.Items.Clear();
            foreach(Cliente cl in _clienteService.ObterTodos())
            {
                lstCliente.Items.Add(cl.Nome);
            }
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
            
            _clienteService.CadastrarCliente(id, tp, nome, email);
            

            atualizaListaCliente();
        }
    }
}
