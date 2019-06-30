using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class RestRepositoryException : Exception
    {
        public RestRepositoryException()
        {
        }

        public RestRepositoryException(string message) : base(message)
        {
        }

        public RestRepositoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RestRepositoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
