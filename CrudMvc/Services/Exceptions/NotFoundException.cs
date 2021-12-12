﻿using System;

namespace CrudMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {

        public NotFoundException(string message) : base(message)
        {

        }
    }
}
