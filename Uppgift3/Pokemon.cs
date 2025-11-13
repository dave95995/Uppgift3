using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
	internal abstract class Pokemon
	{
		private string _name = string.Empty;
		private int _level;
		private List<Attack> _attacks = [];

		/*
		* The element type for the pokemon.
		* The property is read-only.
		*/
		public ElementType Type { get; }

		/*
		* The name of the pokemon, can not be null or contain only white space.
		* The name must be between 2 and 15 characters.
		* The value can only be modified within this class or its derived classes.
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
		* The level of the pokemon, can not be less than 1.
		* The value can only be modified within this class or its derived classes.
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
		* The attacks for the pokemon
		* 
		* The value can only be modified within this class or its derived class
		* The set method creates a copy of the list to prevent external code from modifying the internal collection
		*/
		public List<Attack> Attacks { 
			protected get => _attacks; 
			set
			{
				_attacks = new List<Attack>(value);
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

		public void RandomAttack()
		{
			_attacks[0].Use(Level);
		}

		public void Attack()
		{

		}


		public void RaiseLevel()
		{
			Level += 1;
			string message = $"{Name} just leveled up to level: {Level}";
			Console.WriteLine(message);
		}
	}
}