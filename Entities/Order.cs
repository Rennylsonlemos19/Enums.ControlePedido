using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_EnumsDesafio.net.Entities.Enums;

namespace POO_EnumsDesafio.net.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)

        {
            Items.Add(item);
        }

        public void RemoveItems( OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("DATA NO MOMENTO: " + Moment.ToString("dd/MM/yyyy HH:MM:ss"));
            sb.AppendLine("SITUAÇÃO DO PEDIDO: " + Status);
            sb.AppendLine("CLIENTE: " + Client);
            sb.AppendLine("PEDIDOS: ");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("c"));

            return sb.ToString();

        }
    }

}
