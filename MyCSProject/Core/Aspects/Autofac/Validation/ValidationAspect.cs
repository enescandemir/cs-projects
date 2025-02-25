using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType) // Bir validator type gönderilir. (ProductValidator)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation) // Validation olduğu için OnBefore override ediliyor.
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // Çalışma anında generic veri tipini bul.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // Parametrelerini bul
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity); // Bulduğun verilerle validate et.
            }
        }
    }
}
