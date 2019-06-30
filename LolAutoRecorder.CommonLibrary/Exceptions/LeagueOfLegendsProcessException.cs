using System;
using System.Runtime.Serialization;

namespace LolAutoRecorder.CommonLibrary.Exceptions
{
    [Serializable]
    public class LeagueOfLegendsProcessException : Exception
    {
        public LeagueOfLegendsProcessException()
        {
        }

        public LeagueOfLegendsProcessException(string message) : base(message)
        {
        }

        public LeagueOfLegendsProcessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LeagueOfLegendsProcessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}