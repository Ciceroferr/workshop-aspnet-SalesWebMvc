﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class DbConcurrencyException : AccessViolationException
    {
        public DbConcurrencyException(string message): base(message)
        {
        }
    }
}
