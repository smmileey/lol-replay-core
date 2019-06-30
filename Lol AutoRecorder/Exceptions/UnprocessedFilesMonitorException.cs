using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class UnprocessedFilesMonitorException : Exception
    {
        public UnprocessedFilesMonitorException()
        {
        }

        public UnprocessedFilesMonitorException(string message) : base(message)
        {
        }

        public UnprocessedFilesMonitorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnprocessedFilesMonitorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
