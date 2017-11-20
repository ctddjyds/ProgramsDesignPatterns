using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InversionOfControl
{
    public class ClientClassHost
    {
        private IServiceClassProvider _serviceImpl;
        public ClientClassHost()
        {}
        /// <summary>
        /// 接口注入，一般通过反射实现
        /// </summary>
        /// <param name="serviceClassProviderName"></param>
        public ClientClassHost(string serviceClassProviderName)
        {
            _serviceImpl=ReflectionFactory.MakeServiceClassProviderName(serviceClassProviderName);
        }
        /// <summary>
        /// 构造注入
        /// </summary>
        /// <param name="serviceImpl"></param>
        public ClientClassHost(IServiceClassProvider serviceImpl)
        {
            this._serviceImpl = serviceImpl;
        }


        /// <summary>
        /// Setter注入点,也可使用自动属性方式
        /// </summary>
        /// <param name="serviceImpl"></param>
        public void Set_ServiceImpl(IServiceClassProvider serviceImpl)
        {
            this._serviceImpl = serviceImpl;
        }

        public void ShowInfo()
        {
            Console.WriteLine(_serviceImpl.ServiceInfo());
        }

    }
}
