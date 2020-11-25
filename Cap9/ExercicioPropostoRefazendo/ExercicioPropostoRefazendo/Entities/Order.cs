using ExercicioPropostoRefazendo.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPropostoRefazendo.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus orderStatus { get; set; }
        public Client client { get; set; }
        public List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            this.orderStatus = orderStatus;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            orderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItem.Remove(item);
        }

        public double Total()
        {
            double sun = 0;
            foreach (OrderItem item in orderItem)
            {
                sun += item.SubTotal();
            }
            return sun;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + (Moment));
            sb.AppendLine("Order status: " + (orderStatus));
            sb.AppendLine("Client: " + (client.Name) + ", " + (client.BirthDate) + ", " + (client.Email));
            Console.WriteLine("Order items:");
            foreach (OrderItem item in orderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: " + "R$" + (Total()));
            return sb.ToString();
        }
    }

}
