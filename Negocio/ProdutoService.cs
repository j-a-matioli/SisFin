using System.Collections.Generic;
using System.Linq;
using Dados;

namespace Negocio
{
    public class ProdutoService
    {
        private readonly ProdutoRepository _repository;

        public ProdutoService()
        {
            _repository = new ProdutoRepository();
        }

        public void CadastrarProduto(int id, string nome, decimal preco)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var Produto = new Produto
            {
                Id = id,                
                Nome = nome,
                Preco = preco
            };

            _repository.Adicionar(Produto);

        }

        public void CadastrarProduto(Produto produto)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Adicionar(produto);

        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Produto> getAll()
        {
            return _repository.ObterTodos().ToList<Produto>();
        }

    }

}

