using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class PlayerIdProviderException : Exception
    {
        public PlayerIdProviderException()
        {
        }

        public PlayerIdProviderException(string message) : base(message)
        {
        }

        public PlayerIdProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PlayerIdProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
