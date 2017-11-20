using System;

namespace FFT
{
	/// <summary>
	/// Summary description for AddButterfly.
    /// �����Ʒ
	/// </summary>
	class AddButterfly : Butterfly 
	{
	   float oldr1, oldi1;

		public AddButterfly(float angle) {
		}
		public override void Execute(Complex xi, Complex xj)
        {
			oldr1 = xi.getReal();
			oldi1 = xi.getImag();
			xi.setReal(oldr1 + xj.getReal());
			xj.setReal(oldr1 - xj.getReal());
			xi.setImag(oldi1 + xj.getImag());
			xj.setImag(oldi1 - xj.getImag());
		}
	}

}
