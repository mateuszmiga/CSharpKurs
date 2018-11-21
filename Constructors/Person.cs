using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	class Person
	{
		int id;
		string firstName;
		string lastName;
		string address;
		int age;
		string gender;


		public Person()
		{
			id = 1;
			firstName = "matt";
			lastName = "mig";
			age = 14;

		}

		public Person(int id, string firstName, string lastName, string address, int age, string gender)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			this.address = address;
			this.age = age;
			this.gender = gender;
		}

		public Person(int id, string firstName, string lastNam)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
			address = "katowice";
			age = 18;

		}
		public Person(int id, string firstName)
		{
			this.id = id;
			this.firstName = firstName;
		}
	}
}
