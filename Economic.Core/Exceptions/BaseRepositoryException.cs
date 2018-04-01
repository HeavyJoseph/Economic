using System;

namespace Economic.Core.Exceptions
{
    public class BaseRepositoryException : BaseException
    {
        public Exception NotFindException
        {
            get
            {
                return new Exception("No existe un valor que corresponda con esta busqueda.");
            }
        }

        public Exception NotSelectedException
        {
            get
            {
                return new Exception("Ningun elemento encontrado.");
            }
        }
    }
}
