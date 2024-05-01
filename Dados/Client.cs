using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Client
    {
        public int Id { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public Client()
        {
        }

        public Client(int id, string cpf_Cnpj, string razaoSocial)
        {
            Id = id;
            Cpf_Cnpj = cpf_Cnpj;
            RazaoSocial = razaoSocial;
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   Id == client.Id &&
                   Cpf_Cnpj == client.Cpf_Cnpj &&
                   RazaoSocial == client.RazaoSocial;
        }

        public override int GetHashCode()
        {
            int hashCode = -815749117;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cpf_Cnpj);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RazaoSocial);
            return hashCode;
        }
    }
}
