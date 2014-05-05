using System;
using NUnit.Framework;
using System.Collections.Generic;
using Guesser;

namespace testGuesser
{
	[TestFixture]
	public class TestNumberCreated
	{
		string securityNumber = "1234";
		GuesserNumber guess = new GuesserNumber ("1234");

		[Test]
		public void test_get_random_number()
		{
			List<string> numberList = new List<string>(10);

			for( int i = 0 ; i<numberList.Capacity ; i++)
			{
				numberList.Add (securityNumber);
			}
			numberList.Sort ();
			bool answer = true;
			for (int i = 1; i < numberList.Capacity; i++) 
			{
				if (numberList [i] == numberList [i - 1])
				{
					answer = false;break;
				}
			};
			Assert.AreEqual(true,answer);
		}

		[Test]
		public void test_get_different_number()
		{
			bool answer = guess.numberValid (securityNumber);
			Assert.AreEqual(true,answer);
		}
	}
}

