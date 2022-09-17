using System;

namespace ObjectMethods.StudentGPA
{
	class StudentGPA
	{
		public string name;
		public string major;
		public double gpa;
		
		public StudentGPA(string aName, string aMajor, double aGPA)
		{
			name = aName;
			major = aMajor;
			gpa = aGPA;
		}
		
		public bool HasHonors()
		{
			if(gpa >= 3.5)
				return true;
			else
                return false;
        }
	}
}