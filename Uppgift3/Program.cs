namespace Uppgift3
{
	internal class Program
	{
		public static readonly Random s_Random = new();

		public static void Part1()
		{
			List<Attack> attacks =
			[
				new Attack("Flamethrower", ElementType.Fire, 12),
				new Attack("Ember", ElementType.Fire, 6),
				new Attack("Poison Ivy", ElementType.Grass, 8),
				new Attack("Wave", ElementType.Water, 4),
			];

			List<Pokemon> pokemons = [
				new Charmander("Charmander_1", 1, attacks),
				new Squirtle("Squirt_1", 2, attacks),
				new Bulbasaur("Bulba_1", 4, attacks),
				new Charmander("Charmander_2", 3, attacks),
			];

			foreach (Pokemon pokemon in pokemons)
			{
				Console.WriteLine(pokemon);
				Console.WriteLine("Called RaiseLevel()");
				_ = pokemon.RaiseLevel();
				pokemon.RandomAttack();
				//if (pokemon is IEvolvable evolv)
				//{
				//	evolv.Evolve();
				//}
				Console.WriteLine();
			}
		}

		public static void Part2()
		{
			List<Attack> attacks =
			[
				new Attack("Flamethrower", ElementType.Fire, 12),
				new Attack("Poison Ivy", ElementType.Grass, 8),
				new Attack("Wave", ElementType.Water, 4),
			];

			List<Attack> legendaryAttacks = [];
			foreach (Attack attack in attacks)
			{
				legendaryAttacks.Add(new LegendaryAttack(attack));
			}

			List<Pokemon> pokemons = [
				new Charmander("Nisse", 1, legendaryAttacks),
				new Squirtle("Pelle", 2, legendaryAttacks),
				new Bulbasaur("Anna", 4, legendaryAttacks),
				new Charmander("Gunilla", 3, legendaryAttacks),

			];

			for (int c = 1; c < 4; c++)
			{
				Console.WriteLine($"Run {c}");
				for (int i = 0; i < pokemons.Count; i++)
				{
					pokemons[i] = pokemons[i].RaiseLevel();
					pokemons[i].Speak();
					pokemons[i].Attack();
					Console.WriteLine();
				}
				Console.WriteLine();
			}
		}

		private static void Main(string[] args)
		{
			Part2();
		}
	}
}