using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp7
{
	public class Assign
	{

		public int ThisThing(int inputOne)
		{

			int doMath = inputOne * 10;
			return doMath;


		}

		public int ThisThing(float inputTwo)
		{
			float ohNoes = (float)(inputTwo + 40.67);
			return (int)ohNoes;

		}
		public int ThisThing(string inputThree)
		{
			
			int number;
			

			bool isParsable = Int32.TryParse(inputThree, out number);

			if (isParsable)

				return number + 2;
			else
				Console.WriteLine(inputThree + "Is not a number");
			return number;



		}


	}
}
