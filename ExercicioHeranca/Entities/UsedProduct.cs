using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca.Entities
{
    internal class UsedProduct:Product  
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price):base(name, price)
        {
        }
        public UsedProduct(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate})";
        }
    }
}
