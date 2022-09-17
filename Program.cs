using System;
using ObjectMethods.StudentGPA;

namespace ObjectMethodsEntryPage
{
	class Program
	{
		static void Main(string[]args)
		{
			var student1 = new StudentGPA("Folasayo", "Software Engineering", 4.0);
			var student2 = new StudentGPA("Samuel", "Computer Science", 3.8);
			
			Console.WriteLine(student1.HasHonors());
			Console.WriteLine(student2.HasHonors());

			Console.ReadLine();
		}
	}
}