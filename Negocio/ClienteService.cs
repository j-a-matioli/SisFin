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

        public void CadastrarCliente(int id, string nome, string email)
        {
            // Validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var cliente = new Cliente
            {
                Id = id,
                Nome = nome,
                Email = email
            };

            _repository.Adicionar(cliente);

        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }

    }
}
