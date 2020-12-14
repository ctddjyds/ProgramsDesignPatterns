using System;
using System.Collections ;
namespace Composite
{
	/// <summary>
	/// Summary description for Boss.
	/// </summary>
	public class Boss:Employee
	{
		public Boss(IEmployee parnt, string name, float salary):base(parnt, name,salary) 	
		{
		}
		//------
		public Boss(IEmployee parnt, IEmployee emp):base(parnt, emp.getName() , emp.getSalary()) 	
		{
		}
		//------
		public override void add(string nm, float salary) 
		{
			IEmployee emp = new Employee(this, nm,salary);
			subordinates.Add (emp);
		}
		//------
		public override void add(IEmployee emp)
		{
			subordinates.Add(emp);
		}
		//------
		public override IEmployee getChild() 
		{
			bool found;
			IEmployee tEmp = null;
			IEnumerator esub ;
        
			if (getName().Equals (getName())) 
				return this;
			else 
			{
				found = false;
				esub = subordinates.GetEnumerator ();
				while (! found && esub.MoveNext()) 
				{
					tEmp = (IEmployee)esub.Current; 
					found = (tEmp.getName().Equals(name));
					if (! found) 
					{
						if (! tEmp.isLeaf()) 
						{
							tEmp = tEmp.getChild();
							found = (tEmp.getName().Equals(name));
						}      
				}                             
			}
			if (found) 
			   return tEmp;
			else                
			   return new Employee(null, "New person", 0);
            }
		}
	}
}
