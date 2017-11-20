using System;
using System.Collections ;
namespace Composite
{
	/// <summary>
	/// Summary description for AbstractEmployee.
	/// </summary>
	public interface IEmployee
    {
		float getSalary();					//get current salary
		string getName();					//get name
		bool isLeaf();						//true if leaf
		void add(string nm, float salary);	//add subordinate
		void add(IEmployee emp);		//add subordinate
		IEnumerator getSubordinates();		//get subordinates
		IEmployee getChild();		//get child
		float getSalaries();				//get salaries of all 
		IEmployee getBoss();			//get Boss
	}
}
