using System;
using System.Collections.Generic;

namespace GameGuesser
{
	public class GuesserNumber
	{

		public GuesserNumber()
		{
			numberCreate ();
			guessCount = 0;
		}

		public GuesserNumber(string num)
		{
			SecurityNumber = num;;
		}

		protected void setSecurityNumber(string num)
		{
			SecurityNumber = num;
		}

		public string guessNumber (string input)
		{
			guessCount++;
			int localRight = 0;
			int right = 0;
			for (int i=0 ;i< SecurityNumber.Length;i++) 
			{
				for (int j=0; j<input.Length;j++) 
				{
					if ((input [j] == SecurityNumber [i]) && i == j)
						right++;
					if ((input [j] == SecurityNumber [i]) && i != j)
						localRight++;
				}
			}
			string r1 = Convert.ToString(right);
			string r2 = Convert.ToString(localRight);
			return (r1 + "A" + r2 + "B");
		}

		public void numberCreate()
		{
			List<int> data = new List<int> (4);
			var ran = new Random ();

			while (data.Count < 4) 
			{
				int temp = ran.Next(0,10);
				if (!data.Contains(temp))
					data.Add (temp);
			}
				
			SecurityNumber = translate(data);
		}

		public static string translate(List<int> data)
		{
			string ans = "";
			for (int i = 0; i < data.Capacity; i++)
			{
				string temp = Convert.ToString (data [i]);
				ans += temp;
			}
			return ans;
		}

		public bool numberValid(string num)
		{
			for (int i = 0; i < num.Length; i++)
				for (int j = i+1; j < num.Length; j++)
					if (num [i] == num [j]) return false;
			return true;
		}

		public string SecurityNumber;
		public int guessCount;
	}
}

