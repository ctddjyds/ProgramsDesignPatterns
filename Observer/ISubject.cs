using System;

namespace Observer
{
	/// <summary>
	/// Summary description for Subject.
	/// </summary>
	public interface ISubject
    {
        /// <summary>
        /// ע��۲���
        /// </summary>
        /// <param name="obs"></param>
		 void RegisterInterest(IObserver obs);
        /// <summary>
        /// �Ƴ��۲���
        /// </summary>
        /// <param name="obs"></param>
        void UnRegisterInterest(IObserver obs);
        /// <summary>
        /// ״̬�ı�ʱ���������й۲���
        /// </summary>
        void NotifyObversers();
	}
}
