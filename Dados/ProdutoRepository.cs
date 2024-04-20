using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ProdutoRepository
    {
        private static List<Produto> _produtos = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtos;
        }

    }
}
