using System;

namespace CommandUndo
{
	/// <summary>
	/// defines Command interface
	/// </summary>
	public interface ICommand
    {
		void Execute();
		void Undo();
		bool isUndo();
	}
}
