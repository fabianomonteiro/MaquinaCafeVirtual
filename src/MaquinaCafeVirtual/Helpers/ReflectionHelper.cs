using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Helpers
{
    public static class ReflectionHelper
    {
        public static IEnumerable<Type> FindDerivedTypes<T>()
        {
            Type baseType = typeof(T);

            return Assembly.GetAssembly(baseType).GetTypes().Where(t => t != baseType && baseType.IsAssignableFrom(t) && !t.IsAbstract);
        }
    }
}
