namespace Uppgift3
{
	internal class Charmeleon : FirePokemon, IEvolvable
	{
		private readonly int _evolveAtLevel = 6;

		public Charmeleon(string name, int level, List<Attack> attacks) : base(name, level, attacks)
		{
		}

		public Pokemon Evolve()
		{
			return new Charizard(Name, Level, Attacks);
		}

		public override void Speak()
		{
			Console.WriteLine($"a Charmeleon named {Name} says: Fire fire fire");
		}

		public override Pokemon RaiseLevel()
		{
			_ = base.RaiseLevel();
			return Level >= _evolveAtLevel ? Evolve() : this;
		}
	}
}