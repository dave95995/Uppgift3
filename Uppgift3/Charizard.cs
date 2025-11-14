namespace Uppgift3
{
	internal class Charizard : FirePokemon
	{
		public Charizard(string name, int level, List<Attack> attacks) : base(name, level, attacks)
		{
		}

		public override void Speak()
		{
			Console.WriteLine($"a Charizard named {Name} says: Fire fire fire fire");
		}
	}
}