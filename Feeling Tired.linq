<Query Kind="Program" />


//namespace Hello *Does this give error because the namespace is already named Query1?
//{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter your name");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, " + name);
			
			Console.WriteLine("How many hours of sleep did you get last night?");
			int hoursofSleep = int.Parse(Console.ReadLine());
			
			if (hoursofSleep >= 8)
			{
				Console.WriteLine("You are well rested!");
			}
			else
			{
				Console.WriteLine("Go back to bed");
			}
		}
	}
//}