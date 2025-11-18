namespace Uppgift3
{
	internal class ConsoleUI : IUserIO
	{
		public void Print(string message, bool newLine = true)
		{
			if (newLine)
			{
				Console.WriteLine(message);
			}
			else
			{
				Console.Write(message);
			}
		}

		public int ReadInt(string prompt)
		{
			while (true)
			{
				Print(prompt, false);
				string? input = Console.ReadLine();
				if (int.TryParse(input, out var value))
				{
					return value;
				}
			}
		}
	}
}