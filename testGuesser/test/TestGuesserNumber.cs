using System;
using NUnit.Framework;
using System.Collections.Generic;
using Guesser;

namespace testGuesser
{
	[TestFixture]
	public class TestGuseeNumber : GuesserNumber
	{
		string securityNumber = "1234";
		GuesserNumber guess = new GuesserNumber ("1234");


		[Test]
		public void given_correct_number_get_4A0B()
		{
			string expectedAnswer = "4A0B";
			string answer = guess.guessNumber (securityNumber);
			Assert.AreEqual(expectedAnswer,answer);
		}

		[Test]
		public void given_correct_number_in_wrong_place_get_0A4B()
		{
			string input="";
			for (int i=0;i<securityNumber.Length;i++) 
			{
				input += securityNumber [securityNumber.Length-i-1];
			}
			string expectedAnswer = "0A4B";
			string answer = guess.guessNumber (input);
			Assert.AreEqual(expectedAnswer,answer);
		}

		[Test]
		public void given_wrong_number_get_0A0B()
		{
			string input = "5678" ;
			string expectedAnswer = "0A0B";
			string answer = guess.guessNumber (input);
			Assert.AreEqual(expectedAnswer,answer);
		}

		[Test]
		public void given_number_get_correct_answer()
		{
			string input = "3174";
			string expectedAnswer = "1A2B";
			string answer = guess.guessNumber (input);
			Assert.AreEqual(expectedAnswer,answer);
		}


	}
}

