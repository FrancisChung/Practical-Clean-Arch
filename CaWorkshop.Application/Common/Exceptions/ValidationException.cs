using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CaWorkshop.Application.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException()
            : base("One or more validation errors occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }



        public IDictionary<string, string[]> Errors { get; }
    }
}