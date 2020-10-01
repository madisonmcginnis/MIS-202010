using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Pokemon
    {
        public Info info { get; set; }

        public List<Pokemons> results { get; set; }
    }

    public class Pokemons
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Info
    {
        public int count { get; set; }
        
        public string next { get; set; }
        public string previous { get; set; }
    }
}
