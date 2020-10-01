using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Details
    {
        public string front_default { get; set; }
        public string back_default { get; set; }

        public int height { get; set; }
        public int weight { get; set; }

        public override string ToString()
        {
            return $"weight: {weight}\n" +
                    $"height: {height}";
        }
    }
}
