using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
        }
        public string GetAisle()
        {
            string priceAsString = Convert.ToString(Price);
            int decimalLocation = priceAsString.IndexOf(".");

            Aisle = $"{Manufacturer[0]}";

            return $"{Aisle.ToUpper()}: {priceAsString.Substring(0,decimalLocation)}";

        }
        public override string ToString()
        {
            return $"{Manufacturer} - {Name}";
        }
    }
}
