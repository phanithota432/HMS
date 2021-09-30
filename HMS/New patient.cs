using System;

namespace Immutability
{

	class School
	{
		string schoolname { get; }
		int studentnumber { get; }

		public School(string person, int amount)
		{
			schoolname = person;
			studentnumber = amount;
		}

		public School noofstudents(int increase)
		{
			return new School(schoolname, studentnumber + increase);
		}

		public override string ToString()
		{
			return schoolname + " " + studentnumber;
		}

	}

	public class Demo
	{
		static void Main()
		{
			School x = new School("John", 2000);
			int increase = 1000;
			x = x.noofstudents(increase);
			Console.Write(x.ToString());
		}
	}
}

