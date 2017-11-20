using System;

namespace Interpreter
{
	/// <summary>
	/// Summary description for Chain.
	/// </summary>
	public interface IChain {
		void addToChain(IChain c);
		void sendToChain(Stack stk);
		IChain getChain();
		
	}
}
