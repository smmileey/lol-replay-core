using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class RecordingProviderException : Exception
    {
        public RecordingProviderException()
        {
        }

        public RecordingProviderException(string message) : base(message)
        {
        }

        public RecordingProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RecordingProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
