using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using Negocio;

namespace Apresentacao
{
    public partial class frmProduto : Form
    {
        private readonly ProdutoService _produtoService;
        private List<Produto> lstProduto = new List<Produto>();

        public frmProduto()
        {
            InitializeComponent();
            _produtoService = new ProdutoService();

            dgProduto.Columns.Add("Id", "ID");
            dgProduto.Columns.Add("Nome", "NOME");
            dgProduto.Columns.Add("Preco", "PREÇO");

            lstProduto = _produtoService.getAll();

            geraAleatorios();

        }

        private void geraAleatorios()
        {
            for (int n = 1; n <= 10; n++)
            {
                Produto c = new Produto();
                c.Id = n;
                c.Nome = "Produto numero " + n.ToString();
                c.Preco = 28;
                _produtoService.CadastrarProduto(c);
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // NOVO ====================
            dgProduto.ColumnCount = 3;
            dgProduto.AutoGenerateColumns = false;
            dgProduto.Columns[0].Width = 20;
            dgProduto.Columns[0].HeaderText = "ID";
            dgProduto.Columns[0].DataPropertyName = "Id";
            //dgProduto.Columns[0].Visible = false;
            dgProduto.Columns[1].Width = 275;
            dgProduto.Columns[1].HeaderText = "NOME";
            dgProduto.Columns[1].DataPropertyName = "Nome";
            dgProduto.Columns[2].Width = 100;
            dgProduto.Columns[2].HeaderText = "PREÇO";
            dgProduto.Columns[2].DataPropertyName = "preco";

            dgProduto.AllowUserToAddRows = false;
            dgProduto.AllowUserToDeleteRows = false;
            dgProduto.MultiSelect = false;
            dgProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizaListaProduto();
        }

        private void atualizaListaProduto()
        {
            dgProduto.DataSource = _produtoService.getAll();
            dgProduto.Refresh();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);

            _produtoService.CadastrarProduto(id, nome, preco);

            atualizaListaProduto();

        }
    }
}
