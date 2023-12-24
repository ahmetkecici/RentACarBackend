using Core.Validation.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>
    {

        bool Success { get; }
        string Message { get; }
       T Data { get; }
    }

    public class DataResult<T>:IDataResult<T>
    {
        public DataResult(bool success, string message, T data) : this(success)
        {
            Message = message;
            Data = data;
        }
        public DataResult(bool success,T data) : this(success)
        {
            Data =data ;
        }
        public DataResult(bool success, string message) : this(success)
        {
            Message = message;
        }

        public DataResult(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
        public T Data { get; }

    }
}
