namespace Uppgift3
{
	internal class Program
	{
		private static void Part1()
		{
			ConsoleUI con = new ConsoleUI();

			List<Attack> attacks = new List<Attack>();
			attacks.Add(new Attack("Flamethrower", ElementType.Fire, 12, con));
			attacks.Add(new Attack("Ember", ElementType.Fire, 6, con));
			attacks.Add(new Attack("Wave", ElementType.Water, 5, con));
			attacks.Add(new Attack("Poison Ivy", ElementType.Grass, 4, con));

			List<Pokemon> pokemons = [];
			pokemons.Add(new Charmander("FireCharm", 2, attacks, con));
			pokemons.Add(new Squirtle("WaterSquirtle", 1, attacks, con));
			pokemons.Add(new Bulbasaur("GrassBulb", 1, attacks, con));

			foreach (var pokemon in pokemons)
			{
				pokemon.RaiseLevel();
				if (pokemon is IEvolvable evolable)
				{
					evolable.Evolve();
				}
				pokemon.Attack();
			}
		}

		public static void Part2()
		{
			ConsoleUI con = new ConsoleUI();

			List<Attack> attacks = new List<Attack>();
			attacks.Add(new Attack("Flamethrower", ElementType.Fire, 12, con));
			attacks.Add(new Attack("Wave", ElementType.Water, 5, con));
			attacks.Add(new Attack("Poison Ivy", ElementType.Grass, 4, con));

			foreach (var attack in attacks.ToList())
			{
				attacks.Add(new LegendaryAttack(attack, con));
			}

			List<Pokemon> pokemons = [];
			pokemons.Add(new Charmander("FireCharm", 10, attacks, con));
			pokemons.Add(new Squirtle("WaterSquirtle", 1, attacks, con));
			pokemons.Add(new Bulbasaur("GrassBulb", 1, attacks, con));

			for (int i = 0; i < pokemons.Count; i++)
			{
				pokemons[i].Speak();
				pokemons[i].Attack();
				pokemons[i].RaiseLevel();

				if (pokemons[i] is IEvolvable evolvable)
				{
					var evolved = evolvable.Evolve();
					pokemons[i] = evolved;
				}
			}
		}

		private static void Main(string[] args)
		{
			ConsoleUI con = new ConsoleUI();

			List<Attack> attacks = new List<Attack>();
			attacks.Add(new Attack("Flamethrower", ElementType.Fire, 12, con));
			Pokemon pokemon = new Charmander("FireCharm", 10, attacks, con);

			for (int i = 0; i < 3; i++)
			{
				pokemon.Speak();
				pokemon.RandomAttack();
				pokemon.RaiseLevel();
				if (pokemon is IEvolvable evolv)
				{
					var evolved = evolv.Evolve();
					pokemon = evolved;
				}
			}
		}
	}
}