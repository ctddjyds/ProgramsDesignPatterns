using System;

namespace GlobalSpooler
{
    /// <summary>
    /// ����ʽ����ģʽ
    /// Summary description for Spooler.
    /// </summary>
    public class Spooler
    {
		private static bool instance_flag= false;
		private Spooler()
        {
            instance_flag = true;
        }
        //��ģʽ
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
                //�������̰߳�ȫ�ģ��ڶ��߳�ģʽ�£����ܲ����ڶ���ʵ��
                //return m_instance == null ? new RectangleMethod() : m_instance;
                //����˫��������
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
    ///����ʽ������
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
