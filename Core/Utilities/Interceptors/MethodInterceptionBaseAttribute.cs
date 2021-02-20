using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //https://github.com/engindemirog/NetCoreBackend/blob/master/Core/Utilities/Interceptors adresinden alınmıştır.
    //MethodInterceptionBaseAttribute
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
