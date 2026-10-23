using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Exceptions
{
    internal class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }
    }
}
