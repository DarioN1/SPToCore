using System;
using System.Runtime.Serialization;

namespace SPToCore
{
    [Serializable]
    internal class UnknownDBTypeException : Exception
    {
        public UnknownDBTypeException()
        {
        }

        public UnknownDBTypeException(string message) : base(message)
        {
        }

        public UnknownDBTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownDBTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}