using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ClienteRepository
    {
        private IList<Cliente> _clientes = new List<Cliente>();

        public Cliente Insert(Cliente cliente)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._clientes.Add(cliente);
            return cliente;
        }

        public Cliente Update(Cliente cliente)
        {
            this._clientes[this._clientes.IndexOf(cliente)] = cliente;
            return cliente;
        }

        public void Remove(Cliente cliente)
        {
            this._clientes.Remove(cliente);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clientes;
        }

        public IList<Cliente> getAll()
        {
            return _clientes;
        }
    }
}
