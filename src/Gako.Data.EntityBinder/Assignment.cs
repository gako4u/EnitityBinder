using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SInt08__ = System.SByte;
using UInt08__ = System.Byte;
using SInt16__ = System.Int16;
using UInt16__ = System.UInt16;
using SInt32__ = System.Int32;
using UInt32__ = System.UInt32;
using SInt64__ = System.Int64;
using UInt64__ = System.UInt64;
using Single__ = System.Single;
using Double__ = System.Double;
using Decimal_ = System.Decimal;
using Boolean_ = System.Boolean;
using String__ = System.String;

namespace Gako.Data.EntityBinder
{
    internal delegate TTo Convert<TTo>(object value);

    internal class Assignment
    {
        static Assignment()
        {
            Assignment.CreateSInt16();
            Assignment.CreateSInt32();
            Assignment.CreateSInt64();
            Assignment.CreateSingle();
            Assignment.CreateDouble();
            Assignment.CreateDecimal();
            Assignment.CreateDateTime();
            Assignment.CreateTimeSpan();
            Assignment.CreateString();
            Assignment.CreateSInt08Array();
        }

        public const float loadFactor = 0.51f;

        private const int DummyValue = 0;

        public static bool Castable<TTo>(Type fromType)
        {
            return AssignmentItem<TTo>.cast___Dic.GetOrDefault(fromType, null) != null;
        }

        public static bool Castable<TFrom, TTo>()
        {
            return AssignmentItem<TFrom, TTo>.cast != null;
        }

        public static TTo Cast<TTo>(object value)
        {
            var func = AssignmentItem<TTo>.cast___Dic[value.GetType()];
            return func(value);
        }

        public static TTo Cast<TFrom, TTo>(object value)
        {
            return AssignmentItem<TFrom, TTo>.cast(value);
        }

        public static bool Convertible<TTo>(Type fromType)
        {
            return AssignmentItem<TTo>.convertDic.GetOrDefault(fromType, null) != null;
        }

        public static bool Convertible<TFrom, TTo>()
        {
            return AssignmentItem<TFrom, TTo>.convert != null;
        }

        public static TTo Convert<TTo>(object value)
        {
            var func = AssignmentItem<TTo>.convertDic[value.GetType()];
            return func(value);
        }

        public static TTo Convert<TFrom, TTo>(object value)
        {
            return AssignmentItem<TFrom, TTo>.convert(value);
        }

        private static void CreateSInt16()
        {
            Assignment.Add<SInt16__>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , true  /* */, false /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , true  /* */, false /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , true  /* */, false /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , true  /* */, false /* */, null                                                      // To Single
                , true  /* */, false /* */, null                                                      // To Double
                , true  /* */, false /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (SInt16__)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime((SInt64__)(SInt16__)val)              // To DateTime
                , false /* */, false /* */, val => new TimeSpan((SInt64__)(SInt16__)val)              // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateSInt32()
        {
            Assignment.Add<SInt32__>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , false /* */, true  /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , true  /* */, false /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , true  /* */, false /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , true  /* */, false /* */, null                                                      // To Single
                , true  /* */, false /* */, null                                                      // To Double
                , true  /* */, false /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (SInt32__)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime((SInt64__)(SInt32__)val)              // To DateTime
                , false /* */, false /* */, val => new TimeSpan((SInt64__)(SInt32__)val)              // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateSInt64()
        {
            Assignment.Add<SInt64__>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , false /* */, true  /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , false /* */, true  /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , true  /* */, false /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , true  /* */, false /* */, null                                                      // To Single
                , true  /* */, false /* */, null                                                      // To Double
                , true  /* */, false /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (SInt64__)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime((SInt64__)val)                        // To DateTime
                , false /* */, false /* */, val => new TimeSpan((SInt64__)val)                        // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateSingle()
        {
            Assignment.Add<Single__>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , false /* */, true  /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , false /* */, true  /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , false /* */, true  /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , true  /* */, false /* */, null                                                      // To Single
                , true  /* */, false /* */, null                                                      // To Double
                , false /* */, true  /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (Single__)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime(checked((SInt64__)(Single__)val))     // To DateTime
                , false /* */, false /* */, val => new TimeSpan(checked((SInt64__)(Single__)val))     // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateDouble()
        {
            Assignment.Add<Double__>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , false /* */, true  /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , false /* */, true  /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , false /* */, true  /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , false /* */, true  /* */, null                                                      // To Single
                , true  /* */, false /* */, null                                                      // To Double
                , false /* */, true  /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (Double__)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime(checked((SInt64__)(Double__)val))     // To DateTime
                , false /* */, false /* */, val => new TimeSpan(checked((SInt64__)(Double__)val))     // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateDecimal()
        {
            Assignment.Add<Decimal_>(
                Assignment.DummyValue
                , false /* */, true  /* */, null                                                      // To SInt08
                , false /* */, true  /* */, null                                                      // To UInt08
                , false /* */, true  /* */, null                                                      // To SInt16
                , false /* */, true  /* */, null                                                      // To UInt16
                , false /* */, true  /* */, null                                                      // To SInt32
                , false /* */, true  /* */, null                                                      // To UInt32
                , false /* */, true  /* */, null                                                      // To SInt64
                , false /* */, true  /* */, null                                                      // To UInt64
                , false /* */, true  /* */, null                                                      // To Single
                , false /* */, true  /* */, null                                                      // To Double
                , true  /* */, false /* */, null                                                      // To Decimal
                , false /* */, false /* */, val => (Decimal_)val != 0                                 // To Boolean
                , false /* */, false /* */, val => new DateTime(checked((SInt64__)(Decimal_)val))     // To DateTime
                , false /* */, false /* */, val => new TimeSpan(checked((SInt64__)(Decimal_)val))     // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateDateTime()
        {
            Assignment.Add<DateTime>(
                Assignment.DummyValue
                , false /* */, false /* */, val => checked((SInt08__)((DateTime)val).Ticks)           // To SInt08
                , false /* */, false /* */, val => checked((UInt08__)((DateTime)val).Ticks)           // To UInt08
                , false /* */, false /* */, val => checked((SInt16__)((DateTime)val).Ticks)           // To SInt16
                , false /* */, false /* */, val => checked((UInt16__)((DateTime)val).Ticks)           // To UInt16
                , false /* */, false /* */, val => checked((SInt32__)((DateTime)val).Ticks)           // To SInt32
                , false /* */, false /* */, val => checked((UInt32__)((DateTime)val).Ticks)           // To UInt32
                , false /* */, false /* */, val => checked((SInt64__)((DateTime)val).Ticks)           // To SInt64
                , false /* */, false /* */, val => checked((UInt64__)((DateTime)val).Ticks)           // To UInt64
                , false /* */, false /* */, val => checked((Single__)((DateTime)val).Ticks)           // To Single
                , false /* */, false /* */, val => checked((Double__)((DateTime)val).Ticks)           // To Double
                , false /* */, false /* */, val => checked((Decimal_)((DateTime)val).Ticks)           // To Decimal
                , false /* */, false /* */, null                                                      // To Boolean
                , true  /* */, false /* */, null                                                      // To DateTime
                , false /* */, false /* */, val => new TimeSpan(((DateTime)val).Ticks)                // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateTimeSpan()
        {
            Assignment.Add<TimeSpan>(
                Assignment.DummyValue
                , false /* */, false /* */, val => checked((SInt08__)((TimeSpan)val).Ticks)           // To SInt08
                , false /* */, false /* */, val => checked((UInt08__)((TimeSpan)val).Ticks)           // To UInt08
                , false /* */, false /* */, val => checked((SInt16__)((TimeSpan)val).Ticks)           // To SInt16
                , false /* */, false /* */, val => checked((UInt16__)((TimeSpan)val).Ticks)           // To UInt16
                , false /* */, false /* */, val => checked((SInt32__)((TimeSpan)val).Ticks)           // To SInt32
                , false /* */, false /* */, val => checked((UInt32__)((TimeSpan)val).Ticks)           // To UInt32
                , false /* */, false /* */, val => checked((SInt64__)((TimeSpan)val).Ticks)           // To SInt64
                , false /* */, false /* */, val => checked((UInt64__)((TimeSpan)val).Ticks)           // To UInt64
                , false /* */, false /* */, val => checked((Single__)((TimeSpan)val).Ticks)           // To Single
                , false /* */, false /* */, val => checked((Double__)((TimeSpan)val).Ticks)           // To Double
                , false /* */, false /* */, val => checked((Decimal_)((TimeSpan)val).Ticks)           // To Decimal
                , false /* */, false /* */, null                                                      // To Boolean
                , false /* */, false /* */, val => new DateTime(((TimeSpan)val).Ticks)                // To DateTime
                , true  /* */, false /* */, null                                                      // To TimeSpan
                , false /* */, false /* */, val => val.ToString()                                     // To String
            );
        }

        private static void CreateString()
        {
            Assignment.Add<String__>(
                Assignment.DummyValue
                , false /* */, false /* */, val => SInt08__.Parse((String__)val)                      // To SInt08
                , false /* */, false /* */, val => UInt08__.Parse((String__)val)                      // To UInt08
                , false /* */, false /* */, val => SInt16__.Parse((String__)val)                      // To SInt16
                , false /* */, false /* */, val => UInt16__.Parse((String__)val)                      // To UInt16
                , false /* */, false /* */, val => SInt32__.Parse((String__)val)                      // To SInt32
                , false /* */, false /* */, val => UInt32__.Parse((String__)val)                      // To UInt32
                , false /* */, false /* */, val => SInt64__.Parse((String__)val)                      // To SInt64
                , false /* */, false /* */, val => UInt64__.Parse((String__)val)                      // To UInt64
                , false /* */, false /* */, val => Single__.Parse((String__)val)                      // To Single
                , false /* */, false /* */, val => Double__.Parse((String__)val)                      // To Double
                , false /* */, false /* */, val => Decimal_.Parse((String__)val)                      // To Decimal
                , false /* */, false /* */, val => Boolean_.Parse((String__)val)                      // To Boolean
                , false /* */, false /* */, val => DateTime.Parse((String__)val)                      // To DateTime
                , false /* */, false /* */, val => TimeSpan.Parse((String__)val)                      // To TimeSpan
                , true  /* */, false /* */, null                                                      // To String
            );
        }

        private static void CreateSInt08Array()
        {
            Assignment.Add<UInt08__[]>(
                Assignment.DummyValue
                , false /* */, false /* */, null                                                      // To SInt08
                , false /* */, false /* */, null                                                      // To UInt08
                , false /* */, false /* */, null                                                      // To SInt16
                , false /* */, false /* */, null                                                      // To UInt16
                , false /* */, false /* */, null                                                      // To SInt32
                , false /* */, false /* */, null                                                      // To UInt32
                , false /* */, false /* */, null                                                      // To SInt64
                , false /* */, false /* */, null                                                      // To UInt64
                , false /* */, false /* */, null                                                      // To Single
                , false /* */, false /* */, null                                                      // To Double
                , false /* */, false /* */, null                                                      // To Decimal
                , false /* */, false /* */, null                                                      // To Boolean
                , false /* */, false /* */, null                                                      // To DateTime
                , false /* */, false /* */, null                                                      // To TimeSpan
                , false /* */, false /* */, val => Encoding.Unicode.GetString((UInt08__[])val)        // To String
            );
        }

        private static void Add<TFrom>(
            int dummy
            , bool castableImplicitlyToSInt08__, bool castableExplicitlyToSInt08__, Convert<SInt08__> convertToSInt08_________
            , bool castableImplicitlyToUInt08__, bool castableExplicitlyToUInt08__, Convert<UInt08__> convertToUInt08_________
            , bool castableImplicitlyToSInt16__, bool castableExplicitlyToSInt16__, Convert<SInt16__> convertToSInt16_________
            , bool castableImplicitlyToUInt16__, bool castableExplicitlyToUInt16__, Convert<UInt16__> convertToUInt16_________
            , bool castableImplicitlyToSInt32__, bool castableExplicitlyToSInt32__, Convert<SInt32__> convertToSInt32_________
            , bool castableImplicitlyToUInt32__, bool castableExplicitlyToUInt32__, Convert<UInt32__> convertToUInt32_________
            , bool castableImplicitlyToSInt64__, bool castableExplicitlyToSInt64__, Convert<SInt64__> convertToSInt64_________
            , bool castableImplicitlyToUInt64__, bool castableExplicitlyToUInt64__, Convert<UInt64__> convertToUInt64_________
            , bool castableImplicitlyToSingle__, bool castableExplicitlyToSingle__, Convert<Single__> convertToSingle_________
            , bool castableImplicitlyToDouble__, bool castableExplicitlyToDouble__, Convert<Double__> convertToDouble_________
            , bool castableImplicitlyToDecimal_, bool castableExplicitlyToDecimal_, Convert<Decimal_> convertToDecimal________
            , bool castableImplicitlyToBoolean_, bool castableExplicitlyToBoolean_, Convert<Boolean_> convertToBoolean________
            , bool castableImplicitlyToDateTime, bool castableExplicitlyToDateTime, Convert<DateTime> convertToDateTime_______
            , bool castableImplicitlyToTimeSpan, bool castableExplicitlyToTimeSpan, Convert<TimeSpan> convertToTimeSpan_______
            , bool castableImplicitlyToString__, bool castableExplicitlyToString__, Convert<String__> convertToString_________
        )
        {
            var castImplicitlyToSInt08__ = castableImplicitlyToSInt08__ ? Assignment.CreateCastImplicitly<TFrom, SInt08__>() : null;
            var castImplicitlyToUInt08__ = castableImplicitlyToUInt08__ ? Assignment.CreateCastImplicitly<TFrom, UInt08__>() : null;
            var castImplicitlyToSInt16__ = castableImplicitlyToSInt16__ ? Assignment.CreateCastImplicitly<TFrom, SInt16__>() : null;
            var castImplicitlyToUInt16__ = castableImplicitlyToUInt16__ ? Assignment.CreateCastImplicitly<TFrom, UInt16__>() : null;
            var castImplicitlyToSInt32__ = castableImplicitlyToSInt32__ ? Assignment.CreateCastImplicitly<TFrom, SInt32__>() : null;
            var castImplicitlyToUInt32__ = castableImplicitlyToUInt32__ ? Assignment.CreateCastImplicitly<TFrom, UInt32__>() : null;
            var castImplicitlyToSInt64__ = castableImplicitlyToSInt64__ ? Assignment.CreateCastImplicitly<TFrom, SInt64__>() : null;
            var castImplicitlyToUInt64__ = castableImplicitlyToUInt64__ ? Assignment.CreateCastImplicitly<TFrom, UInt64__>() : null;
            var castImplicitlyToSingle__ = castableImplicitlyToSingle__ ? Assignment.CreateCastImplicitly<TFrom, Single__>() : null;
            var castImplicitlyToDouble__ = castableImplicitlyToDouble__ ? Assignment.CreateCastImplicitly<TFrom, Double__>() : null;
            var castImplicitlyToDecimal_ = castableImplicitlyToDecimal_ ? Assignment.CreateCastImplicitly<TFrom, Decimal_>() : null;
            var castImplicitlyToBoolean_ = castableImplicitlyToBoolean_ ? Assignment.CreateCastImplicitly<TFrom, Boolean_>() : null;
            var castImplicitlyToDateTime = castableImplicitlyToDateTime ? Assignment.CreateCastImplicitly<TFrom, DateTime>() : null;
            var castImplicitlyToTimeSpan = castableImplicitlyToTimeSpan ? Assignment.CreateCastImplicitly<TFrom, TimeSpan>() : null;
            var castImplicitlyToString__ = castableImplicitlyToString__ ? Assignment.CreateCastImplicitly<TFrom, String__>() : null;

            var castExplicitlyToSInt08__ = castableExplicitlyToSInt08__ ? Assignment.CreateCastExplicitly<TFrom, SInt08__>() : null;
            var castExplicitlyToUInt08__ = castableExplicitlyToUInt08__ ? Assignment.CreateCastExplicitly<TFrom, UInt08__>() : null;
            var castExplicitlyToSInt16__ = castableExplicitlyToSInt16__ ? Assignment.CreateCastExplicitly<TFrom, SInt16__>() : null;
            var castExplicitlyToUInt16__ = castableExplicitlyToUInt16__ ? Assignment.CreateCastExplicitly<TFrom, UInt16__>() : null;
            var castExplicitlyToSInt32__ = castableExplicitlyToSInt32__ ? Assignment.CreateCastExplicitly<TFrom, SInt32__>() : null;
            var castExplicitlyToUInt32__ = castableExplicitlyToUInt32__ ? Assignment.CreateCastExplicitly<TFrom, UInt32__>() : null;
            var castExplicitlyToSInt64__ = castableExplicitlyToSInt64__ ? Assignment.CreateCastExplicitly<TFrom, SInt64__>() : null;
            var castExplicitlyToUInt64__ = castableExplicitlyToUInt64__ ? Assignment.CreateCastExplicitly<TFrom, UInt64__>() : null;
            var castExplicitlyToSingle__ = castableExplicitlyToSingle__ ? Assignment.CreateCastExplicitly<TFrom, Single__>() : null;
            var castExplicitlyToDouble__ = castableExplicitlyToDouble__ ? Assignment.CreateCastExplicitly<TFrom, Double__>() : null;
            var castExplicitlyToDecimal_ = castableExplicitlyToDecimal_ ? Assignment.CreateCastExplicitly<TFrom, Decimal_>() : null;
            var castExplicitlyToBoolean_ = castableExplicitlyToBoolean_ ? Assignment.CreateCastExplicitly<TFrom, Boolean_>() : null;
            var castExplicitlyToDateTime = castableExplicitlyToDateTime ? Assignment.CreateCastExplicitly<TFrom, DateTime>() : null;
            var castExplicitlyToTimeSpan = castableExplicitlyToTimeSpan ? Assignment.CreateCastExplicitly<TFrom, TimeSpan>() : null;
            var castExplicitlyToString__ = castableExplicitlyToString__ ? Assignment.CreateCastExplicitly<TFrom, String__>() : null;

            AssignmentItem<SInt08__>.Add<TFrom>(castImplicitlyToSInt08__, castImplicitlyToSInt08__ ?? castExplicitlyToSInt08__ ?? convertToSInt08_________);
            AssignmentItem<UInt08__>.Add<TFrom>(castImplicitlyToUInt08__, castImplicitlyToUInt08__ ?? castExplicitlyToUInt08__ ?? convertToUInt08_________);
            AssignmentItem<SInt16__>.Add<TFrom>(castImplicitlyToSInt16__, castImplicitlyToSInt16__ ?? castExplicitlyToSInt16__ ?? convertToSInt16_________);
            AssignmentItem<UInt16__>.Add<TFrom>(castImplicitlyToUInt16__, castImplicitlyToUInt16__ ?? castExplicitlyToUInt16__ ?? convertToUInt16_________);
            AssignmentItem<SInt32__>.Add<TFrom>(castImplicitlyToSInt32__, castImplicitlyToSInt32__ ?? castExplicitlyToSInt32__ ?? convertToSInt32_________);
            AssignmentItem<UInt32__>.Add<TFrom>(castImplicitlyToUInt32__, castImplicitlyToUInt32__ ?? castExplicitlyToUInt32__ ?? convertToUInt32_________);
            AssignmentItem<SInt64__>.Add<TFrom>(castImplicitlyToSInt64__, castImplicitlyToSInt64__ ?? castExplicitlyToSInt64__ ?? convertToSInt64_________);
            AssignmentItem<UInt64__>.Add<TFrom>(castImplicitlyToUInt64__, castImplicitlyToUInt64__ ?? castExplicitlyToUInt64__ ?? convertToUInt64_________);
            AssignmentItem<Single__>.Add<TFrom>(castImplicitlyToSingle__, castImplicitlyToSingle__ ?? castExplicitlyToSingle__ ?? convertToSingle_________);
            AssignmentItem<Double__>.Add<TFrom>(castImplicitlyToDouble__, castImplicitlyToDouble__ ?? castExplicitlyToDouble__ ?? convertToDouble_________);
            AssignmentItem<Decimal_>.Add<TFrom>(castImplicitlyToDecimal_, castImplicitlyToDecimal_ ?? castExplicitlyToDecimal_ ?? convertToDecimal________);
            AssignmentItem<Boolean_>.Add<TFrom>(castImplicitlyToBoolean_, castImplicitlyToBoolean_ ?? castExplicitlyToBoolean_ ?? convertToBoolean________);
            AssignmentItem<DateTime>.Add<TFrom>(castImplicitlyToDateTime, castImplicitlyToDateTime ?? castExplicitlyToDateTime ?? convertToDateTime_______);
            AssignmentItem<TimeSpan>.Add<TFrom>(castImplicitlyToTimeSpan, castImplicitlyToTimeSpan ?? castExplicitlyToTimeSpan ?? convertToTimeSpan_______);
            AssignmentItem<String__>.Add<TFrom>(castImplicitlyToString__, castImplicitlyToString__ ?? castExplicitlyToString__ ?? convertToString_________);

            AssignmentItem<TFrom, SInt08__>.Set(castImplicitlyToSInt08__, castImplicitlyToSInt08__ ?? castExplicitlyToSInt08__ ?? convertToSInt08_________);
            AssignmentItem<TFrom, UInt08__>.Set(castImplicitlyToUInt08__, castImplicitlyToUInt08__ ?? castExplicitlyToUInt08__ ?? convertToUInt08_________);
            AssignmentItem<TFrom, SInt16__>.Set(castImplicitlyToSInt16__, castImplicitlyToSInt16__ ?? castExplicitlyToSInt16__ ?? convertToSInt16_________);
            AssignmentItem<TFrom, UInt16__>.Set(castImplicitlyToUInt16__, castImplicitlyToUInt16__ ?? castExplicitlyToUInt16__ ?? convertToUInt16_________);
            AssignmentItem<TFrom, SInt32__>.Set(castImplicitlyToSInt32__, castImplicitlyToSInt32__ ?? castExplicitlyToSInt32__ ?? convertToSInt32_________);
            AssignmentItem<TFrom, UInt32__>.Set(castImplicitlyToUInt32__, castImplicitlyToUInt32__ ?? castExplicitlyToUInt32__ ?? convertToUInt32_________);
            AssignmentItem<TFrom, SInt64__>.Set(castImplicitlyToSInt64__, castImplicitlyToSInt64__ ?? castExplicitlyToSInt64__ ?? convertToSInt64_________);
            AssignmentItem<TFrom, UInt64__>.Set(castImplicitlyToUInt64__, castImplicitlyToUInt64__ ?? castExplicitlyToUInt64__ ?? convertToUInt64_________);
            AssignmentItem<TFrom, Single__>.Set(castImplicitlyToSingle__, castImplicitlyToSingle__ ?? castExplicitlyToSingle__ ?? convertToSingle_________);
            AssignmentItem<TFrom, Double__>.Set(castImplicitlyToDouble__, castImplicitlyToDouble__ ?? castExplicitlyToDouble__ ?? convertToDouble_________);
            AssignmentItem<TFrom, Decimal_>.Set(castImplicitlyToDecimal_, castImplicitlyToDecimal_ ?? castExplicitlyToDecimal_ ?? convertToDecimal________);
            AssignmentItem<TFrom, Boolean_>.Set(castImplicitlyToBoolean_, castImplicitlyToBoolean_ ?? castExplicitlyToBoolean_ ?? convertToBoolean________);
            AssignmentItem<TFrom, DateTime>.Set(castImplicitlyToDateTime, castImplicitlyToDateTime ?? castExplicitlyToDateTime ?? convertToDateTime_______);
            AssignmentItem<TFrom, TimeSpan>.Set(castImplicitlyToTimeSpan, castImplicitlyToTimeSpan ?? castExplicitlyToTimeSpan ?? convertToTimeSpan_______);
            AssignmentItem<TFrom, String__>.Set(castImplicitlyToString__, castImplicitlyToString__ ?? castExplicitlyToString__ ?? convertToString_________);
        }

        private static Convert<TReturn> CreateCastImplicitly<TCast, TReturn>()
        {
            var parameter = Expression.Parameter(typeof(object));

            var convert = Expression.Convert(parameter, typeof(TCast));

            if (typeof(TCast) != typeof(TReturn))
            {
                convert = Expression.Convert(convert, typeof(TReturn));
            }

            var lambda = Expression.Lambda<Convert<TReturn>>(convert, parameter).Compile();
            return lambda;
        }

        private static Convert<TReturn> CreateCastExplicitly<TCast, TReturn>()
        {
            var parameter = Expression.Parameter(typeof(object));

            var convert = Expression.Convert(parameter, typeof(TCast));

            if (typeof(TCast) != typeof(TReturn))
            {
                convert = Expression.ConvertChecked(convert, typeof(TReturn));
            }

            var lambda = Expression.Lambda<Convert<TReturn>>(convert, parameter).Compile();
            return lambda;
        }
    }
}
