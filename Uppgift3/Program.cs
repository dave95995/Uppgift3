namespace Uppgift3
{
	internal class Program
	{
		public static readonly Random s_Random = new();

		private static void Main(string[] args)
		{
			List<Attack> attacks = [];

			attacks.Add(new Attack("Flamethrower", ElementType.Fire, 1));
			Charmander c = new("Charmander", 1, attacks);

			c.RaiseLevel();



		}
	}
}
