namespace Uppgift3
{
	internal class WaterPokemon : Pokemon
	{
		public WaterPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Water, attacks)
		{
		}
	}
}