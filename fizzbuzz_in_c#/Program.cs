using System;

namespace fizzbuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			int num = int.Parse (input);
			if(num % 15 == 0)
			{
				Console.WriteLine ("Fizzbuzz");
		    }
			else if(num % 3 == 0)
			{
				Console.WriteLine ("Fizz");
		    }
			else if(num % 5 == 0)
			{
				Console.WriteLine ("Buzz");
			}
			else
			{
				Console.WriteLine (num);
			};
		}
	}
}
