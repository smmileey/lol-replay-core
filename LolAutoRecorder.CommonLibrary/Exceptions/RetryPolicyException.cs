using System;
using System.Runtime.Serialization;

namespace LolAutoRecorder.CommonLibrary.Exceptions
{
    public class RetryPolicyException : Exception
    {
        public RetryPolicyException()
        {
        }

        public RetryPolicyException(string message) : base(message)
        {
        }

        public RetryPolicyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RetryPolicyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
