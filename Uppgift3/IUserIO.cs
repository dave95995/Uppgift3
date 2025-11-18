namespace Uppgift3
{
	internal interface IUserIO
	{
		void Print(string message, bool newLine = true);

		int ReadInt(string prompt);
	}
}