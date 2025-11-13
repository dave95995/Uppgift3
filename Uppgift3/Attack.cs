namespace Uppgift3
{
	internal class Attack
	{
		private string _name = string.Empty;
		private int _basePower;

		/*
		* The element type of the attack.
		* The property is read-only.
		*/
		public ElementType Type { get; }

		/*
		* The name of the attack, can not be null or empty.
		* The value can only be modified within this class or its derived classes.
		*/
		public string Name
		{
			get => _name;
			protected set
			{
				ArgumentException.ThrowIfNullOrEmpty(value, nameof(value));
				_name = value;
			}
		}

		/*
		* The base power of the attack, can not zero or negative.
		* The value can only be modified within this class or its derived classes.
		*/
		public int BasePower
		{
			get => _basePower;
			protected set
			{
				ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
				_basePower = value;
			}
		}

		public Attack(string name, ElementType type, int basePower)
		{
			Name = name;
			Type = type;
			BasePower = basePower;
		}

		public void Use(int level)
		{
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero(level);
			int totalPower = BasePower + level;
			string output = $"{Name} hit with a total power of {totalPower}";
			Console.WriteLine(output);
		}
	}
}