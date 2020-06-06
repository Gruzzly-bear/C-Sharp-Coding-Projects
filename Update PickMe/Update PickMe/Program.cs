using System;
using System.Collections.Generic;
namespace Update_PickMe
{
	class Program
	{
		static void Main()
		{

			string[]
			stringArray = { "These", "People", "At", "My", "Work", "Are", "Off", "In", "Their", "Heads", "I'm", "Sorry", "I", "didn't", "Understand", "At", "first" };
			Console.WriteLine("Hello, Please input a single numerical Digit between 0 and 9.");
			int cho1 = Convert.ToInt32(Console.ReadLine());



			if (cho1 > stringArray.Length)
			{
				Console.WriteLine("That number does not exist in this array. Good Bye");

			}
			if (cho1 > 9 & cho1 < 11)
            {
				Console.WriteLine("You sneaky pete! You found the hidden numbers!");
				Console.WriteLine(stringArray[cho1]);
			}
			else
			{
				Console.WriteLine("Your input has been logged.");
				Console.WriteLine(stringArray[cho1]);
			}


			Console.WriteLine("We will now proceed onto the next excercise.");
			Console.ReadLine();

			int[]
			arrayInt = { 13, 17, 45, 67, 89, 112, 145, 287, 605, 700, 45, 677, 56667, 3333, 22233, 22 };
			Console.WriteLine("Hello, Please input a single numerical Digit between 0 and 9.");
			int cho2 = Convert.ToInt32(Console.ReadLine());



			if (cho2 >= arrayInt.Length)
			{
				Console.WriteLine("That number does not exist in this array. Good Bye");

			}
			else if (cho2 > 9 & cho2 < 11)
			{
				Console.WriteLine("You sneaky pete! You found the hidden numbers!");
				Console.WriteLine(stringArray[cho2]);
			}
			else
			{
				Console.WriteLine("Your input has been logged.");
				Console.WriteLine(arrayInt[cho2]);
			}

			Console.WriteLine("We will now proceed onto the next excercise.");
			Console.ReadLine();

			List<string> strList = new List<string>
			{
				"This world is Crazy",
				"What does it mean to be Human?",
				"Memento Mori",
				"I think I spelled that right",
				"Unsure of everything.",
				"Is it worth it?",
				"Purple tastes funny.",
				"Who are you?",
				"--------------------",
				"Where am I?"
			};
			Console.WriteLine("Hello, Please input a single numerical Digit between 0 and 9. This is the last time. We promise ;)");
			int cho3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(strList[cho3]);

		}

	}
}