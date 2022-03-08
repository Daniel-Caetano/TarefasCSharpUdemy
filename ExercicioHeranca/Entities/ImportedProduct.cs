using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioHeranca.Entities
{
    internal class ImportedProduct:Product
    {
        public double customsFee { get; set; }

        public double totalPrice()
        {
            return Price+customsFee;
        }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price):base(name, price)
        {
        }
        public ImportedProduct(double customsFee, string name, double price): base(name, price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {customsFee})";
        }
    }
}
