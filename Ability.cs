using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    internal class Ability : Pokemon
    {
        public Ability(List<string> names, string type, int totalForms) : base(names, type, totalForms)
        {
            
        }
    }
}
