using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Utilities
{
    internal static class RefrectionUtility
    {
        public static bool IsNullable(this Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public static IEnumerable<PropertyInfo> GetAccessibleProperties<T>()
        {
            return RefrectionUtility.GetAccessibleProperties(typeof(T));
        }

        public static IEnumerable<PropertyInfo> GetAccessibleProperties(this Type type)
        {
            var typePriorities =
                RefrectionUtility.GetTypeHierarchy(type)
                    .Select((t, i) => new { t, i }).ToDictionary(item => item.t, item => item.i);

            var props =
                type
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GroupBy(prop => prop.Name)
                    .Select(group => group.OrderBy(prop => typePriorities[prop.DeclaringType]))
                    .Select(group => group.First())
                    .OrderBy(prop => prop.Name);

            return props;
        }

        public static IEnumerable<Type> GetTypeHierarchy<T>()
        {
            return RefrectionUtility.GetTypeHierarchy(typeof(T));
        }

        public static IEnumerable<Type> GetTypeHierarchy(this Type type)
        {
            return enumerate(type);

            IEnumerable<Type> enumerate(Type _type)
            {
                for (var t = _type; t != null; t = t.BaseType)
                {
                    yield return t;
                }
            }
        }
    }
}
