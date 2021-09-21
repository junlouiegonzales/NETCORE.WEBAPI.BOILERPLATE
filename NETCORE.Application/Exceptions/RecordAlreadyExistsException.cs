using System;

namespace NETCORE.Application.Exceptions
{
    public class RecordAlreadyExistsException : Exception
    {
        public RecordAlreadyExistsException(string message) : base(message)
        {
        }
    }
}