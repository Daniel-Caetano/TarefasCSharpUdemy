using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComp.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        Product Item { get; set; }

        public OrderItem(int quantity, double price, Product item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }
        public double SubTotal()
        {
            return (double)Price * Quantity;
        }
        public string NameItem()
        {
            return Item.Name;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(Item);
            sb.Append("Quantity: ");
            sb.Append(Quantity);
            sb.Append(" Subtotal: $");
            sb.Append(SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
