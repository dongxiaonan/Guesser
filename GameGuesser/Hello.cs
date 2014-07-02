using System;

namespace GameGuesser
{
	public class Hello
	{
		public static void Main ()
		{
			var obj = new GuesserNumber ();
			Console.WriteLine ("Game start : enter a number you guess \n");
			string num = "1234";
			Console.WriteLine (obj.guessNumber(num));
		}
	}
}

