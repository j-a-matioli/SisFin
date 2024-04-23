using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Negocio;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService cliServ = new ClienteService();
            ProdutoService prodServ = new ProdutoService();
            VendaService vendaServ = new VendaService();
            ItemVendaService itemVendaServ = new ItemVendaService();

            //Insere alguns clientes
            cliServ.Insert(1, TipoPessoa.PESSOA_FISICA, "Marcos Mariota", "mariota@exemplo.com");
            cliServ.Insert(2, TipoPessoa.PESSOA_FISICA, "Carla Kambota", "caka@capisce.com");
            cliServ.Insert(3, TipoPessoa.PESSOA_FISICA, "Microsoft Corp.", "ms@microsoft.com");
            Console.WriteLine("CLIENTES");
            foreach (Cliente cliente in cliServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",
                    cliente.Id, cliente.Nome, cliente.tipoPessoa, cliente.Email);
            }



            //Insere alguns produtos
            prodServ.Insert(1, "Coca Cola", 4.75);
            prodServ.Insert(2, "Cerveja Corona", 6.35);
            prodServ.Insert(3, "Macarrão sem gluten Barilla nr.7", 16.90);
            prodServ.Insert(4, "Sistema Operacional Ruinodous", 2590.75);
            prodServ.Insert(5, "Office 2029", 1389.76);

            Console.WriteLine("\nPRODUTOS");
            foreach (Produto produto in prodServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2}",
                    produto.Id, produto.Nome, produto.Preco);
            }

            //Insere algumas vendas
            Console.WriteLine("\nVENDAS");
            vendaServ.Insert(1, cliServ.FindById(1), DateTime.Now, "Primeira venda, uhul", 0, 550.79);
            //Itens desta venda
            itemVendaServ.Insert(1, vendaServ.FindById(1), prodServ.FindById(1), 12, 0, 4.75);
            itemVendaServ.Insert(2, vendaServ.FindById(1), prodServ.FindById(2), 24, 0, 6.25);
            itemVendaServ.Insert(3, vendaServ.FindById(1), prodServ.FindById(3), 2, 0, 16.90);


            vendaServ.Insert(2, cliServ.FindById(3), DateTime.Now, "Venda novo OS Ruindows", 0, 99874.50);
            itemVendaServ.Insert(4, vendaServ.FindById(2), prodServ.FindById(4), 1550, 0, 2590.75);
            itemVendaServ.Insert(5, vendaServ.FindById(2), prodServ.FindById(5), 1350, 0, 1389.76);

            foreach (Venda v in vendaServ.getAll())
            {
                Console.WriteLine("{0} - {1} - {2:0.00}",
                    v.Instante.Date, v.Cliente.Nome, v.ValorTotal);
                Console.WriteLine("------- ITENS ------------");
                     foreach (ItemVenda itemVenda in itemVendaServ.getItensPorVendaId(v.Id))
                    {
                        Console.WriteLine("\t{0} - {1} - {2}",
                        itemVenda.Produto.Nome, itemVenda.Quantidade,
                        itemVenda.Preco);
                }
                Console.WriteLine(Environment.NewLine);
            }



             Console.ReadKey();
        }
    }
}
