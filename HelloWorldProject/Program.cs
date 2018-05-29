using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			Student foster = new Student();
			foster.SetFirstname("Foster");
			foster.SetLastname("Stulen");
			foster.setID(123);
			String fn;
			fn=foster.GetFirstname();
			string ln = foster.GetLastname();
			foster.SetGpa(4.02);
			foster.setSat(1200);
			foster.setIsFemale(false);
			int id = foster.getId();
			int sat = foster.getSat();
			double gpa = foster.getGpa();
			bool female = foster.getIsfemale();
			Console.WriteLine(fn+" "+ln +" "+id+" "+sat+" "+gpa+" "+female);
			
		}
	}
}
