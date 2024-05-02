using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ContaReceberService
    {
        private ContaReceberRepository _repository;

        public ContaReceberService()
        {
            _repository = new ContaReceberRepository();
        }

        public void Insert(int id, decimal valor, DateTime dtCad, DateTime dtVenc, MeioDePagamento meioPag, EstadoPagamento estadoPag)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var conta = new ContaReceber
            {
                Id = id,
                Valor = valor,
                DataCadastro = dtCad,
                DataVencimento = dtVenc,
                MeioPagamento = MeioDePagamento.DINHEIRO,
                EstadoPagamento = EstadoPagamento.PENDENTE
            };

            _repository.Insert(conta);

        }

        public void Insert(ContaReceber cliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            _repository.Insert(cliente);

        }

        public ContaReceber FindById(int id)
        {
            foreach (ContaReceber c in _repository.getAll())
            {
                if (c.Id == id) return c;
            }
            return null;
        }

        public IEnumerable<ContaReceber> ObterTodos()
        {
            return _repository.ObterTodos();
        }
        public List<ContaReceber> getAll()
        {
            return _repository.ObterTodos().ToList<ContaReceber>();
        }


    }
}
