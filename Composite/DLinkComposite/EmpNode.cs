using System;
using System.Windows.Forms;
namespace Composite
{
	/// <summary>
	/// Summary description for EmpNode.
	/// </summary>
	public class EmpNode:TreeNode
    {
		private IEmployee emp;
		public EmpNode(IEmployee aemp ):base(aemp.getName ()) {
			emp = aemp;	
		}
		//-----
		public IEmployee getEmployee() {
			return emp;
		}
	}
}
