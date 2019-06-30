using System;
using System.Runtime.Serialization;

namespace Lol_AutoRecorder.Exceptions
{
    public class LeagueClientLauncherException : Exception
    {
        public LeagueClientLauncherException()
        {
        }

        public LeagueClientLauncherException(string message) : base(message)
        {
        }

        public LeagueClientLauncherException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LeagueClientLauncherException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
