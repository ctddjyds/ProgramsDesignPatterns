using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    public class DefaultServiceClassProvider : IServiceClassProvider
    {
        public void Run(Action action)
        {
            Task.Factory.StartNew(action);
        }

        public string ServiceInfo()
        {
            return "我是DefaultServiceClassProvider";
        }
    }
}
