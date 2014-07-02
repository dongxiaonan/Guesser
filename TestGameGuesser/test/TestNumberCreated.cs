using System;
using NUnit.Framework;
using System.Collections.Generic;
using GameGuesser;

namespace TestGameGuesser
{
	[TestFixture]
	public class TestNumberCreated
	{
		string securityNumber = "1234";
		GuesserNumber guess = new GuesserNumber ("1234");

		[Test]
		public void test_get_different_number()
		{
			bool answer = guess.numberValid (securityNumber);
			Assert.AreEqual(true,answer);
		}
	}


}

