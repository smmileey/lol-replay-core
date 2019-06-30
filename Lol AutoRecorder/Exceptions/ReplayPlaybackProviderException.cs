using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class ReplayPlaybackProviderException : Exception
    {
        public ReplayPlaybackProviderException()
        {
        }

        public ReplayPlaybackProviderException(string message) : base(message)
        {
        }

        public ReplayPlaybackProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReplayPlaybackProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
