namespace Uppgift3
{
	internal class LegendaryAttack : Attack
	{
		public LegendaryAttack(Attack baseAttack) : base(baseAttack.Name, baseAttack.Type, baseAttack.BasePower)
		{
		}

		public override void Use(int level)
		{
			Console.WriteLine($"{Name} unleashes its potential with total power {BasePower + (level * 2)}");
		}
	}
}