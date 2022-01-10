using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public string name { get; set; }
        public decimal weight { get; set; }
        public List<Types> types { get; set; }
        public List<Moves> moves { get; set; }
    }
}
