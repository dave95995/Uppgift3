namespace Uppgift3
{
	internal abstract class Pokemon
	{
		private string _name = string.Empty;
		private int _level;
		private List<Attack> _attacks = [];

		/*
			The element type for the pokemon.
			The property is read-only.
		*/
		public ElementType Type { get; }

		/*
			The name of the pokemon, can not be null or contain only white space.
			The name must be between 2 and 15 characters.
			The value can only be modified within this class or its derived classes.
		*/

		public string Name
		{
			get => _name;
			protected set
			{
				ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
				ArgumentOutOfRangeException.ThrowIfLessThan(value.Length, 2);
				ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Length, 15);
				_name = value;
			}
		}

		/*
			The level of the pokemon, can not be less than 1.
			The value can only be modified within this class or its derived classes.
		*/

		public int Level
		{
			get => _level;
			protected set
			{
				ArgumentOutOfRangeException.ThrowIfLessThan(value, 1);
				_level = value;
			}
		}

		/*
			The attacks for the pokemon
			The list can not be null
			To prevent external code from modifying the internal collection
			Get returns a copy
			A set creates a copy

		*/

		public List<Attack> Attacks
		{
			get => new List<Attack>(_attacks);
			protected set
			{
				ArgumentNullException.ThrowIfNull(value, nameof(value));
				_attacks = value.Where(a => a.Type == Type).ToList();
			}
		}

		public Pokemon(string name, int level, ElementType type, List<Attack> attacks)
		{
			Name = name;
			Level = level;
			Type = type;
			Attacks = attacks;
		}

		private static readonly Random _random = new();

		/*
		  Essential C# 12.0, 8th Edition
		  Guideline:
			AVOID accessing the backing field of a property outside the property, even from within the containing class.

			Exempel:
			Här skapas och kopieras en lista 3 gånger.

			public void RandomAttack()
			{
				if (Attacks.Count > 0)
				{
					int index = _random.Next(Attacks.Count);
					Attacks[index].Use(Level);
				}
			}

		*/

		public void RandomAttack()
		{
			if (_attacks.Count > 0)
			{
				int index = _random.Next(_attacks.Count);
				_attacks[index].Use(Level);
			}
		}

		public void Attack()
		{
			if (_attacks.Count > 0)
			{
				int i = 1;
				foreach (var attack in Attacks)
				{
					Console.WriteLine($"{i++}: {attack}");
				}
				Console.Write("Ange attack nummer: ");
				string? answer = Console.ReadLine();

				if (int.TryParse(answer, out int index))
				{
					index -= 1;
					if (index >= 0 && index < _attacks.Count)
						_attacks[index].Use(Level);
					else
						Console.WriteLine("Invalid index");
				}
				else
				{
					Console.WriteLine("Invalid input");
				}
			}
		}

		public void RaiseLevel()
		{
			Level += 1;
			string message = $"{Name} just leveled up to level: {Level}";
			Console.WriteLine(message);
		}

		public override string ToString()
		{
			return $"{Name} (Type: {Type}, Level: {Level}) - Attacks: {Attacks.Count}";
		}
	}
}