using System;

namespace FFT
{
	/// <summary>
	/// Summary description for Cocoon.
    /// �򵥹���,����һ�㶼�Ǿ�̬��
	/// </summary>
	public class CocoonFactory
    {
		static public Butterfly getButterfly(float y)
        {
			if (y != 0)
				return new TrigButterfly(y);
			else
				return new AddButterfly(y);
		}
	}
}
