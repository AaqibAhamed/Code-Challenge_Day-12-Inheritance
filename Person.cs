﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_12_Inheritance
{
     class Person
    {
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
		}
		public void printPerson()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}

	}
}
