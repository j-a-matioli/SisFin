using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public enum TipoPessoa { PESSOA_FISICA = 1, PESSOA_JURIDICA = 2 };
    public enum MeioDePagamento {PIX=1, BOLETO=2, 
                                CARTAO_CREDITO=3, 
                                CARTAO_DEBITO=4,DINHEIRO=5 };
    public enum EstadoPagamento { PENDENTE=1, QUITADO=2, CANCELADO=3};
}
