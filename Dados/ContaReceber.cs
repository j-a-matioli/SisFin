using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ContaReceber
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRecebimento { get; set; }
        public decimal ValorRecebido { get; set; }
        public MeioDePagamento MeioPagamento { get; set; }
        public EstadoPagamento EstadoPagamento { get; set; }

        public ContaReceber()
        {
        }

        public ContaReceber(int id, decimal valor, DateTime dataCadastro, DateTime dataVencimento, MeioDePagamento meioPagamento, EstadoPagamento estadoPagamento)
        {
            Id = id;
            Valor = valor;
            DataCadastro = dataCadastro;
            DataVencimento = dataVencimento;
            MeioPagamento = meioPagamento;
            EstadoPagamento = estadoPagamento;
        }

        public override bool Equals(object obj)
        {
            return obj is ContaReceber receber &&
                   Id == receber.Id &&
                   Valor == receber.Valor &&
                   DataCadastro == receber.DataCadastro &&
                   DataVencimento == receber.DataVencimento &&
                   DataRecebimento == receber.DataRecebimento &&
                   ValorRecebido == receber.ValorRecebido &&
                   MeioPagamento == receber.MeioPagamento &&
                   EstadoPagamento == receber.EstadoPagamento;
        }

        public override int GetHashCode()
        {
            int hashCode = -626096533;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            hashCode = hashCode * -1521134295 + DataCadastro.GetHashCode();
            hashCode = hashCode * -1521134295 + DataVencimento.GetHashCode();
            hashCode = hashCode * -1521134295 + DataRecebimento.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorRecebido.GetHashCode();
            hashCode = hashCode * -1521134295 + MeioPagamento.GetHashCode();
            hashCode = hashCode * -1521134295 + EstadoPagamento.GetHashCode();
            return hashCode;
        }
    }
}
