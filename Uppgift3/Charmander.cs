namespace Uppgift3
{
	internal class Charmander : FirePokemon, IEvolvable
	{
		public Charmander(string name, int level, List<Attack> attacks) : base(name, level, attacks)
		{
		}

		public void Evolve()
		{
			String oldName = this.Name;
			Name = "Charmeleon";
			Level += 10;
			String output = $"{oldName} is evolving... Now it is a {Name} and its level is {Level}";
			Console.WriteLine(output);
		}
	}
}