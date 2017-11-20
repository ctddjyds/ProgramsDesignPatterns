using System;

namespace Observer
{
	/// <summary>
	/// Summary description for Subject.
	/// </summary>
	public interface ISubject
    {
        /// <summary>
        /// 注册观察者
        /// </summary>
        /// <param name="obs"></param>
		 void RegisterInterest(IObserver obs);
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="obs"></param>
        void UnRegisterInterest(IObserver obs);
        /// <summary>
        /// 状态改变时，更新所有观察者
        /// </summary>
        void NotifyObversers();
	}
}
