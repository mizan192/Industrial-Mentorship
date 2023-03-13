
using System;

public class Input_output
{
	public static void Main()
	{
		Console.WriteLine("Enter name : ");
		string text = Console.ReadLine();
		Console.WriteLine("your data is : " + text);

		//handle int input
		string given = Console.ReadLine();
		int num = Convert.ToInt32(given);
		Console.WriteLine("Converted num : " + num);

	}
}