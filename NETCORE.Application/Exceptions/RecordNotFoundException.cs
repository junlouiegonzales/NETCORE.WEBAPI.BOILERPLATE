using System;

namespace NETCORE.Application.Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {
        }
    }
}