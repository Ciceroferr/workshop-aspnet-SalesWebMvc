using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : AccessViolationException
    { 
        public NotFoundException(string message) : base(message)
        {
        }
    }
}
