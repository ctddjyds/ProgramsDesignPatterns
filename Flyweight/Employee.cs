using System;

namespace Flyweight
{
	/// <summary>
	/// Summary description for Employee.
	/// </summary>
	public class Employee : Person
    {
		public Employee(string nm, int ag):base(nm, ag)
        {
		}
		public override string getJob()
        {
			return "Worker";
		}
	}
}
