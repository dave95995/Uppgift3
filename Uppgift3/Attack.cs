namespace Uppgift3
{
	internal class Attack
	{
		private string _name = string.Empty;
		private int _basePower;

		protected readonly IUserIO _io;

		// Detta ska inte kunna ändras utanför konstruktorn.
		public ElementType Type { get; }

		// Subklassen ska kunna använda set på Name
		public string Name
		{
			get => _name;
			protected set
			{
				ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
				_name = value;
			}
		}

		// Subklassen ska kunna använda set på BasePower
		public int BasePower
		{
			get => _basePower;
			protected set
			{
				ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(value));
				_basePower = value;
			}
		}

		public Attack(string name, ElementType type, int basePower, IUserIO io)
		{
			Name = name;
			Type = type;
			BasePower = basePower;
			_io = io;
		}

		public virtual void Use(int level)
		{
			int totalPower = _basePower + level;
			_io.Print($"{Name} hit with a total power of {totalPower}");
		}

		public override string ToString()
		{
			return $"Attack: {Name} BasePower: {BasePower}";
		}
	}
}