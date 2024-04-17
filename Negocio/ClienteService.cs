using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;

namespace Negocio
{
    public class ClienteService
    {
        private readonly ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void CadastrarCliente(int id, TipoPessoa tipoPessoa, string nome, string email)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente
            {
                Id = id,
                tipoPessoa = tipoPessoa,
                Nome = nome,
                Email = email
            };

            _repository.Adicionar(cliente);

        }

        public void CadastrarCliente(Cliente cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Adicionar(cliente);

        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

    }
}
