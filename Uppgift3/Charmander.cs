namespace Uppgift3
{
	internal class Charmander : FirePokemon, IEvolvable
	{
		private int _evolveAtLevel = 11;

		public Charmander(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, attacks, io)
		{
		}

		/*
		public void Evolve()
		{
			string oldName = Name;
			Name = "Charmeleon";
			Level += 10;
			Console.WriteLine($"{Name} is evolving... Now it is a {Name} and its level is 11");
		}
		*/

		public Pokemon Evolve()
		{
			if (Level >= _evolveAtLevel)
			{
				_io.Print($"{Name} is evolving...");
				return new Charmeleon(Name, Level, _attacks, _io);
			}
			return this;
		}
	}
}