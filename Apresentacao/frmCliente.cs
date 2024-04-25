using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmCliente : Form
    {
        private readonly ClienteService _clienteService;
        private List<Cliente> lstCliente = new List<Cliente>();
        public frmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService();

            dgCliente.Columns.Add("Id", "ID");
            dgCliente.Columns.Add("Nome", "NOME");
            dgCliente.Columns.Add("tipoPesso", "TIPO PESSOA");
            dgCliente.Columns.Add("email", "EMAIL");

            lstCliente = _clienteService.getAll();

            geraAleatorios();
        }

        private void geraAleatorios()
        {
            for (int n = 1; n <= 10; n++)
            {
                Cliente c = new Cliente();
                c.Id = n;
                c.Nome = "Cliente numero " + n.ToString();
                c.Email = "cl" + n.ToString() + "@exemplo.com.br";
                c.tipoPessoa = (n % 2) == 0 ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
                _clienteService.Insert(c);
            }
        }

        private void frmCliente_Load(object sender, System.EventArgs e)
        {
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            // NOVO ====================
            dgCliente.ColumnCount = 4;
            dgCliente.AutoGenerateColumns = false;
            dgCliente.Columns[0].Width = 20;
            dgCliente.Columns[0].HeaderText = "ID";
            dgCliente.Columns[0].DataPropertyName = "Id";
            //dgCliente.Columns[0].Visible = false;
            dgCliente.Columns[1].Width = 275;
            dgCliente.Columns[1].HeaderText = "NOME";
            dgCliente.Columns[1].DataPropertyName = "Nome";
            dgCliente.Columns[2].Width = 300;
            dgCliente.Columns[2].HeaderText = "EMAIL";
            dgCliente.Columns[2].DataPropertyName = "email";
            dgCliente.Columns[3].Width = 100;
            dgCliente.Columns[3].HeaderText = "TIPO";
            dgCliente.Columns[3].DataPropertyName = "tipoPessoa";

            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.MultiSelect = false;
            dgCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizaListaCliente();

        }

        private void atualizaListaCliente()
        {
            dgCliente.DataSource = _clienteService.getAll();
            dgCliente.Refresh();
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;
            
            _clienteService.Insert(id, tp, nome, email);
            

            atualizaListaCliente();
        }
    }
}
