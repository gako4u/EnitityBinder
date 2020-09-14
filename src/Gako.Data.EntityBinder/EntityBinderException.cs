using System;
using System.Runtime.Serialization;

namespace Gako.Data.EntityBinder
{
    [Serializable]
    public class EntityBinderException : Exception
    {
        public EntityBinderException()
        {
        }

        public EntityBinderException(string message) : base(message)
        {
        }

        public EntityBinderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntityBinderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
