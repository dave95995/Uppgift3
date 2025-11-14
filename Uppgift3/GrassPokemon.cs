namespace Uppgift3
{
	internal abstract class GrassPokemon : Pokemon
	{
		public GrassPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Grass, attacks)
		{
		}

		public override void Speak()
		{
			Console.WriteLine($"{Name} says: Grass Grass");
		}
	}
}