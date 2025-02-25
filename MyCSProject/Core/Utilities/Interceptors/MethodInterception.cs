﻿using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{

    public abstract partial class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation) // invocation -> çalıştırılmak istenen method
        {
            var isSuccess = true;
            OnBefore(invocation); // methodun başında attribute uygula
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e); // methodda hata alırsan attribute uygula
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation); // method başarılıysa attribute uygula
                }
            }
            OnAfter(invocation); // en son attribute uygula
        }
    }
}

