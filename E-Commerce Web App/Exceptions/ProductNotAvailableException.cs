using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Exceptions
{
    [Serializable()]
    public class ProductNotAvailableException : Exception
    {
        public long NotAvailableProductSessionId { get; private set; }

        public ProductNotAvailableException()
        {
        }

        public ProductNotAvailableException(long id)
        {
            this.NotAvailableProductSessionId = id;
        }

        public ProductNotAvailableException(string message) : base(message)
        {
        }

        public ProductNotAvailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductNotAvailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
