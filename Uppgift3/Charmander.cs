namespace Uppgift3
{
	internal class Charmander : FirePokemon, IEvolvable
	{
		private readonly int _evolveAtLevel = 4;

		public Charmander(string name, int level, List<Attack> attacks) : base(name, level, attacks)
		{
		}

		public Pokemon Evolve()
		{
			return new Charmeleon(Name, Level, Attacks);
		}

		public override void Speak()
		{
			Console.WriteLine($"a Charmander named {Name} says: Fire fire");
		}

		public override Pokemon RaiseLevel()
		{
			_ = base.RaiseLevel();
			return Level >= _evolveAtLevel ? Evolve() : this;
		}


		/*
		public void Evolve()
		{
			String oldName = this.Name;
			Name = "Charmeleon";
			Level += 10;
			String output = $"{oldName} is evolving... Now it is a {Name} and its level is {Level}";
			Console.WriteLine(output);
		}
		*/
	}
}