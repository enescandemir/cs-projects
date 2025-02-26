using Castle.DynamicProxy;
using System.Reflection;

namespace Core.Utilities.Interceptors
{

    public abstract partial class MethodInterception
    {
        public class AspectInterceptorSelector : IInterceptorSelector
        {
            public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
            {
                var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>  // Sınıfa eklenmiş attribute'leri al
                    (true).ToList();
                var methodAttributes = type.GetMethod(method.Name) // Metoda eklenmiş attribute'leri al
                    .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
                classAttributes.AddRange(methodAttributes); // Metodun aspect'lerini sınıfın aspect'lerine ekle

                return classAttributes.OrderBy(x => x.Priority).ToArray(); // Aspect'leri öncelik sırasına göre sırala ve döndür
            }
        }
    }
}

