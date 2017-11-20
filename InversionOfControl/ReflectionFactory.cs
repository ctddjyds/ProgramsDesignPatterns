using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace InversionOfControl
{
    public static class ReflectionFactory
    {
        public static IServiceClassProvider MakeServiceClassProviderName(string ServiceClassProviderName)
        {
            return Assembly.Load("InversionOfControl").CreateInstance("InversionOfControl." + ServiceClassProviderName) as IServiceClassProvider;
            //Type t = ass.GetType("InversionOfControl."+ ServiceClassProviderName);
            //object o = Activator.CreateInstance(t);
        }

    }
}
