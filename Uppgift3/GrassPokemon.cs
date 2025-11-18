namespace Uppgift3
{
	internal abstract class GrassPokemon : Pokemon
	{
		public GrassPokemon(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, ElementType.Grass, attacks, io)
		{
		}

		public override void Speak()
		{
			_io.Print($"{Name} says: grass!");
		}
	}
}