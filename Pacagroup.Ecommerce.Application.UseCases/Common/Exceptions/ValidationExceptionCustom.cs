
using System;
using System.Collections.Generic;
using Pacagroup.Ecommerce.Transversal.Common;

namespace Pacagroup.Ecommerce.Application.UseCases.Common.Exceptions
{
    public class ValidationExceptionCustom : Exception
    {
        public IEnumerable<BaseError>? Errors {get;}

        public ValidationExceptionCustom() : base("One or more validations failures")
        {
            Errors = new List<BaseError>();
        }

        public ValidationExceptionCustom(IEnumerable<BaseError>? errors) : this()
        {
            Errors = errors;
        }
    }
}