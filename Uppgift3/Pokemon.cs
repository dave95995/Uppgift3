namespace Uppgift3
{
	internal abstract class Pokemon
	{
		private string _name = string.Empty;
		private int _level;
		protected readonly List<Attack> _attacks;
		protected readonly IUserIO _io;

		private static readonly Random _rnd = new Random();

		public string Name
		{
			get => _name;
			protected set
			{
				ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(value));
				if (value.Length < 2 || value.Length > 15)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Name must be between 2 and 15 characters.");
				}
				_name = value;
			}
		}

		public int Level
		{
			get { return _level; }
			protected set
			{
				if (value < 1)
				{
					throw new ArgumentOutOfRangeException(nameof(value), "Level must be above zero.");
				}
				_level = value;
			}
		}

		public ElementType Type { get; }

		public Pokemon(string name, int level, ElementType type, List<Attack> attacks, IUserIO io)
		{
			Name = name;
			Level = level;
			Type = type;
			ArgumentNullException.ThrowIfNull(attacks);
			_attacks = attacks.Where(a => a.Type == type).ToList();
			_io = io;
		}

		public void RandomAttack()
		{
			if (_attacks.Count == 0)
			{
				_io.Print($"{Name} does not have any attacks!");
				return;
			}

			int index = _rnd.Next(_attacks.Count);
			_attacks[index].Use(Level);
		}

		public void Attack()
		{
			if (_attacks.Count == 0)
			{
				_io.Print($"{Name} does not have any attacks!");
				return;
			}

			int index;
			do
			{
				for (int i = 0; i < _attacks.Count; i++)
				{
					_io.Print($"{i} - {_attacks[i]}");
				}
				index = _io.ReadInt("Enter number:");
			} while (index < 0 || index >= _attacks.Count);
			_attacks[index].Use(Level);
		}

		public virtual void RaiseLevel()
		{
			Level++;
			_io.Print($"{Name} leveled up to {Level}");
		}

		public virtual void Speak()
		{
			_io.Print($"{Name} says something..");
		}
	}
}