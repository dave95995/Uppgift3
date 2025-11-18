namespace Uppgift3
{
	internal class LegendaryAttack : Attack
	{
		public LegendaryAttack(Attack baseAttack, IUserIO io) : base(baseAttack.Name, baseAttack.Type, baseAttack.BasePower, io)
		{
		}

		public override void Use(int level)
		{
			_io.Print($"{Name} unleashes its potential with toal power {BasePower + level * 2}");
		}
	}
}