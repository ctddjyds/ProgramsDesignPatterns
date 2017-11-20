using System;

namespace ListAdapter
{
	/// <summary>
	/// Summary description for LstAdapter.
	/// </summary>
	public interface IListAdapter 	{
		 void Add(Swimmer sw) ;
		 int SelectedIndex() ;
		 void Clear() ;
		 void clearSelection() ;
	}
}
