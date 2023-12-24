using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validation.Errors
{
    public class CustomValidationError
    {
        public string PropertyName { get; set; }
        public string Error { get; set; }
    }
}
