namespace Uppgift3
{
	internal abstract class WaterPokemon : Pokemon
	{
		public WaterPokemon(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, ElementType.Water, attacks, io)
		{
		}

		public override void Speak()
		{
			_io.Print($"{Name} says: water!");
		}
	}
}