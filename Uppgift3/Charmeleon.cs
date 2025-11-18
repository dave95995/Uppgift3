namespace Uppgift3
{
	internal class Charmeleon : FirePokemon, IEvolvable

	{
		private int _evolveAtLevel = 12;

		public Charmeleon(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, attacks, io)
		{
		}

		public override void Speak()
		{
			_io.Print($"{Name} is a Charmeleon that says fire");
		}

		public Pokemon Evolve()
		{
			if (Level >= _evolveAtLevel)
			{
				_io.Print($"{Name} is evolving...");
				return new Charizard(Name, Level, _attacks, _io);
			}
			return this;
		}
	}
}