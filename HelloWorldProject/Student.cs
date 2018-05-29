using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
	class Student
	{
		string firstName;
		string lastName;
		int id;
		double gpa;
		int SAT;
		bool IsFemale;

		public String GetFirstname()
		{
			return firstName;
		}
		public string GetLastname()
		{
			return lastName;
		}
		public void SetFirstname(string fn)
		{
			firstName = fn;
		}
		public void SetLastname(string ln)
		{
			lastName = ln;
		}
		public void setID(int num)
		{
			id = num;
		}
		public int getId()
		{
			return id;
		}
		public void SetGpa(double pGpa)
		{
			gpa = pGpa;
		}
		public double getGpa()
		{
			return gpa;
		}
		public void setSat(int psat)
		{
			SAT = psat;
		}
		public int getSat()
		{
			return SAT;
		}
		public void setIsFemale(bool morf)
		{
			IsFemale = morf;
		}
		public bool getIsfemale()
		{
			return IsFemale;
		}
	}

}
