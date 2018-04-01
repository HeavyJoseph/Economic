using System;

namespace Economic.Core.Exceptions
{
    public class BaseException : Exception
    {
        public BaseException() : base("Excepcion no controlada.")
        {
        }
    }
}
