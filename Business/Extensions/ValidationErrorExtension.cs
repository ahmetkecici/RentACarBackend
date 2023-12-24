using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Validation.Errors;

namespace Business.Extensions
{
    public static class ValidationErrorExtension
    {
        
            public static List<CustomValidationError> ConvertToCustomValidationError(this FluentValidation.Results.ValidationResult validationResult)
            {
                List<CustomValidationError> errors = new();
                foreach (var error in validationResult.Errors)
                {
                    errors.Add(new()
                    {
                        Error = error.ErrorMessage,
                        PropertyName = error.PropertyName
                    });
                }

                return errors;
            }
        
    }
}
