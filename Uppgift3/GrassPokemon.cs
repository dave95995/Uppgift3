using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
	internal class GrassPokemon : Pokemon
	{
		public GrassPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Grass, attacks)
		{
		}
	}
}
