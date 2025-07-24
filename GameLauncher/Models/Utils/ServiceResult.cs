using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher.Models.Utils
{
    public struct ServiceResult<T>
    {
        public bool Success{ get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public static ServiceResult<T> Ok(T data, string message = "") => new ServiceResult<T> { Success = true, Message = message, Data = data };

        public static ServiceResult<T> Fail(string message) => new ServiceResult<T> { Success = false, Message = message };

        public static ServiceResult<T> Successful(string message = "") => new ServiceResult<T> {Success = true, Message = message };
    }
}
