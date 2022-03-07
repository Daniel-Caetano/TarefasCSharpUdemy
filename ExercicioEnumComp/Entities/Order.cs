using ExercicioEnumComp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioEnumComp.Entities
{
    internal class Order
    {
        Client Client { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status;
        public List<OrderItem> Items = new List<OrderItem>();
        public Order(Client cliente, DateTime moment, OrderStatus status)
        {
            Client = cliente;
            Moment = moment;
            Status = status;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public void RemoveItem(string name)
        {
            var product = Items.Find(x =>  x.NameItem() == name) ;
            Items.Remove(product);
        }
        public double TotalPrice()
        {
            return Items.Sum(x => x.SubTotal());
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("ORDER SUMMARY");

            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());

            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());

            sb.AppendLine("Order items: ");
            foreach (var item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: ");
            sb.AppendLine(TotalPrice().ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
