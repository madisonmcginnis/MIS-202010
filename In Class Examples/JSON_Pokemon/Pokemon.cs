using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Pokemon
    {
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

    public class Sprites
    {
        public int height { get; set; }
        public int weight { get; set; }
        public int id { get; set; }

        public override string ToString()
        {
            return $"weight: {weight}\n" +
                    $"height: {height}";
        }

        public string front_default { get; set; }
        public string back_default { get; set; }
    }
}