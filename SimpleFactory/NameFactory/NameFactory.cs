using System;

namespace NameFactory
{
	/// <summary>
	/// Summary description for NameFactory.
	/// </summary>
	public class NameFactory
    {
		public static Namer getName(string name)
        {
			int i = name.IndexOf (",");
			if(i > 0)
				return new LastFirst (name);
			else
				return new FirstFirst (name);
		}
	}
}
