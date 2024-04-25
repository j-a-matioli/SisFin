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
        private ClienteRepository _repository;

        public ClienteService()
        {
            _repository = new ClienteRepository();
        }

        public void Insert(int id, TipoPessoa tipoPessoa, string nome, string email)
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

            _repository.Insert(cliente);

        }

        public void Insert(Cliente cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(cliente);

        }

        public Cliente FindById(int id)
        {
            foreach(Cliente c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<Cliente> getAll()
        {
            return _repository.ObterTodos().ToList<Cliente>();
        }

    }
}
