using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class CheckForUnprocessedFilesException : Exception
    {
        public CheckForUnprocessedFilesException()
        {
        }

        public CheckForUnprocessedFilesException(string message) : base(message)
        {
        }

        public CheckForUnprocessedFilesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CheckForUnprocessedFilesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
