namespace Uppgift3
{
	internal abstract class FirePokemon : Pokemon
	{
		public FirePokemon(string name, int level, List<Attack> attacks, IUserIO io) : base(name, level, ElementType.Fire, attacks, io)
		{
		}

		public override void Speak()
		{
			_io.Print($"{Name} says: fire!");
		}
	}
}