using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Anything.Test
{
    public class Expected
    {
        private Expected() { }

        public static readonly Expected ErrorRaised = new Expected();
    }

    public struct Expected<T>
    {
        public Expected(T value, bool errorRaised)
        {
            this.Value = value;
            this.IsErrorRaised = errorRaised;
        }

        public T Value { get; }

        public bool IsErrorRaised { get; }

        public static implicit operator Expected<T>(T value)
        {
            return new Expected<T>(value, false);
        }

        public static implicit operator Expected<T>(Expected value)
        {
            return new Expected<T>(default, value == Expected.ErrorRaised);
        }
    }
}
