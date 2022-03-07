using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnumComp.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {

            var sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(", ");
            sb.Append(Price.ToString("F2" , CultureInfo.InvariantCulture));
            sb.Append(", ");

            return sb.ToString();
        }
    }
}
