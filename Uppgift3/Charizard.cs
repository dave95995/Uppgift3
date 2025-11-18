namespace Uppgift3
{
	internal sealed class Charizard : FirePokemon
	{
		public Charizard(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, attacks, io)
		{
		}

		public override void Speak()
		{
			_io.Print($"{Name} is a Charizard that says fire fire");
		}
	}
}