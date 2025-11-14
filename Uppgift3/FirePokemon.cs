namespace Uppgift3
{
	internal abstract class FirePokemon : Pokemon
	{
		public FirePokemon(string name, int level, List<Attack> attacks) : base(name, level, ElementType.Fire, attacks)
		{
		}

		public override void Speak()
		{
			Console.WriteLine($"a FirePokemon named {Name} says: Fire fire");
		}
	}
}