using System;
using System.Collections ;
namespace FileredIterator
{
	/// <summary>
	/// Summary description for KidIterator.
	/// </summary>
	public class KidIterator : IEnumerator
    {
		//我们常用的 for 和 foreach，其实就是 MS 给我们封装后的迭代器模式。
		private ArrayList kids;
		private int index;
		public KidIterator(ArrayList kidz)
        {
			kids = kidz;
			index = 0;
		}
		//------
		public bool MoveNext()
        {
			index++;
			return index < kids.Count ;
		}
		//------
		public object Current
        {
			get 
			{
				return kids[index];
			}
		}
		//------
		public void Reset()
        {
			index = 0;
		}
	}
}
