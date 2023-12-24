using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Validation.Errors;

namespace Core.Utilities.Results
{
    public interface IResult
    {
       
            bool Success { get; }
            string Message { get; }
            List<CustomValidationError> ValidationErrors { get;}

    }

    public class Result : IResult
    {

        public Result(bool success, string message,List<CustomValidationError> validationErrors) : this(success)
        {
            Message = message;
            ValidationErrors = validationErrors;
        }
        public Result(bool success, List<CustomValidationError> validationErrors) : this(success)
        {
           ValidationErrors=validationErrors;
        }
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public List<CustomValidationError> ValidationErrors { get; }


    }
}
