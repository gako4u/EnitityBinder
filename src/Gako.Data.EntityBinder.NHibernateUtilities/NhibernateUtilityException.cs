using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gako.Data.EntityBinder.NHibernateUtilities
{
    public class NhibernateUtilityException : Exception
    {
        public NhibernateUtilityException(string message) : base(message)
        {
        }

        public NhibernateUtilityException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
