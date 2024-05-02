using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceberRepository
    {
        private IList<ContaReceber> _contas = new List<ContaReceber>();

        public ContaReceber Insert(ContaReceber conta)
        {
            // Aqui você poderia inserir o cliente em um banco de dados
            // Para simplificar, estamos apenas adicionando a uma lista em memória
            this._contas.Add(conta);
            return conta;
        }

        public ContaReceber Update(ContaReceber conta)
        {
            this._contas[this._contas.IndexOf(conta)] = conta;
            return conta;
        }

        public void Remove(ContaReceber conta)
        {
            this._contas.Remove(conta);
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _contas;
        }

        public IList<ContaReceber> getAll()
        {
            return _contas;
        }

    }
}
