using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_EnumsDesafio.net.Entities.Enums;
using POO_EnumsDesafio.net.Entities;

namespace POO_EnumsDesafio.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRE COM OS DADOS DO CLIENTE: ");
            Console.Write("NOME: ");
            String nome = Console.ReadLine();
            Console.Write("E-MAIL: ");
            string email = Console.ReadLine();
            Console.Write("DATA DE NASCIMENTO (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nENTRE COM DADOS DO PEDIDO: ");
            Console.Write("STATUS DO PEDIDO: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            Client client = new Client(nome, email, date);
            Order order = new Order(DateTime.Now, status,client);

            Console.Write("QUANTOS ITEM ESTAO NESSE PEDIDO: ");
            int n  = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nENTRE COM OS DADOS DO #{i}");
                Console.Write("NOME DO PRODUTO: ");
                string pdtnome = Console.ReadLine();
                Console.Write("PREÇO DO PRODUTO: ");
                double preco = double.Parse(Console.ReadLine());

                Product product = new Product(pdtnome,preco );

                Console.Write("QUANTIDADE: ");
                int qtd = int.Parse(Console.ReadLine());

                OrderItem ordemitem = new OrderItem(qtd,preco,product);

               order.AddItem(ordemitem);
                

            }
            Console.WriteLine();
            Console.WriteLine("RESUMO DO PEDIDO: ");
            Console.WriteLine(order);
            Console.ReadKey();
            


        }
    }
}
