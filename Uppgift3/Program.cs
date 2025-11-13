namespace Uppgift3
{
	/*

	När du skapar en Pokémon och försöker komma åt dess fält direkt – fungerar det? Varför
	eller varför inte?

		Använder publika properties och protected setters

	Om du senare vill lägga till en ny egenskap som gäller för alla Grass-typ Pokémon, var bör
	du lägga den för att undvika repetition?

		I GrassPokemon-klassen

	Om den nya egenskapen istället ska gälla för alla Pokémon, var är rätt plats att definiera
	den?

		I Pokemon-klassen

	Vad händer om du försöker lägga till en Charmander i en lista som bara tillåter
	WaterPokemon?

		Ger fel, endast pokemeons från WaterPokemon eller dess sub-klasser (Squirtle) är tillåtna.

	Du vill lagra olika typer av Pokémon – Charmander, Squirtle och Bulbasaur – i samma lista.
	Vilken typ ska listan ha för att det ska fungera?

		Pokemon

	När du loopar genom listan och anropar Attack(), vad är det som gör att rätt
	attackbeteende körs för varje Pokémon?

		Här valde jag att lägga till en kontroll vill tilldelning av listan i Pokemonklassen
		där endast attacker av samma typ som Pokemon-objektet tilldelas
		_attacks = value.Where(a => a.Type == Type).ToList();

	Om du skapar en metod som bara finns på Bulbasaur, varför kan du inte anropa den direkt
	när den ligger i en List<Pokemon>? Hur skulle du ändå kunna komma åt den?

			foreach (Pokemon pokemon in pokemons)
			{
				if (pokemon is Bulbasaur bulb)
				{
					bulb.TakeNap();
				} else
				{
					Console.WriteLine($"{pokemon.Name} is not a Bulbasaur");
				}
			}

			Om pokemon är av typen Bulbasaur så "casta" pokemon och spara i bulb

	*/

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

			foreach (var pokemon in pokemons)
			{
				Console.WriteLine(pokemon);
				Console.WriteLine("Called RaiseLevel()");
				pokemon.RaiseLevel();
				pokemon.RandomAttack();
				if (pokemon is IEvolvable evolv)
				{
					evolv.Evolve();
				}
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


			List<Attack> legendaryAttacks = new List<Attack>();
			foreach (var attack in attacks)
			{
				legendaryAttacks.Add(new LegendaryAttack(attack));
			}


			new Charmander("Charmander_1", 2, attacks).RandomAttack();
			new Charmander("Charmander_1", 2, legendaryAttacks).RandomAttack();

		}
		private static void Main(string[] args)
		{

			//Part1();
			Part2();

		}
	}
}