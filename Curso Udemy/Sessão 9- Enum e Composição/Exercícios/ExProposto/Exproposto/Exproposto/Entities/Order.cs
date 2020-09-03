using Exproposto.Entities.Enuns;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exproposto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client OrderClient { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client orderClient)
        {
            Moment = moment;
            Status = status;
            OrderClient = orderClient;
        }

        public void AddItem(OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Item.Add(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem itens in Item)
            {
                total += itens.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToLocalTime());
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + OrderClient);
            sb.AppendLine("Order itens:");

            foreach (OrderItem itens in Item)
            {
                sb.AppendLine(itens.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
