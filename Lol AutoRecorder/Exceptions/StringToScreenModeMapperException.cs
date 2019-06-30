using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class StringToScreenModeMapperException : Exception
    {
        public StringToScreenModeMapperException()
        {
        }

        public StringToScreenModeMapperException(string message) : base(message)
        {
        }

        public StringToScreenModeMapperException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringToScreenModeMapperException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
