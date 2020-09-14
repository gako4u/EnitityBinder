using Gako.Data.EntityBinder.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.Setters
{
    internal static class EnumConverter<TEnumUnderlying, TEnum>
        where TEnumUnderlying : struct
        where TEnum : struct, Enum
    {
        static EnumConverter()
        {
            EnumConverter<TEnumUnderlying, TEnum>.Converter = EnumConverterCreator.Create<TEnumUnderlying, TEnum, Func<TEnumUnderlying, TEnum>>();
        }

        public static readonly Func<TEnumUnderlying, TEnum> Converter;
    }

    internal static class EnumConverterCreator
    {
        public static TFunc Create<TValue, TReturn, TFunc>()
            where TValue : struct
            where TReturn : struct, Enum
            where TFunc : Delegate
        {
            // val => (TReturn)val;
            var parameter = Expression.Parameter(typeof(TValue));
            var convert = Expression.Convert(parameter, typeof(TReturn));
            var lambda = Expression.Lambda<TFunc>(convert, parameter).Compile();
            return lambda;
        }
    }
}
