using System;
using System.Text;
using System.Collections.Generic;
using ExercicioProposto.Entities.Enum;

namespace ExercicioProposto.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client client  { get; set; }
        public List<Orderitem> orderitems { get; set; } = new List<Orderitem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            this.client = client;
        }

        public void AddItem(Orderitem item)
        {
            orderitems.Add(item);
        }

        public void RemoveItem(Orderitem item)
        {
            orderitems.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach (Orderitem item in orderitems)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items:");
            foreach (Orderitem item in orderitems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString());
            return sb.ToString();
        }
    }
}
