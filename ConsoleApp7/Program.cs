
using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{

			Assign Assign = new Assign();

			Console.WriteLine("Please enter a number!");
			int inputOne = Convert.ToInt32(Console.ReadLine());
			int methodResult = Assign.ThisThing(inputOne);
			Console.WriteLine("We are going to multiply it by 10!");
			Console.WriteLine(inputOne + " multiplied by ten equals " + methodResult);
			Console.WriteLine("Please enter a decimal number!");
			float inputTwo = Convert.ToSingle(Console.ReadLine());
			int methodTwo = Assign.ThisThing(inputTwo);
			Console.WriteLine("We are going to Math it hard");
			Console.WriteLine(inputTwo + " Plus 40.67 = " + methodTwo);
			Console.Write("Please input a number ");
			string inputThree = (Console.ReadLine());
			int methodThree = Assign.ThisThing(inputThree);
			Console.Write(" We will add two! ");
			Console.WriteLine(inputThree + " Plus Two = " + methodThree);




		}
	}
}

