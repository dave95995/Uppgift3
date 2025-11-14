namespace Uppgift3
{
	internal abstract class WaterPokemon : Pokemon
	{
		public WaterPokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Water, attacks)
		{
		}

		public override void Speak()
		{
			Console.WriteLine($"{Name} says: Splash Splash");
		}
	}
}