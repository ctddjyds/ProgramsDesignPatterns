using System;

namespace GlobalSpooler
{
    /// <summary>
    /// 懒汉式单例模式
    /// Summary description for Spooler.
    /// </summary>
    public class Spooler
    {
		private static bool instance_flag= false;
		private Spooler()
        {
            instance_flag = true;
        }
        //简单模式
		public static Spooler getSpooler()
        {
			if (! instance_flag) 
				return new Spooler ();
			else
				return null;
		}
        private static Spooler m_instanceSpooler;
        private static readonly object m_objectPadLock = new object();
        public static Spooler InstanceSpooler
        {
            get
            {
                //并不是线程安全的，在多线程模式下，可能产生第二个实例
                //return m_instance == null ? new RectangleMethod() : m_instance;
                //采用双锁定技术
                if (m_instanceSpooler == null)
                {
                    lock (m_objectPadLock)
                    {
                        if (m_instanceSpooler == null)
                            m_instanceSpooler = new Spooler();
                    }
                }
                return m_instanceSpooler;
            }
        }
    }
    /// <summary>
    ///饿汉式单例类
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Singleton singleton = new Singleton();
        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
